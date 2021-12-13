using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "azsDataSet.Car_Filling_Station". При необходимости она может быть перемещена или удалена.
            this.car_Filling_StationTableAdapter.Fill(this.azsDataSet.Car_Filling_Station);
            GetList();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList()
        {
            con = new SqlConnection(@"Data Source=LAPTOP-IUFK5CBJ\DIMON;Initial Catalog=azs;User ID=sa;Password=123");
            da = new SqlDataAdapter("Select * from Car_Filling_Station", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Car_Filling_Station");
            dataGridView1.DataSource = ds.Tables["Car_Filling_Station"];
            dataGridView1.Columns[0].Visible = false;
            con.Close();
        }

        /// <summery>
        /// INSERT
        /// </summery>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = String.Format("insert into Car_Filling_Station(list_Address, list_Station_ID, list_data_Name, list_data_Price, list_data_AmountOfFuel) values ('{0}','{1}','{2}','{3}','{4}')", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }
    }
}
