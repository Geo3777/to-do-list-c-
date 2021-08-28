using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Linq;


namespace ToDoLIst
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Otgon\Desktop\TAP\proiect tappp11\TODOLIST\TODOLIST\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        public static int count = 0;
        public static int a = 0;
        private void Calendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        public void fill_listbox()
        {
            DateTime dt1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            nameCheckedListBox.Items.Clear();
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Name from task WHERE Date= '" + dt1 + " '";



            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                nameCheckedListBox.Items.Add(dr["Name"].ToString());


            }
            conn.Close();

        }

        public void change(SqlCommand cmd, SqlConnection conn)
        {
            if (conn.State != ConnectionState.Open) conn.Open();

            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "UPDATE trophy SET checked=checked+1  WHERE name='BIG TROPHY'";
            cmd.CommandText = "UPDATE trophy SET checked=checked+1  WHERE name='HUGE TROPHY'";
            cmd.ExecuteNonQuery();



        }

        private void Form1_Load(object sender, EventArgs e)
        {


            fill_listbox();



        }

        private void Label1_Click(object sender, EventArgs e)
        {


        }

        private void Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void Trophies_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Close();
        }

        private void taskBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }



        private void nameCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (nameCheckedListBox.CheckedItems.Count != 0)
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                // If so, loop through all checked items and print results.  
                string s = "";

                for (int x = 0; x < nameCheckedListBox.CheckedItems.Count; x++)
                {
                    s = s + "Checked Item " + (x + 1).ToString() + " = " + nameCheckedListBox.CheckedItems[x].ToString() + "\n";


                    cmd.CommandText = "UPDATE task SET checked='1' WHERE Name='" + nameCheckedListBox.CheckedItems[x].ToString() + "'";
                    cmd.CommandText = "DELETE FROM task WHERE Name = '" + nameCheckedListBox.CheckedItems[x].ToString() + "'";
                    count++;
                    if (count != a)
                    {
                       // change(cmd, conn);
                        a = count;
                    }

                    cmd.ExecuteNonQuery();

                }

                conn.Close();
                MessageBox.Show(s);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            SqlCommand com;
            if (conn.State != ConnectionState.Open)

                conn.Open();
            string str = "SELECT text from quotes";

            com = new SqlCommand(str, conn);
            SqlDataReader reader = com.ExecuteReader();

            reader.Read();
            label2.Text = reader["text"].ToString();

            reader.Close();
            conn.Close();
        }



    }
}