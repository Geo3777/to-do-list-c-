using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ToDoLIst
{
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Otgon\Desktop\TAP\proiect tappp11\TODOLIST\TODOLIST\Database1.mdf;Integrated Security=True");
        private object dataGridView1;

        public Form3()
        {
            InitializeComponent();
        
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TaskBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void TaskSave_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [task] (Name,Date,Time) values ('"+NumeTask.Text+"','"+Date.Text+"','"+Time.Text+"')";
            cmd.ExecuteNonQuery();
            conn.Close();
           
            NumeTask.Text = "";
            Date.Text = "";
            Time.Text = "";
           


            MessageBox.Show("Data inserted Successfully");
        }



        private void NumeTask_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
