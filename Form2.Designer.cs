namespace LAB3
{
    partial class Pracownik
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
            textBoxImie = new TextBox();
            textBoxNazwisko = new TextBox();
            textBoxWiek = new TextBox();
            comboBoxStanowisko = new ComboBox();
            btnZatwierdz = new Button();
            btnAnuluj = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxImie
            // 
            textBoxImie.Location = new Point(47, 36);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(125, 27);
            textBoxImie.TabIndex = 0;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Location = new Point(47, 93);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(125, 27);
            textBoxNazwisko.TabIndex = 1;
            // 
            // textBoxWiek
            // 
            textBoxWiek.Location = new Point(47, 149);
            textBoxWiek.Name = "textBoxWiek";
            textBoxWiek.Size = new Size(125, 27);
            textBoxWiek.TabIndex = 2;
            // 
            // comboBoxStanowisko
            // 
            comboBoxStanowisko.FormattingEnabled = true;
            comboBoxStanowisko.Items.AddRange(new object[] { "Dyrektor", "Kierownik", "Stażysta" });
            comboBoxStanowisko.Location = new Point(36, 212);
            comboBoxStanowisko.Name = "comboBoxStanowisko";
            comboBoxStanowisko.Size = new Size(151, 28);
            comboBoxStanowisko.TabIndex = 3;
            // 
            // btnZatwierdz
            // 
            btnZatwierdz.Location = new Point(12, 284);
            btnZatwierdz.Name = "btnZatwierdz";
            btnZatwierdz.Size = new Size(94, 29);
            btnZatwierdz.TabIndex = 4;
            btnZatwierdz.Text = "Zatwierdź";
            btnZatwierdz.UseVisualStyleBackColor = true;
            btnZatwierdz.Click += btnZatwierdz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(206, 284);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(94, 29);
            btnAnuluj.TabIndex = 5;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 39);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 6;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 100);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 156);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 8;
            label3.Text = "Wiek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 215);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 9;
            label4.Text = "Stanowisko";
            // 
            // Pracownik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 340);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZatwierdz);
            Controls.Add(comboBoxStanowisko);
            Controls.Add(textBoxWiek);
            Controls.Add(textBoxNazwisko);
            Controls.Add(textBoxImie);
            Name = "Pracownik";
            Text = "Pracownik";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxImie;
        private TextBox textBoxNazwisko;
        private TextBox textBoxWiek;
        private ComboBox comboBoxStanowisko;
        private Button btnZatwierdz;
        private Button btnAnuluj;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}