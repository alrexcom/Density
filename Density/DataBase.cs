using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;

namespace Density
{
    class DataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=VLG-5CD5491NCN; Initial Catalog=OperationalRegistrationTest;Integrated Security=True");

        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed) con.Open();

        }
        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open) con.Close();

        }

        public SqlConnection GetConnection()
        {
            return con;
        }

        //public static string SqlDensity
        //{
//            get
//            {
//                return "
//                declare
//@tank int = 5444,
//@date datetime = '2023-01-13 06:00:00.000',
//@PointOfRegistration int = 9890,
//@FloorTemperature float,
//@Temperature float,
//@LabDensity float

//SELECT top 1 @LabDensity = LabDensity,  @Temperature = temperature, @FloorTemperature = FLOOR(Temperature)
//--SELECT top 1  LabDensity, labTemperature,temperature, FLOOR(Temperature) FloorTemperature
//FROM OperationalRegistrationTest.dbo.udf_TankStates4PointGet(@date, @PointOfRegistration, @date)
//where[Object] = @tank
//order by[Date];

//                ; with
//ss as (
//select r.IdStandard3900Density, r.Temperature, r.AreometerDensity, r.Density, @LabDensity / 1000 as baseDensity,
//abs(r.Density - (@LabDensity / 1000)) as drho
//from OperationalRegistrationTest.dbo.Standard3900Density r where r.temperature in (
//SELECT max(Temperature) as tempTemperature from Standard3900Density
//where Temperature >= @FloorTemperature and Temperature <= @Temperature)
//),
//mnDrho as
//(
//select min(drho)drho
//from ss
//)
//select-- s.IdStandard3900Density, s.Temperature, s.AreometerDensity, s.Density ,
//(AreometerDensity + (baseDensity - Density)) * 1000 as rasDensity
//from ss s
//inner
//join mnDrho m  on m.drho = abs(s.Density - s.baseDensity) ;"


           // }
       // }

    }
}
