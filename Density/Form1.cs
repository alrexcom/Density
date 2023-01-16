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
           SqlDataAdapter adapter= new SqlDataAdapter(); 
            DataTable table= new DataTable();
            string qsql = "SELECT *  FROM [OperationalRegistrationTest].[dbo].[Standard3900Density]";
            SqlCommand command = new SqlCommand(qsql, bd.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Зашёл","Вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Закрываем соединение", "jr", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bd.CloseConnection();
        }
    }
}
