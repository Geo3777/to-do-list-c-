
namespace ToDoLIst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label1 = new System.Windows.Forms.Label();
            this.Plus = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.Button();
            this.Trophies = new System.Windows.Forms.Button();
            this.nameCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new TODOLIST.Database1DataSet();
            this.taskTableAdapter = new TODOLIST.Database1DataSetTableAdapters.taskTableAdapter();
            this.tableAdapterManager = new TODOLIST.Database1DataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label1.Location = new System.Drawing.Point(195, 75);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 28);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Motivatie";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Plus
            // 
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Plus.Location = new System.Drawing.Point(213, 590);
            this.Plus.Margin = new System.Windows.Forms.Padding(4);
            this.Plus.MinimumSize = new System.Drawing.Size(23, 21);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(67, 73);
            this.Plus.TabIndex = 2;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calendar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Calendar.Location = new System.Drawing.Point(16, 622);
            this.Calendar.Margin = new System.Windows.Forms.Padding(4);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(133, 41);
            this.Calendar.TabIndex = 3;
            this.Calendar.Text = "Calendar";
            this.Calendar.UseVisualStyleBackColor = false;
            this.Calendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // Trophies
            // 
            this.Trophies.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Trophies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trophies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Trophies.Location = new System.Drawing.Point(348, 622);
            this.Trophies.Margin = new System.Windows.Forms.Padding(4);
            this.Trophies.Name = "Trophies";
            this.Trophies.Size = new System.Drawing.Size(115, 41);
            this.Trophies.TabIndex = 6;
            this.Trophies.Text = "Trophies";
            this.Trophies.UseVisualStyleBackColor = false;
            this.Trophies.Click += new System.EventHandler(this.Trophies_Click);
            // 
            // nameCheckedListBox
            // 
            this.nameCheckedListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nameCheckedListBox.CheckOnClick = true;
            this.nameCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.taskBindingSource, "Name", true));
            this.nameCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCheckedListBox.FormattingEnabled = true;
            this.nameCheckedListBox.Location = new System.Drawing.Point(75, 121);
            this.nameCheckedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameCheckedListBox.Name = "nameCheckedListBox";
            this.nameCheckedListBox.Size = new System.Drawing.Size(345, 429);
            this.nameCheckedListBox.TabIndex = 8;
            this.nameCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.nameCheckedListBox_SelectedIndexChanged);
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "task";
            this.taskBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "QUOTES OF THE DAY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 687);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameCheckedListBox);
            this.Controls.Add(this.Trophies);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Calendar;
        private System.Windows.Forms.Button Trophies;
        private TODOLIST.Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private TODOLIST.Database1DataSetTableAdapters.taskTableAdapter taskTableAdapter;
        private TODOLIST.Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckedListBox nameCheckedListBox;
        private System.Windows.Forms.Label label2;
    }
}

