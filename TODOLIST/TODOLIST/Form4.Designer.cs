
namespace ToDoLIst
{
    partial class Form4
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
            this.SettingsLab = new System.Windows.Forms.Label();
            this.SettingsBack = new System.Windows.Forms.Button();
            this.SettingsSave = new System.Windows.Forms.Button();
            this.database1DataSet = new TODOLIST.Database1DataSet();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingsTableAdapter = new TODOLIST.Database1DataSetTableAdapters.settingsTableAdapter();
            this.tableAdapterManager = new TODOLIST.Database1DataSetTableAdapters.TableAdapterManager();
            this.nameCheckedListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsLab
            // 
            this.SettingsLab.AutoSize = true;
            this.SettingsLab.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.SettingsLab.Location = new System.Drawing.Point(136, 22);
            this.SettingsLab.Name = "SettingsLab";
            this.SettingsLab.Size = new System.Drawing.Size(87, 30);
            this.SettingsLab.TabIndex = 3;
            this.SettingsLab.Text = "Settings";
            // 
            // SettingsBack
            // 
            this.SettingsBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SettingsBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SettingsBack.Location = new System.Drawing.Point(12, 495);
            this.SettingsBack.Name = "SettingsBack";
            this.SettingsBack.Size = new System.Drawing.Size(90, 43);
            this.SettingsBack.TabIndex = 11;
            this.SettingsBack.Text = "Back";
            this.SettingsBack.UseVisualStyleBackColor = false;
            this.SettingsBack.Click += new System.EventHandler(this.SettingsBack_Click);
            // 
            // SettingsSave
            // 
            this.SettingsSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SettingsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SettingsSave.Location = new System.Drawing.Point(234, 495);
            this.SettingsSave.Name = "SettingsSave";
            this.SettingsSave.Size = new System.Drawing.Size(113, 43);
            this.SettingsSave.TabIndex = 12;
            this.SettingsSave.Text = "Save Settings";
            this.SettingsSave.UseVisualStyleBackColor = false;
            this.SettingsSave.Click += new System.EventHandler(this.SettingsSave_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataMember = "settings";
            this.settingsBindingSource.DataSource = this.database1DataSet;
            // 
            // settingsTableAdapter
            // 
            this.settingsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.firstTableAdapter = null;
            this.tableAdapterManager.quotesTableAdapter = null;
            this.tableAdapterManager.settingsTableAdapter = this.settingsTableAdapter;
            this.tableAdapterManager.taskTableAdapter = null;
            this.tableAdapterManager.trophyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TODOLIST.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameCheckedListBox
            // 
            this.nameCheckedListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nameCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.settingsBindingSource, "name", true));
            this.nameCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCheckedListBox.FormattingEnabled = true;
            this.nameCheckedListBox.Location = new System.Drawing.Point(23, 55);
            this.nameCheckedListBox.Name = "nameCheckedListBox";
            this.nameCheckedListBox.Size = new System.Drawing.Size(313, 361);
            this.nameCheckedListBox.TabIndex = 14;
            this.nameCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.nameCheckedListBox_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(367, 558);
            this.Controls.Add(this.nameCheckedListBox);
            this.Controls.Add(this.SettingsSave);
            this.Controls.Add(this.SettingsBack);
            this.Controls.Add(this.SettingsLab);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingsLab;
        private System.Windows.Forms.Button SettingsBack;
        private System.Windows.Forms.Button SettingsSave;
        private TODOLIST.Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private TODOLIST.Database1DataSetTableAdapters.settingsTableAdapter settingsTableAdapter;
        private TODOLIST.Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckedListBox nameCheckedListBox;
    }
}