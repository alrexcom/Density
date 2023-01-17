using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Density
{
    public partial class Form1 : Form
    {
        DataBase bd = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string qsql = "SELECT IdStandard3900Density, Temperature, AreometerDensity, Density  FROM [OperationalRegistrationTest].[dbo].[Standard3900Density]";
            SqlCommand command = new SqlCommand(qsql, bd.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            decimal temperature = decimal.Parse(txtTemperature.Text);
            decimal labTemperature = decimal.Parse(txtLabourTemperature.Text);
            decimal labDensity = decimal.Parse(txtLabDensity.Text);
            decimal density = 0;
            if (table.Rows.Count > 0)
            {
              //  if (Decimal.TryParse(txtTemperature.Text, out temperature) && Decimal.TryParse(txtLabourTemperature.Text, out labTemperature)
                //    && Decimal.TryParse(txtLabDensity.Text, out labDensity))
                    density = Rashet.ProductDensityByStandard3900(ConvertToList(table), labDensity, labTemperature, temperature);

                lblDensity.Text = density.ToString();

            }
        }

        private IEnumerable<Standard3900Record> ConvertToList(DataTable table)
        {
            var res = new List<Standard3900Record>();

            foreach (DataRow row in table.Rows)
            {
                var values = row.ItemArray;
                var category = new Standard3900Record()
                {
                    IdStandard3900Density = (int)values[0],
                    Temperature = (decimal)values[1],
                    AreometerDensity = (decimal)values[2],
                    Density = (decimal)values[3]
                };
                res.Add(category);
            }

            return res;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
         //   MessageBox.Show("Закрываем соединение", "jr", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bd.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rashet.RefreshVolume();
        }
    }
}

