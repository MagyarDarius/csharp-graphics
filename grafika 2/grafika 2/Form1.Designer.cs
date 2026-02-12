namespace grafika_2
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
            this.labelEredmeny = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.RadioSokCukor = new System.Windows.Forms.RadioButton();
            this.RadioKevesCukor = new System.Windows.Forms.RadioButton();
            this.RadioCukorNelkul = new System.Windows.Forms.RadioButton();
            this.Cukor = new System.Windows.Forms.GroupBox();
            this.hozzavalok = new System.Windows.Forms.GroupBox();
            this.Citrom = new System.Windows.Forms.CheckBox();
            this.Tejpor = new System.Windows.Forms.CheckBox();
            this.Tejszin = new System.Windows.Forms.CheckBox();
            this.kavekrem = new System.Windows.Forms.CheckBox();
            this.Radioespresso = new System.Windows.Forms.RadioButton();
            this.Radioduplakave = new System.Windows.Forms.RadioButton();
            this.Radiohosszukave = new System.Windows.Forms.RadioButton();
            this.Radiotea = new System.Windows.Forms.RadioButton();
            this.forroitalok = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Osszesen_ar = new System.Windows.Forms.TextBox();
            this.Cukor_ar = new System.Windows.Forms.TextBox();
            this.Hozzávalo_ar = new System.Windows.Forms.TextBox();
            this.Ital_ar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kartya_fizetes = new System.Windows.Forms.Button();
            this.penz_fizetes = new System.Windows.Forms.Button();
            this.label_tajekoztatas = new System.Windows.Forms.Label();
            this.kp_mennyiseg = new System.Windows.Forms.TextBox();
            this.buttonPenzBedobas = new System.Windows.Forms.Button();
            this.Keszpenz_fizetes = new System.Windows.Forms.GroupBox();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.Cukor.SuspendLayout();
            this.hozzavalok.SuspendLayout();
            this.forroitalok.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Keszpenz_fizetes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEredmeny
            // 
            this.labelEredmeny.AutoSize = true;
            this.labelEredmeny.Location = new System.Drawing.Point(8, 64);
            this.labelEredmeny.Name = "labelEredmeny";
            this.labelEredmeny.Size = new System.Drawing.Size(84, 13);
            this.labelEredmeny.TabIndex = 0;
            this.labelEredmeny.Text = "Nincs Eredmény";
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(31, 238);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 1;
            this.buttonResult.Text = "Fizetés";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // RadioSokCukor
            // 
            this.RadioSokCukor.AutoSize = true;
            this.RadioSokCukor.Location = new System.Drawing.Point(10, 16);
            this.RadioSokCukor.Name = "RadioSokCukor";
            this.RadioSokCukor.Size = new System.Drawing.Size(74, 17);
            this.RadioSokCukor.TabIndex = 2;
            this.RadioSokCukor.Text = "Sok cukor";
            this.RadioSokCukor.UseVisualStyleBackColor = true;
            this.RadioSokCukor.CheckedChanged += new System.EventHandler(this.RadioSokCukor_CheckedChanged);
            // 
            // RadioKevesCukor
            // 
            this.RadioKevesCukor.AutoSize = true;
            this.RadioKevesCukor.Location = new System.Drawing.Point(10, 53);
            this.RadioKevesCukor.Name = "RadioKevesCukor";
            this.RadioKevesCukor.Size = new System.Drawing.Size(86, 17);
            this.RadioKevesCukor.TabIndex = 3;
            this.RadioKevesCukor.Text = "Kevés Cukor";
            this.RadioKevesCukor.UseVisualStyleBackColor = true;
            this.RadioKevesCukor.CheckedChanged += new System.EventHandler(this.RadioKevesCukor_CheckedChanged);
            // 
            // RadioCukorNelkul
            // 
            this.RadioCukorNelkul.AutoSize = true;
            this.RadioCukorNelkul.Checked = true;
            this.RadioCukorNelkul.Location = new System.Drawing.Point(10, 92);
            this.RadioCukorNelkul.Name = "RadioCukorNelkul";
            this.RadioCukorNelkul.Size = new System.Drawing.Size(86, 17);
            this.RadioCukorNelkul.TabIndex = 4;
            this.RadioCukorNelkul.TabStop = true;
            this.RadioCukorNelkul.Text = "Cukor Nélkül";
            this.RadioCukorNelkul.UseVisualStyleBackColor = true;
            // 
            // Cukor
            // 
            this.Cukor.Controls.Add(this.RadioCukorNelkul);
            this.Cukor.Controls.Add(this.RadioKevesCukor);
            this.Cukor.Controls.Add(this.RadioSokCukor);
            this.Cukor.Location = new System.Drawing.Point(176, 19);
            this.Cukor.Name = "Cukor";
            this.Cukor.Size = new System.Drawing.Size(108, 151);
            this.Cukor.TabIndex = 5;
            this.Cukor.TabStop = false;
            this.Cukor.Text = "Cukor";
            this.Cukor.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // hozzavalok
            // 
            this.hozzavalok.Controls.Add(this.Citrom);
            this.hozzavalok.Controls.Add(this.Tejpor);
            this.hozzavalok.Controls.Add(this.Tejszin);
            this.hozzavalok.Controls.Add(this.kavekrem);
            this.hozzavalok.Location = new System.Drawing.Point(31, 19);
            this.hozzavalok.Name = "hozzavalok";
            this.hozzavalok.Size = new System.Drawing.Size(129, 133);
            this.hozzavalok.TabIndex = 9;
            this.hozzavalok.TabStop = false;
            this.hozzavalok.Text = "Hozzávalók";
            this.hozzavalok.Enter += new System.EventHandler(this.ForroItalok_Enter);
            // 
            // Citrom
            // 
            this.Citrom.AutoSize = true;
            this.Citrom.Enabled = false;
            this.Citrom.Location = new System.Drawing.Point(7, 85);
            this.Citrom.Name = "Citrom";
            this.Citrom.Size = new System.Drawing.Size(55, 17);
            this.Citrom.TabIndex = 3;
            this.Citrom.Text = "Citrom";
            this.Citrom.UseVisualStyleBackColor = true;
            this.Citrom.CheckedChanged += new System.EventHandler(this.Citrom_CheckedChanged);
            // 
            // Tejpor
            // 
            this.Tejpor.AutoSize = true;
            this.Tejpor.Location = new System.Drawing.Point(7, 62);
            this.Tejpor.Name = "Tejpor";
            this.Tejpor.Size = new System.Drawing.Size(56, 17);
            this.Tejpor.TabIndex = 2;
            this.Tejpor.Text = "Tejpor";
            this.Tejpor.UseVisualStyleBackColor = true;
            this.Tejpor.CheckedChanged += new System.EventHandler(this.Tejpor_CheckedChanged);
            // 
            // Tejszin
            // 
            this.Tejszin.AutoSize = true;
            this.Tejszin.Location = new System.Drawing.Point(7, 39);
            this.Tejszin.Name = "Tejszin";
            this.Tejszin.Size = new System.Drawing.Size(61, 17);
            this.Tejszin.TabIndex = 1;
            this.Tejszin.Text = "Tejszín";
            this.Tejszin.UseVisualStyleBackColor = true;
            this.Tejszin.CheckedChanged += new System.EventHandler(this.Tejszin_CheckedChanged);
            // 
            // kavekrem
            // 
            this.kavekrem.AutoSize = true;
            this.kavekrem.Location = new System.Drawing.Point(7, 20);
            this.kavekrem.Name = "kavekrem";
            this.kavekrem.Size = new System.Drawing.Size(74, 17);
            this.kavekrem.TabIndex = 0;
            this.kavekrem.Text = "Kávékrém";
            this.kavekrem.UseVisualStyleBackColor = true;
            this.kavekrem.CheckedChanged += new System.EventHandler(this.kavekrem_CheckedChanged);
            // 
            // Radioespresso
            // 
            this.Radioespresso.AutoSize = true;
            this.Radioespresso.Checked = true;
            this.Radioespresso.Location = new System.Drawing.Point(17, 26);
            this.Radioespresso.Name = "Radioespresso";
            this.Radioespresso.Size = new System.Drawing.Size(68, 17);
            this.Radioespresso.TabIndex = 10;
            this.Radioespresso.TabStop = true;
            this.Radioespresso.Text = "Espresso";
            this.Radioespresso.UseVisualStyleBackColor = true;
            this.Radioespresso.CheckedChanged += new System.EventHandler(this.Radioespresso_CheckedChanged);
            // 
            // Radioduplakave
            // 
            this.Radioduplakave.AutoSize = true;
            this.Radioduplakave.Location = new System.Drawing.Point(17, 49);
            this.Radioduplakave.Name = "Radioduplakave";
            this.Radioduplakave.Size = new System.Drawing.Size(80, 17);
            this.Radioduplakave.TabIndex = 11;
            this.Radioduplakave.TabStop = true;
            this.Radioduplakave.Text = "Dupla kávé";
            this.Radioduplakave.UseVisualStyleBackColor = true;
            this.Radioduplakave.CheckedChanged += new System.EventHandler(this.Radioduplakave_CheckedChanged);
            // 
            // Radiohosszukave
            // 
            this.Radiohosszukave.AutoSize = true;
            this.Radiohosszukave.Location = new System.Drawing.Point(17, 72);
            this.Radiohosszukave.Name = "Radiohosszukave";
            this.Radiohosszukave.Size = new System.Drawing.Size(87, 17);
            this.Radiohosszukave.TabIndex = 12;
            this.Radiohosszukave.TabStop = true;
            this.Radiohosszukave.Text = "Hosszú kávé";
            this.Radiohosszukave.UseVisualStyleBackColor = true;
            this.Radiohosszukave.CheckedChanged += new System.EventHandler(this.Radiohosszukave_CheckedChanged);
            // 
            // Radiotea
            // 
            this.Radiotea.AutoSize = true;
            this.Radiotea.Location = new System.Drawing.Point(17, 95);
            this.Radiotea.Name = "Radiotea";
            this.Radiotea.Size = new System.Drawing.Size(44, 17);
            this.Radiotea.TabIndex = 13;
            this.Radiotea.TabStop = true;
            this.Radiotea.Text = "Tea";
            this.Radiotea.UseVisualStyleBackColor = true;
            this.Radiotea.CheckedChanged += new System.EventHandler(this.Radiotea_CheckedChanged);
            // 
            // forroitalok
            // 
            this.forroitalok.Controls.Add(this.Radiotea);
            this.forroitalok.Controls.Add(this.Radiohosszukave);
            this.forroitalok.Controls.Add(this.Radioduplakave);
            this.forroitalok.Controls.Add(this.Radioespresso);
            this.forroitalok.Location = new System.Drawing.Point(327, 19);
            this.forroitalok.Name = "forroitalok";
            this.forroitalok.Size = new System.Drawing.Size(113, 129);
            this.forroitalok.TabIndex = 14;
            this.forroitalok.TabStop = false;
            this.forroitalok.Text = "Forró Italok";
            this.forroitalok.Enter += new System.EventHandler(this.forroitalok_Enter_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Osszesen_ar);
            this.groupBox1.Controls.Add(this.Cukor_ar);
            this.groupBox1.Controls.Add(this.Hozzávalo_ar);
            this.groupBox1.Controls.Add(this.Ital_ar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(432, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 151);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fizetés";
            // 
            // Osszesen_ar
            // 
            this.Osszesen_ar.Location = new System.Drawing.Point(79, 117);
            this.Osszesen_ar.Name = "Osszesen_ar";
            this.Osszesen_ar.ReadOnly = true;
            this.Osszesen_ar.Size = new System.Drawing.Size(100, 20);
            this.Osszesen_ar.TabIndex = 7;
            // 
            // Cukor_ar
            // 
            this.Cukor_ar.Location = new System.Drawing.Point(80, 91);
            this.Cukor_ar.Name = "Cukor_ar";
            this.Cukor_ar.ReadOnly = true;
            this.Cukor_ar.Size = new System.Drawing.Size(100, 20);
            this.Cukor_ar.TabIndex = 6;
            // 
            // Hozzávalo_ar
            // 
            this.Hozzávalo_ar.Location = new System.Drawing.Point(80, 61);
            this.Hozzávalo_ar.Name = "Hozzávalo_ar";
            this.Hozzávalo_ar.ReadOnly = true;
            this.Hozzávalo_ar.Size = new System.Drawing.Size(100, 20);
            this.Hozzávalo_ar.TabIndex = 5;
            // 
            // Ital_ar
            // 
            this.Ital_ar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Ital_ar.Location = new System.Drawing.Point(80, 30);
            this.Ital_ar.Name = "Ital_ar";
            this.Ital_ar.ReadOnly = true;
            this.Ital_ar.Size = new System.Drawing.Size(100, 20);
            this.Ital_ar.TabIndex = 4;
            this.Ital_ar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Összesen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cukor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hozzávaló:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ital:";
            // 
            // kartya_fizetes
            // 
            this.kartya_fizetes.Location = new System.Drawing.Point(31, 299);
            this.kartya_fizetes.Name = "kartya_fizetes";
            this.kartya_fizetes.Size = new System.Drawing.Size(103, 23);
            this.kartya_fizetes.TabIndex = 16;
            this.kartya_fizetes.Text = "Bankkártya";
            this.kartya_fizetes.UseVisualStyleBackColor = true;
            this.kartya_fizetes.Visible = false;
            this.kartya_fizetes.Click += new System.EventHandler(this.kartya_fizetes_Click);
            // 
            // penz_fizetes
            // 
            this.penz_fizetes.Location = new System.Drawing.Point(31, 345);
            this.penz_fizetes.Name = "penz_fizetes";
            this.penz_fizetes.Size = new System.Drawing.Size(103, 24);
            this.penz_fizetes.TabIndex = 17;
            this.penz_fizetes.Text = "Készpénz";
            this.penz_fizetes.UseVisualStyleBackColor = true;
            this.penz_fizetes.Visible = false;
            this.penz_fizetes.Click += new System.EventHandler(this.penz_fizetes_Click);
            // 
            // label_tajekoztatas
            // 
            this.label_tajekoztatas.AutoSize = true;
            this.label_tajekoztatas.Location = new System.Drawing.Point(3, 17);
            this.label_tajekoztatas.Name = "label_tajekoztatas";
            this.label_tajekoztatas.Size = new System.Drawing.Size(171, 13);
            this.label_tajekoztatas.TabIndex = 19;
            this.label_tajekoztatas.Text = "Mennyi készpénzt dobsz a gépbe?";
            this.label_tajekoztatas.Click += new System.EventHandler(this.label5_Click);
            // 
            // kp_mennyiseg
            // 
            this.kp_mennyiseg.Location = new System.Drawing.Point(6, 33);
            this.kp_mennyiseg.Name = "kp_mennyiseg";
            this.kp_mennyiseg.Size = new System.Drawing.Size(168, 20);
            this.kp_mennyiseg.TabIndex = 20;
            // 
            // buttonPenzBedobas
            // 
            this.buttonPenzBedobas.Location = new System.Drawing.Point(99, 59);
            this.buttonPenzBedobas.Name = "buttonPenzBedobas";
            this.buttonPenzBedobas.Size = new System.Drawing.Size(75, 23);
            this.buttonPenzBedobas.TabIndex = 21;
            this.buttonPenzBedobas.Text = "BEDOB";
            this.buttonPenzBedobas.UseVisualStyleBackColor = true;
            this.buttonPenzBedobas.Click += new System.EventHandler(this.buttonPenzBedobas_Click);
            // 
            // Keszpenz_fizetes
            // 
            this.Keszpenz_fizetes.Controls.Add(this.buttonPenzBedobas);
            this.Keszpenz_fizetes.Controls.Add(this.kp_mennyiseg);
            this.Keszpenz_fizetes.Controls.Add(this.label_tajekoztatas);
            this.Keszpenz_fizetes.Controls.Add(this.labelEredmeny);
            this.Keszpenz_fizetes.Location = new System.Drawing.Point(140, 345);
            this.Keszpenz_fizetes.Name = "Keszpenz_fizetes";
            this.Keszpenz_fizetes.Size = new System.Drawing.Size(204, 92);
            this.Keszpenz_fizetes.TabIndex = 22;
            this.Keszpenz_fizetes.TabStop = false;
            this.Keszpenz_fizetes.Text = "Készpénz Fizetés";
            this.Keszpenz_fizetes.Visible = false;
            // 
            // ButtonReset
            // 
            this.ButtonReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonReset.Location = new System.Drawing.Point(38, 374);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonReset.TabIndex = 23;
            this.ButtonReset.Text = "RESET";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.Keszpenz_fizetes);
            this.Controls.Add(this.penz_fizetes);
            this.Controls.Add(this.kartya_fizetes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.forroitalok);
            this.Controls.Add(this.Cukor);
            this.Controls.Add(this.hozzavalok);
            this.Controls.Add(this.buttonResult);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ital Automata";
            this.Cukor.ResumeLayout(false);
            this.Cukor.PerformLayout();
            this.hozzavalok.ResumeLayout(false);
            this.hozzavalok.PerformLayout();
            this.forroitalok.ResumeLayout(false);
            this.forroitalok.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Keszpenz_fizetes.ResumeLayout(false);
            this.Keszpenz_fizetes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelEredmeny;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.RadioButton RadioSokCukor;
        private System.Windows.Forms.RadioButton RadioKevesCukor;
        private System.Windows.Forms.RadioButton RadioCukorNelkul;
        private System.Windows.Forms.GroupBox Cukor;
        private System.Windows.Forms.GroupBox hozzavalok;
        private System.Windows.Forms.RadioButton Radioespresso;
        private System.Windows.Forms.RadioButton Radioduplakave;
        private System.Windows.Forms.RadioButton Radiohosszukave;
        private System.Windows.Forms.RadioButton Radiotea;
        private System.Windows.Forms.GroupBox forroitalok;
        private System.Windows.Forms.CheckBox Citrom;
        private System.Windows.Forms.CheckBox Tejpor;
        private System.Windows.Forms.CheckBox Tejszin;
        private System.Windows.Forms.CheckBox kavekrem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cukor_ar;
        private System.Windows.Forms.TextBox Hozzávalo_ar;
        private System.Windows.Forms.TextBox Ital_ar;
        private System.Windows.Forms.TextBox Osszesen_ar;
        private System.Windows.Forms.Button kartya_fizetes;
        private System.Windows.Forms.Button penz_fizetes;
        private System.Windows.Forms.Label label_tajekoztatas;
        private System.Windows.Forms.TextBox kp_mennyiseg;
        private System.Windows.Forms.Button buttonPenzBedobas;
        private System.Windows.Forms.GroupBox Keszpenz_fizetes;
        private System.Windows.Forms.Button ButtonReset;
    }
}

