using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToDoLIst
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.settings' table. You can move, or remove it, as needed.
            this.settingsTableAdapter.Fill(this.database1DataSet.settings);

        }

        private void Settings1_Click(object sender, EventArgs e)
        {

        }

        private void settings2_Click(object sender, EventArgs e)
        {

        }

        private void SettingsSave_Click(object sender, EventArgs e)
        {

        }

        private void SettingsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void settingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.settingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void nameCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
