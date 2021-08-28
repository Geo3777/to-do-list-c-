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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Otgon\Desktop\TAP\proiect tappp11\TODOLIST\TODOLIST\Database1.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
            
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            var startDate = monthCalendar1.SelectionRange.Start.Date;
            nameCheckedListBox.Items.Clear();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Name FROM task WHERE Date= '" + startDate + "'";
           
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                nameCheckedListBox.Items.Add(dr["Name"].ToString());

            }
        }

      


        private void CaclBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameCheckedListBox.CheckedItems.Count != 0)
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                // If so, loop through all checked items and print results.  
                string s1 = "";

                for (int x = 0; x < nameCheckedListBox.CheckedItems.Count; x++)
                {
                    s1 = s1 + "Checked Item " + (x + 1).ToString() + " = " + nameCheckedListBox.CheckedItems[x].ToString() + "\n";


                    cmd.CommandText = "UPDATE task SET checked='1' WHERE Name='" + nameCheckedListBox.CheckedItems[x].ToString() + "'";
                    cmd.CommandText = "DELETE FROM task WHERE Name = '" + nameCheckedListBox.CheckedItems[x].ToString() + "'";
                    cmd.ExecuteNonQuery();
 
                }

                MessageBox.Show(s1);
                conn.Close();
               
            }

        }
    

        private void taskBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.taskTableAdapter.Fill(this.database1DataSet.task);
           
        }
    }
}
