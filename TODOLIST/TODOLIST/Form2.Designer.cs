
namespace ToDoLIst
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.LabelCal = new System.Windows.Forms.Label();
            this.CaclBack = new System.Windows.Forms.Button();
            this.database1DataSet = new TODOLIST.Database1DataSet();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTableAdapter = new TODOLIST.Database1DataSetTableAdapters.taskTableAdapter();
            this.tableAdapterManager = new TODOLIST.Database1DataSetTableAdapters.TableAdapterManager();
            this.nameCheckedListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthCalendar1.Location = new System.Drawing.Point(69, 50);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // LabelCal
            // 
            this.LabelCal.AutoSize = true;
            this.LabelCal.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LabelCal.Location = new System.Drawing.Point(131, 21);
            this.LabelCal.Name = "LabelCal";
            this.LabelCal.Size = new System.Drawing.Size(95, 30);
            this.LabelCal.TabIndex = 1;
            this.LabelCal.Text = "Calendar";
            // 
            // CaclBack
            // 
            this.CaclBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CaclBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaclBack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CaclBack.Location = new System.Drawing.Point(12, 497);
            this.CaclBack.Name = "CaclBack";
            this.CaclBack.Size = new System.Drawing.Size(103, 41);
            this.CaclBack.TabIndex = 4;
            this.CaclBack.Text = "Back";
            this.CaclBack.UseVisualStyleBackColor = false;
            this.CaclBack.Click += new System.EventHandler(this.CaclBack_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "task";
            this.taskBindingSource.DataSource = this.database1DataSet;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.firstTableAdapter = null;
            this.tableAdapterManager.quotesTableAdapter = null;
            this.tableAdapterManager.settingsTableAdapter = null;
            this.tableAdapterManager.taskTableAdapter = this.taskTableAdapter;
            this.tableAdapterManager.trophyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TODOLIST.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameCheckedListBox
            // 
            this.nameCheckedListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nameCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.taskBindingSource, "Name", true));
            this.nameCheckedListBox.FormattingEnabled = true;
            this.nameCheckedListBox.Location = new System.Drawing.Point(69, 235);
            this.nameCheckedListBox.Name = "nameCheckedListBox";
            this.nameCheckedListBox.Size = new System.Drawing.Size(227, 199);
            this.nameCheckedListBox.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 558);
            this.Controls.Add(this.nameCheckedListBox);
            this.Controls.Add(this.CaclBack);
            this.Controls.Add(this.LabelCal);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label LabelCal;
        private System.Windows.Forms.Button CaclBack;
        private TODOLIST.Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private TODOLIST.Database1DataSetTableAdapters.taskTableAdapter taskTableAdapter;
        private TODOLIST.Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckedListBox nameCheckedListBox;
    }
}