namespace WindowsFormsApp1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPriezvisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonPridajStudenta = new System.Windows.Forms.Button();
            this.buttonVymazStudenta = new System.Windows.Forms.Button();
            this.labelVyberSiPredmet = new System.Windows.Forms.Label();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.textBoxPridajPredmet = new System.Windows.Forms.TextBox();
            this.labelPridajPredmet = new System.Windows.Forms.Label();
            this.buttonPridajPredmet = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonVymazPredmet = new System.Windows.Forms.Button();
            this.comboBoxVymazPredmet = new System.Windows.Forms.ComboBox();
            this.labelVymazPredmet = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelPredmet = new System.Windows.Forms.Label();
            this.Column2ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2Priezvisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2Meno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2Znamka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2Priemer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialogSubor = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnPriezvisko,
            this.ColumnMeno});
            this.dataGridView1.Location = new System.Drawing.Point(354, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(409, 390);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnPriezvisko
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            this.ColumnPriezvisko.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnPriezvisko.HeaderText = "Priezvisko";
            this.ColumnPriezvisko.MinimumWidth = 6;
            this.ColumnPriezvisko.Name = "ColumnPriezvisko";
            this.ColumnPriezvisko.Width = 125;
            // 
            // ColumnMeno
            // 
            this.ColumnMeno.HeaderText = "Meno";
            this.ColumnMeno.MinimumWidth = 6;
            this.ColumnMeno.Name = "ColumnMeno";
            this.ColumnMeno.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2ID,
            this.Column2Priezvisko,
            this.Column2Meno,
            this.Column2Znamka,
            this.Column2Priemer});
            this.dataGridView2.Location = new System.Drawing.Point(136, 5);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(627, 390);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // buttonPridajStudenta
            // 
            this.buttonPridajStudenta.Location = new System.Drawing.Point(245, 16);
            this.buttonPridajStudenta.Name = "buttonPridajStudenta";
            this.buttonPridajStudenta.Size = new System.Drawing.Size(104, 23);
            this.buttonPridajStudenta.TabIndex = 6;
            this.buttonPridajStudenta.Text = "Pridaj studenta";
            this.buttonPridajStudenta.UseVisualStyleBackColor = true;
            this.buttonPridajStudenta.Click += new System.EventHandler(this.buttonPridajStudenta_Click);
            // 
            // buttonVymazStudenta
            // 
            this.buttonVymazStudenta.Location = new System.Drawing.Point(245, 45);
            this.buttonVymazStudenta.Name = "buttonVymazStudenta";
            this.buttonVymazStudenta.Size = new System.Drawing.Size(104, 23);
            this.buttonVymazStudenta.TabIndex = 7;
            this.buttonVymazStudenta.Text = "Vymaz studenta";
            this.buttonVymazStudenta.UseVisualStyleBackColor = true;
            this.buttonVymazStudenta.Click += new System.EventHandler(this.buttonVymazStudenta_Click);
            // 
            // labelVyberSiPredmet
            // 
            this.labelVyberSiPredmet.AutoSize = true;
            this.labelVyberSiPredmet.Location = new System.Drawing.Point(7, 40);
            this.labelVyberSiPredmet.Name = "labelVyberSiPredmet";
            this.labelVyberSiPredmet.Size = new System.Drawing.Size(86, 13);
            this.labelVyberSiPredmet.TabIndex = 8;
            this.labelVyberSiPredmet.Text = "Vyber si Predmet";
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(10, 56);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubjects.TabIndex = 10;
            this.comboBoxSubjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubjects_SelectedIndexChanged);
            // 
            // textBoxPridajPredmet
            // 
            this.textBoxPridajPredmet.Location = new System.Drawing.Point(100, 217);
            this.textBoxPridajPredmet.Name = "textBoxPridajPredmet";
            this.textBoxPridajPredmet.Size = new System.Drawing.Size(100, 20);
            this.textBoxPridajPredmet.TabIndex = 11;
            // 
            // labelPridajPredmet
            // 
            this.labelPridajPredmet.AutoSize = true;
            this.labelPridajPredmet.Location = new System.Drawing.Point(20, 220);
            this.labelPridajPredmet.Name = "labelPridajPredmet";
            this.labelPridajPredmet.Size = new System.Drawing.Size(74, 13);
            this.labelPridajPredmet.TabIndex = 12;
            this.labelPridajPredmet.Text = "Pridaj predmet";
            // 
            // buttonPridajPredmet
            // 
            this.buttonPridajPredmet.Location = new System.Drawing.Point(206, 217);
            this.buttonPridajPredmet.Name = "buttonPridajPredmet";
            this.buttonPridajPredmet.Size = new System.Drawing.Size(104, 23);
            this.buttonPridajPredmet.TabIndex = 13;
            this.buttonPridajPredmet.Text = "Pridaj";
            this.buttonPridajPredmet.UseVisualStyleBackColor = true;
            this.buttonPridajPredmet.Click += new System.EventHandler(this.buttonPridajPredmet_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonImport);
            this.tabPage1.Controls.Add(this.buttonVymazPredmet);
            this.tabPage1.Controls.Add(this.comboBoxVymazPredmet);
            this.tabPage1.Controls.Add(this.labelVymazPredmet);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.buttonPridajPredmet);
            this.tabPage1.Controls.Add(this.buttonPridajStudenta);
            this.tabPage1.Controls.Add(this.labelPridajPredmet);
            this.tabPage1.Controls.Add(this.textBoxPridajPredmet);
            this.tabPage1.Controls.Add(this.buttonVymazStudenta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Importuj ziakov \r\npriamo z tabulky";
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(245, 114);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(104, 23);
            this.buttonImport.TabIndex = 17;
            this.buttonImport.Text = "Importuj";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonVymazPredmet
            // 
            this.buttonVymazPredmet.Location = new System.Drawing.Point(227, 248);
            this.buttonVymazPredmet.Name = "buttonVymazPredmet";
            this.buttonVymazPredmet.Size = new System.Drawing.Size(104, 23);
            this.buttonVymazPredmet.TabIndex = 16;
            this.buttonVymazPredmet.Text = "Vymaz";
            this.buttonVymazPredmet.UseVisualStyleBackColor = true;
            this.buttonVymazPredmet.Click += new System.EventHandler(this.buttonVymazPredmet_Click);
            // 
            // comboBoxVymazPredmet
            // 
            this.comboBoxVymazPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVymazPredmet.FormattingEnabled = true;
            this.comboBoxVymazPredmet.Location = new System.Drawing.Point(100, 248);
            this.comboBoxVymazPredmet.Name = "comboBoxVymazPredmet";
            this.comboBoxVymazPredmet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVymazPredmet.TabIndex = 15;
            // 
            // labelVymazPredmet
            // 
            this.labelVymazPredmet.AutoSize = true;
            this.labelVymazPredmet.Location = new System.Drawing.Point(20, 248);
            this.labelVymazPredmet.Name = "labelVymazPredmet";
            this.labelVymazPredmet.Size = new System.Drawing.Size(79, 13);
            this.labelVymazPredmet.TabIndex = 14;
            this.labelVymazPredmet.Text = "Vymaz predmet";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelPredmet);
            this.tabPage2.Controls.Add(this.labelVyberSiPredmet);
            this.tabPage2.Controls.Add(this.comboBoxSubjects);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelPredmet
            // 
            this.labelPredmet.AutoSize = true;
            this.labelPredmet.Location = new System.Drawing.Point(7, 5);
            this.labelPredmet.Name = "labelPredmet";
            this.labelPredmet.Size = new System.Drawing.Size(46, 13);
            this.labelPredmet.TabIndex = 11;
            this.labelPredmet.Text = "Predmet";
            // 
            // Column2ID
            // 
            this.Column2ID.HeaderText = "ID";
            this.Column2ID.Name = "Column2ID";
            this.Column2ID.ReadOnly = true;
            // 
            // Column2Priezvisko
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            this.Column2Priezvisko.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column2Priezvisko.HeaderText = "Priezvisko";
            this.Column2Priezvisko.MinimumWidth = 6;
            this.Column2Priezvisko.Name = "Column2Priezvisko";
            this.Column2Priezvisko.ReadOnly = true;
            this.Column2Priezvisko.Width = 125;
            // 
            // Column2Meno
            // 
            this.Column2Meno.HeaderText = "Meno";
            this.Column2Meno.MinimumWidth = 6;
            this.Column2Meno.Name = "Column2Meno";
            this.Column2Meno.ReadOnly = true;
            this.Column2Meno.Width = 125;
            // 
            // Column2Znamka
            // 
            this.Column2Znamka.HeaderText = "Znamky";
            this.Column2Znamka.MinimumWidth = 6;
            this.Column2Znamka.Name = "Column2Znamka";
            this.Column2Znamka.Width = 125;
            // 
            // Column2Priemer
            // 
            this.Column2Priemer.HeaderText = "Priemer";
            this.Column2Priemer.Name = "Column2Priemer";
            this.Column2Priemer.ReadOnly = true;
            // 
            // openFileDialogSubor
            // 
            this.openFileDialogSubor.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Student Grading";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonPridajStudenta;
        private System.Windows.Forms.Button buttonVymazStudenta;
        private System.Windows.Forms.Label labelVyberSiPredmet;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.TextBox textBoxPridajPredmet;
        private System.Windows.Forms.Label labelPridajPredmet;
        private System.Windows.Forms.Button buttonPridajPredmet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelPredmet;
        private System.Windows.Forms.Label labelVymazPredmet;
        private System.Windows.Forms.ComboBox comboBoxVymazPredmet;
        private System.Windows.Forms.Button buttonVymazPredmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPriezvisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMeno;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Priezvisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Meno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Znamka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Priemer;
        private System.Windows.Forms.OpenFileDialog openFileDialogSubor;
    }
}

