namespace LAB3
{
    partial class Pracownicy
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
            btnDodaj = new Button();
            btnUsun = new Button();
            btnZapis = new Button();
            btnOdczyt = new Button();
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Imie = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(718, 23);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 0;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(718, 75);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(94, 29);
            btnUsun.TabIndex = 1;
            btnUsun.Text = "Usun";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnZapis
            // 
            btnZapis.Location = new Point(12, 332);
            btnZapis.Name = "btnZapis";
            btnZapis.Size = new Size(169, 29);
            btnZapis.TabIndex = 2;
            btnZapis.Text = "Zapis do .csv";
            btnZapis.UseVisualStyleBackColor = true;
            btnZapis.Click += btnZapis_Click;
            // 
            // btnOdczyt
            // 
            btnOdczyt.Location = new Point(521, 332);
            btnOdczyt.Name = "btnOdczyt";
            btnOdczyt.Size = new Size(169, 29);
            btnOdczyt.TabIndex = 3;
            btnOdczyt.Text = "Odczyt z .csv";
            btnOdczyt.UseVisualStyleBackColor = true;
            btnOdczyt.Click += btnOdczyt_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Imie, Column3, Column4, Column5 });
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(678, 286);
            dataGridView.TabIndex = 4;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Imie
            // 
            Imie.HeaderText = "Imię";
            Imie.MinimumWidth = 6;
            Imie.Name = "Imie";
            Imie.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nazwisko";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Wiek";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Stanowisko";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Pracownicy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 373);
            Controls.Add(dataGridView);
            Controls.Add(btnOdczyt);
            Controls.Add(btnZapis);
            Controls.Add(btnUsun);
            Controls.Add(btnDodaj);
            Name = "Pracownicy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pracownicy";
            Load += Pracownicy_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDodaj;
        private Button btnUsun;
        private Button btnZapis;
        private Button btnOdczyt;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Imie;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
