namespace adoProject2
{
    partial class Form1
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
            System.Windows.Forms.Label champLabel;
            System.Windows.Forms.Label hPLabel;
            System.Windows.Forms.Label mNLabel;
            System.Windows.Forms.Label aDLabel;
            System.Windows.Forms.Label aRMLabel;
            System.Windows.Forms.Label mRLabel;
            this.loL_AppDataSet = new adoProject2.LoL_AppDataSet();
            this.loLAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.champBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.champBaseTableAdapter = new adoProject2.LoL_AppDataSetTableAdapters.ChampBaseTableAdapter();
            this.tableAdapterManager = new adoProject2.LoL_AppDataSetTableAdapters.TableAdapterManager();
            this.champComboBox = new System.Windows.Forms.ComboBox();
            this.champBaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hPLabel1 = new System.Windows.Forms.Label();
            this.mNLabel1 = new System.Windows.Forms.Label();
            this.aDLabel1 = new System.Windows.Forms.Label();
            this.aRMLabel1 = new System.Windows.Forms.Label();
            this.mRLabel1 = new System.Windows.Forms.Label();
            champLabel = new System.Windows.Forms.Label();
            hPLabel = new System.Windows.Forms.Label();
            mNLabel = new System.Windows.Forms.Label();
            aDLabel = new System.Windows.Forms.Label();
            aRMLabel = new System.Windows.Forms.Label();
            mRLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loL_AppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loLAppDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.champBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.champBaseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // loL_AppDataSet
            // 
            this.loL_AppDataSet.DataSetName = "LoL_AppDataSet";
            this.loL_AppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loLAppDataSetBindingSource
            // 
            this.loLAppDataSetBindingSource.DataSource = this.loL_AppDataSet;
            this.loLAppDataSetBindingSource.Position = 0;
            // 
            // champBaseBindingSource
            // 
            this.champBaseBindingSource.DataMember = "ChampBase";
            this.champBaseBindingSource.DataSource = this.loL_AppDataSet;
            // 
            // champBaseTableAdapter
            // 
            this.champBaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChampBaseTableAdapter = this.champBaseTableAdapter;
            this.tableAdapterManager.UpdateOrder = adoProject2.LoL_AppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // champLabel
            // 
            champLabel.AutoSize = true;
            champLabel.Location = new System.Drawing.Point(12, 35);
            champLabel.Name = "champLabel";
            champLabel.Size = new System.Drawing.Size(57, 13);
            champLabel.TabIndex = 0;
            champLabel.Text = "Champion:";
            // 
            // champComboBox
            // 
            this.champComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.champBaseBindingSource, "Champ", true));
            this.champComboBox.DataSource = this.champBaseBindingSource1;
            this.champComboBox.DisplayMember = "Champ";
            this.champComboBox.FormattingEnabled = true;
            this.champComboBox.Location = new System.Drawing.Point(72, 35);
            this.champComboBox.Name = "champComboBox";
            this.champComboBox.Size = new System.Drawing.Size(121, 21);
            this.champComboBox.TabIndex = 1;
            // 
            // champBaseBindingSource1
            // 
            this.champBaseBindingSource1.DataMember = "ChampBase";
            this.champBaseBindingSource1.DataSource = this.loL_AppDataSet;
            // 
            // hPLabel
            // 
            hPLabel.AutoSize = true;
            hPLabel.Location = new System.Drawing.Point(12, 73);
            hPLabel.Name = "hPLabel";
            hPLabel.Size = new System.Drawing.Size(41, 13);
            hPLabel.TabIndex = 2;
            hPLabel.Text = "Health:";
            // 
            // hPLabel1
            // 
            this.hPLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.champBaseBindingSource1, "HP", true));
            this.hPLabel1.Location = new System.Drawing.Point(93, 73);
            this.hPLabel1.Name = "hPLabel1";
            this.hPLabel1.Size = new System.Drawing.Size(100, 23);
            this.hPLabel1.TabIndex = 3;
            this.hPLabel1.Text = "label1";
            // 
            // mNLabel
            // 
            mNLabel.AutoSize = true;
            mNLabel.Location = new System.Drawing.Point(12, 111);
            mNLabel.Name = "mNLabel";
            mNLabel.Size = new System.Drawing.Size(37, 13);
            mNLabel.TabIndex = 4;
            mNLabel.Text = "Mana:";
            // 
            // mNLabel1
            // 
            this.mNLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.champBaseBindingSource1, "MN", true));
            this.mNLabel1.Location = new System.Drawing.Point(93, 111);
            this.mNLabel1.Name = "mNLabel1";
            this.mNLabel1.Size = new System.Drawing.Size(100, 23);
            this.mNLabel1.TabIndex = 5;
            this.mNLabel1.Text = "label1";
            // 
            // aDLabel
            // 
            aDLabel.AutoSize = true;
            aDLabel.Location = new System.Drawing.Point(12, 148);
            aDLabel.Name = "aDLabel";
            aDLabel.Size = new System.Drawing.Size(41, 13);
            aDLabel.TabIndex = 6;
            aDLabel.Text = "Attack:";
            // 
            // aDLabel1
            // 
            this.aDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.champBaseBindingSource1, "AD", true));
            this.aDLabel1.Location = new System.Drawing.Point(93, 148);
            this.aDLabel1.Name = "aDLabel1";
            this.aDLabel1.Size = new System.Drawing.Size(100, 23);
            this.aDLabel1.TabIndex = 7;
            this.aDLabel1.Text = "label1";
            // 
            // aRMLabel
            // 
            aRMLabel.AutoSize = true;
            aRMLabel.Location = new System.Drawing.Point(12, 189);
            aRMLabel.Name = "aRMLabel";
            aRMLabel.Size = new System.Drawing.Size(37, 13);
            aRMLabel.TabIndex = 8;
            aRMLabel.Text = "Armor:";
            // 
            // aRMLabel1
            // 
            this.aRMLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.champBaseBindingSource1, "ARM", true));
            this.aRMLabel1.Location = new System.Drawing.Point(93, 189);
            this.aRMLabel1.Name = "aRMLabel1";
            this.aRMLabel1.Size = new System.Drawing.Size(100, 23);
            this.aRMLabel1.TabIndex = 9;
            this.aRMLabel1.Text = "label1";
            // 
            // mRLabel
            // 
            mRLabel.AutoSize = true;
            mRLabel.Location = new System.Drawing.Point(12, 228);
            mRLabel.Name = "mRLabel";
            mRLabel.Size = new System.Drawing.Size(71, 13);
            mRLabel.TabIndex = 10;
            mRLabel.Text = "Magic Resist:";
            // 
            // mRLabel1
            // 
            this.mRLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.champBaseBindingSource1, "MR", true));
            this.mRLabel1.Location = new System.Drawing.Point(93, 228);
            this.mRLabel1.Name = "mRLabel1";
            this.mRLabel1.Size = new System.Drawing.Size(100, 23);
            this.mRLabel1.TabIndex = 11;
            this.mRLabel1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 277);
            this.Controls.Add(mRLabel);
            this.Controls.Add(this.mRLabel1);
            this.Controls.Add(aRMLabel);
            this.Controls.Add(this.aRMLabel1);
            this.Controls.Add(aDLabel);
            this.Controls.Add(this.aDLabel1);
            this.Controls.Add(mNLabel);
            this.Controls.Add(this.mNLabel1);
            this.Controls.Add(hPLabel);
            this.Controls.Add(this.hPLabel1);
            this.Controls.Add(champLabel);
            this.Controls.Add(this.champComboBox);
            this.Name = "Form1";
            this.Text = "Champion Stats";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loL_AppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loLAppDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.champBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.champBaseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource loLAppDataSetBindingSource;
        private LoL_AppDataSet loL_AppDataSet;
        private System.Windows.Forms.BindingSource champBaseBindingSource;
        private LoL_AppDataSetTableAdapters.ChampBaseTableAdapter champBaseTableAdapter;
        private LoL_AppDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox champComboBox;
        private System.Windows.Forms.BindingSource champBaseBindingSource1;
        private System.Windows.Forms.Label hPLabel1;
        private System.Windows.Forms.Label mNLabel1;
        private System.Windows.Forms.Label aDLabel1;
        private System.Windows.Forms.Label aRMLabel1;
        private System.Windows.Forms.Label mRLabel1;
    }
}

