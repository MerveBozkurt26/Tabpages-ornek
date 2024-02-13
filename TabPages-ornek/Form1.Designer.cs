namespace TabPages_ornek
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblCorba = new System.Windows.Forms.Label();
            this.lblSalata = new System.Windows.Forms.Label();
            this.lblAnaYemek = new System.Windows.Forms.Label();
            this.lblTatli = new System.Windows.Forms.Label();
            this.numAnaYemek = new System.Windows.Forms.NumericUpDown();
            this.numTatli = new System.Windows.Forms.NumericUpDown();
            this.lblHesap = new System.Windows.Forms.Label();
            this.numCorba = new System.Windows.Forms.NumericUpDown();
            this.numSalata = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnaYemek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTatli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCorba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalata)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtAdres);
            this.tabPage1.Controls.Add(this.txtTelefon);
            this.tabPage1.Controls.Add(this.txtAdSoyad);
            this.tabPage1.Controls.Add(this.lblAdres);
            this.tabPage1.Controls.Add(this.lblTelefon);
            this.tabPage1.Controls.Add(this.lblAdSoyad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numSalata);
            this.tabPage2.Controls.Add(this.numCorba);
            this.tabPage2.Controls.Add(this.numTatli);
            this.tabPage2.Controls.Add(this.numAnaYemek);
            this.tabPage2.Controls.Add(this.lblTatli);
            this.tabPage2.Controls.Add(this.lblAnaYemek);
            this.tabPage2.Controls.Add(this.lblSalata);
            this.tabPage2.Controls.Add(this.lblCorba);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Siparis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblHesap);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hesap";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(23, 34);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(75, 16);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(23, 64);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(60, 16);
            this.lblTelefon.TabIndex = 1;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(23, 90);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(48, 16);
            this.lblAdres.TabIndex = 2;
            this.lblAdres.Text = "Adres";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(104, 33);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(104, 63);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(95, 89);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(156, 89);
            this.txtAdres.TabIndex = 5;
            // 
            // lblCorba
            // 
            this.lblCorba.AutoSize = true;
            this.lblCorba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCorba.Location = new System.Drawing.Point(24, 53);
            this.lblCorba.Name = "lblCorba";
            this.lblCorba.Size = new System.Drawing.Size(49, 16);
            this.lblCorba.TabIndex = 0;
            this.lblCorba.Text = "Çorba";
            // 
            // lblSalata
            // 
            this.lblSalata.AutoSize = true;
            this.lblSalata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalata.Location = new System.Drawing.Point(24, 83);
            this.lblSalata.Name = "lblSalata";
            this.lblSalata.Size = new System.Drawing.Size(52, 16);
            this.lblSalata.TabIndex = 1;
            this.lblSalata.Text = "Salata";
            // 
            // lblAnaYemek
            // 
            this.lblAnaYemek.AutoSize = true;
            this.lblAnaYemek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnaYemek.Location = new System.Drawing.Point(24, 114);
            this.lblAnaYemek.Name = "lblAnaYemek";
            this.lblAnaYemek.Size = new System.Drawing.Size(82, 16);
            this.lblAnaYemek.TabIndex = 2;
            this.lblAnaYemek.Text = "AnaYemek";
            // 
            // lblTatli
            // 
            this.lblTatli.AutoSize = true;
            this.lblTatli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTatli.Location = new System.Drawing.Point(24, 147);
            this.lblTatli.Name = "lblTatli";
            this.lblTatli.Size = new System.Drawing.Size(38, 16);
            this.lblTatli.TabIndex = 3;
            this.lblTatli.Text = "Tatlı";
            // 
            // numAnaYemek
            // 
            this.numAnaYemek.Location = new System.Drawing.Point(112, 114);
            this.numAnaYemek.Name = "numAnaYemek";
            this.numAnaYemek.Size = new System.Drawing.Size(120, 20);
            this.numAnaYemek.TabIndex = 6;
            // 
            // numTatli
            // 
            this.numTatli.Location = new System.Drawing.Point(112, 143);
            this.numTatli.Name = "numTatli";
            this.numTatli.Size = new System.Drawing.Size(120, 20);
            this.numTatli.TabIndex = 7;
            // 
            // lblHesap
            // 
            this.lblHesap.AutoSize = true;
            this.lblHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesap.Location = new System.Drawing.Point(40, 53);
            this.lblHesap.Name = "lblHesap";
            this.lblHesap.Size = new System.Drawing.Size(0, 16);
            this.lblHesap.TabIndex = 0;
            // 
            // numCorba
            // 
            this.numCorba.Location = new System.Drawing.Point(112, 49);
            this.numCorba.Name = "numCorba";
            this.numCorba.Size = new System.Drawing.Size(120, 20);
            this.numCorba.TabIndex = 8;
            // 
            // numSalata
            // 
            this.numSalata.Location = new System.Drawing.Point(112, 83);
            this.numSalata.Name = "numSalata";
            this.numSalata.Size = new System.Drawing.Size(120, 20);
            this.numSalata.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnaYemek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTatli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCorba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.NumericUpDown numTatli;
        private System.Windows.Forms.NumericUpDown numAnaYemek;
        private System.Windows.Forms.Label lblTatli;
        private System.Windows.Forms.Label lblAnaYemek;
        private System.Windows.Forms.Label lblSalata;
        private System.Windows.Forms.Label lblCorba;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblHesap;
        private System.Windows.Forms.NumericUpDown numSalata;
        private System.Windows.Forms.NumericUpDown numCorba;
    }
}

