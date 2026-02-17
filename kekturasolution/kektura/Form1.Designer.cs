namespace kektura
{
    partial class Kektura
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
            this.listBoxUtvonalLista = new System.Windows.Forms.ListBox();
            this.labelSorokSzama = new System.Windows.Forms.Label();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKiinduloPont = new System.Windows.Forms.TextBox();
            this.textBoxVegPont = new System.Windows.Forms.TextBox();
            this.textBoxSzakaszHossz = new System.Windows.Forms.TextBox();
            this.textBoxEmelkedes = new System.Windows.Forms.TextBox();
            this.textBoxLejtes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxPecset = new System.Windows.Forms.CheckBox();
            this.groupBoxKereses = new System.Windows.Forms.GroupBox();
            this.textBoxKereses = new System.Windows.Forms.TextBox();
            this.buttonKereses = new System.Windows.Forms.Button();
            this.groupBoxKereses.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUtvonalLista
            // 
            this.listBoxUtvonalLista.FormattingEnabled = true;
            this.listBoxUtvonalLista.Location = new System.Drawing.Point(73, 71);
            this.listBoxUtvonalLista.Name = "listBoxUtvonalLista";
            this.listBoxUtvonalLista.Size = new System.Drawing.Size(239, 95);
            this.listBoxUtvonalLista.TabIndex = 0;
            // 
            // labelSorokSzama
            // 
            this.labelSorokSzama.AutoSize = true;
            this.labelSorokSzama.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSorokSzama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSorokSzama.Location = new System.Drawing.Point(280, 169);
            this.labelSorokSzama.Name = "labelSorokSzama";
            this.labelSorokSzama.Size = new System.Drawing.Size(32, 13);
            this.labelSorokSzama.TabIndex = 1;
            this.labelSorokSzama.Text = "0 db";
            this.labelSorokSzama.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonShowData
            // 
            this.buttonShowData.Location = new System.Drawing.Point(401, 71);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(140, 23);
            this.buttonShowData.TabIndex = 2;
            this.buttonShowData.Text = "AdatokMegjelenitése";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kiinduló pont";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Végpont";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Emelkedés(m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Szakasz Hossz(Km)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lejtés";
            // 
            // textBoxKiinduloPont
            // 
            this.textBoxKiinduloPont.Location = new System.Drawing.Point(73, 201);
            this.textBoxKiinduloPont.Name = "textBoxKiinduloPont";
            this.textBoxKiinduloPont.ReadOnly = true;
            this.textBoxKiinduloPont.Size = new System.Drawing.Size(100, 20);
            this.textBoxKiinduloPont.TabIndex = 9;
            // 
            // textBoxVegPont
            // 
            this.textBoxVegPont.Location = new System.Drawing.Point(73, 241);
            this.textBoxVegPont.Name = "textBoxVegPont";
            this.textBoxVegPont.ReadOnly = true;
            this.textBoxVegPont.Size = new System.Drawing.Size(100, 20);
            this.textBoxVegPont.TabIndex = 10;
            // 
            // textBoxSzakaszHossz
            // 
            this.textBoxSzakaszHossz.Location = new System.Drawing.Point(73, 281);
            this.textBoxSzakaszHossz.Name = "textBoxSzakaszHossz";
            this.textBoxSzakaszHossz.ReadOnly = true;
            this.textBoxSzakaszHossz.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzakaszHossz.TabIndex = 11;
            // 
            // textBoxEmelkedes
            // 
            this.textBoxEmelkedes.Location = new System.Drawing.Point(73, 321);
            this.textBoxEmelkedes.Name = "textBoxEmelkedes";
            this.textBoxEmelkedes.ReadOnly = true;
            this.textBoxEmelkedes.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmelkedes.TabIndex = 12;
            // 
            // textBoxLejtes
            // 
            this.textBoxLejtes.Location = new System.Drawing.Point(73, 361);
            this.textBoxLejtes.Name = "textBoxLejtes";
            this.textBoxLejtes.ReadOnly = true;
            this.textBoxLejtes.Size = new System.Drawing.Size(100, 20);
            this.textBoxLejtes.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pecsételő hely";
            // 
            // checkBoxPecset
            // 
            this.checkBoxPecset.AutoSize = true;
            this.checkBoxPecset.Enabled = false;
            this.checkBoxPecset.Location = new System.Drawing.Point(158, 383);
            this.checkBoxPecset.Name = "checkBoxPecset";
            this.checkBoxPecset.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPecset.TabIndex = 14;
            this.checkBoxPecset.UseVisualStyleBackColor = true;
            // 
            // groupBoxKereses
            // 
            this.groupBoxKereses.Controls.Add(this.buttonKereses);
            this.groupBoxKereses.Controls.Add(this.textBoxKereses);
            this.groupBoxKereses.Location = new System.Drawing.Point(401, 169);
            this.groupBoxKereses.Name = "groupBoxKereses";
            this.groupBoxKereses.Size = new System.Drawing.Size(294, 100);
            this.groupBoxKereses.TabIndex = 15;
            this.groupBoxKereses.TabStop = false;
            this.groupBoxKereses.Text = "Keresés a kiinduló pontok között";
            // 
            // textBoxKereses
            // 
            this.textBoxKereses.Location = new System.Drawing.Point(7, 20);
            this.textBoxKereses.Name = "textBoxKereses";
            this.textBoxKereses.Size = new System.Drawing.Size(187, 20);
            this.textBoxKereses.TabIndex = 0;
            // 
            // buttonKereses
            // 
            this.buttonKereses.Location = new System.Drawing.Point(201, 16);
            this.buttonKereses.Name = "buttonKereses";
            this.buttonKereses.Size = new System.Drawing.Size(75, 23);
            this.buttonKereses.TabIndex = 1;
            this.buttonKereses.Text = "Keresés";
            this.buttonKereses.UseVisualStyleBackColor = true;
            this.buttonKereses.Click += new System.EventHandler(this.buttonKereses_Click);
            // 
            // Kektura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKereses);
            this.Controls.Add(this.checkBoxPecset);
            this.Controls.Add(this.textBoxLejtes);
            this.Controls.Add(this.textBoxEmelkedes);
            this.Controls.Add(this.textBoxSzakaszHossz);
            this.Controls.Add(this.textBoxVegPont);
            this.Controls.Add(this.textBoxKiinduloPont);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShowData);
            this.Controls.Add(this.labelSorokSzama);
            this.Controls.Add(this.listBoxUtvonalLista);
            this.Name = "Kektura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kéktura";
            this.Load += new System.EventHandler(this.Kektura_Load);
            this.groupBoxKereses.ResumeLayout(false);
            this.groupBoxKereses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUtvonalLista;
        private System.Windows.Forms.Label labelSorokSzama;
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKiinduloPont;
        private System.Windows.Forms.TextBox textBoxVegPont;
        private System.Windows.Forms.TextBox textBoxSzakaszHossz;
        private System.Windows.Forms.TextBox textBoxEmelkedes;
        private System.Windows.Forms.TextBox textBoxLejtes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxPecset;
        private System.Windows.Forms.GroupBox groupBoxKereses;
        private System.Windows.Forms.Button buttonKereses;
        private System.Windows.Forms.TextBox textBoxKereses;
    }
}

