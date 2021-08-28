
namespace ToDoLIst
{
    partial class Form5
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
            this.LabelTro = new System.Windows.Forms.Label();
            this.TrophiesBack = new System.Windows.Forms.Button();
            this.database1DataSet = new TODOLIST.Database1DataSet();
            this.trophyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trophyTableAdapter = new TODOLIST.Database1DataSetTableAdapters.trophyTableAdapter();
            this.tableAdapterManager = new TODOLIST.Database1DataSetTableAdapters.TableAdapterManager();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trophyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTro
            // 
            this.LabelTro.AutoSize = true;
            this.LabelTro.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LabelTro.Location = new System.Drawing.Point(137, 32);
            this.LabelTro.Name = "LabelTro";
            this.LabelTro.Size = new System.Drawing.Size(90, 30);
            this.LabelTro.TabIndex = 2;
            this.LabelTro.Text = "Trophies";
            this.LabelTro.Click += new System.EventHandler(this.LabelTro_Click);
            // 
            // TrophiesBack
            // 
            this.TrophiesBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TrophiesBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrophiesBack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TrophiesBack.Location = new System.Drawing.Point(12, 496);
            this.TrophiesBack.Name = "TrophiesBack";
            this.TrophiesBack.Size = new System.Drawing.Size(76, 42);
            this.TrophiesBack.TabIndex = 12;
            this.TrophiesBack.Text = "Back";
            this.TrophiesBack.UseVisualStyleBackColor = false;
            this.TrophiesBack.Click += new System.EventHandler(this.TrophiesBack_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trophyBindingSource
            // 
            this.trophyBindingSource.DataMember = "trophy";
            this.trophyBindingSource.DataSource = this.database1DataSet;
            // 
            // trophyTableAdapter
            // 
            this.trophyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.firstTableAdapter = null;
            this.tableAdapterManager.quotesTableAdapter = null;
            this.tableAdapterManager.settingsTableAdapter = null;
            this.tableAdapterManager.taskTableAdapter = null;
            this.tableAdapterManager.trophyTableAdapter = this.trophyTableAdapter;
            this.tableAdapterManager.UpdateOrder = TODOLIST.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 80);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(295, 357);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 558);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TrophiesBack);
            this.Controls.Add(this.LabelTro);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trophyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTro;
        private System.Windows.Forms.Button TrophiesBack;
        private TODOLIST.Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource trophyBindingSource;
        private TODOLIST.Database1DataSetTableAdapters.trophyTableAdapter trophyTableAdapter;
        private TODOLIST.Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListView listView1;
    }
}