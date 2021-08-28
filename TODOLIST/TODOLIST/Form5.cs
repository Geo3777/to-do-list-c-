using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToDoLIst
{
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Otgon\Desktop\TAP\proiect tappp11\TODOLIST\TODOLIST\Database1.mdf;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
          

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void fill_listbox()
        {
            DateTime dt1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            int myVal = Form1.count;

      


            cmd.CommandText = "SELECT Name from trophy WHERE checked>= '5' OR checked >= '20'";



            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               listView1.Items.Add(dr["Name"].ToString());


            }
            conn.Close();

        }


        private void TrophiesBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void trophyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trophyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.trophy' table. You can move, or remove it, as needed.

            fill_listbox();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            



        }

        private void LabelTro_Click(object sender, EventArgs e)
        {

        }
    }
}
