﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Density
{
    class Rashet
    {
        
      
        
        public static decimal ProductDensityByStandard3900(IEnumerable<Standard3900Record> table, decimal labDensity, decimal labTemperature, decimal temperature)
        {

            decimal result = 0.0M;  // Вычисленная плотность
            IEnumerable<Standard3900Record> densitiesOnTargetTemperature = new List<Standard3900Record>();
            IEnumerable<Standard3900Record> tempTemperatureCollection = new List<Standard3900Record>();
            decimal? tempTemperature = null;
            if (table == null)
            {
                throw new ArgumentNullException("table", "Не задана коллекция с записями таблицы вычисления плотности из ГОСТ 3900-85");
            }
            if (temperature != null)
            {
                decimal celling = Math.Ceiling(temperature);
                decimal floor = Math.Floor(temperature);
                //   table.FindAll(record => record.Temperature >= floor && record.Temperature <= celling);
                tempTemperatureCollection = table.Where(record => record.Temperature >= floor && record.Temperature <= celling);

                double dt = 1;

                foreach (Standard3900Record item in tempTemperatureCollection)
                {
                    double t = Math.Abs((double)item.Temperature - (double)temperature);
                    if (t < dt)
                    {
                        dt = t;
                        tempTemperature = item.Temperature;
                    }
                }
                // Получение записей, соответствующих лабораторной температуре
                if (tempTemperature != null)
                {
                    densitiesOnTargetTemperature = table.Where(record => record.Temperature == (decimal)tempTemperature);
                }
            }
            // Вычисление плотности на основании данных таблицы из ГОСТ 3900-85
            if (densitiesOnTargetTemperature.Count() > 0)
            {
                decimal dRho = 1000.0M;             // Отклонение плотности из таблицы от лабораторной плотности
                decimal baseDensity = Convert.ToDecimal(labDensity / 1000.0M);  // Лабораторная плотность
                decimal tableDensity = 0.0M;
                decimal areometerDensity = 0.0M;    // Плотность по ареометру

                // Считывание данных из записи, наиболее подходящей по плотности и лабораторной температуре
                foreach (Standard3900Record item in densitiesOnTargetTemperature)
                {
                    if (Math.Abs(item.Density - baseDensity) < dRho)
                    {
                        dRho = Math.Abs(item.Density - baseDensity);
                        areometerDensity = item.AreometerDensity;
                        tableDensity = item.Density;
                    }
                }

                // Вычисление плотности нефтепродукта
                result = (areometerDensity + (baseDensity - tableDensity)) * 1000.0M;
            }

            return result;
        }
    }


}