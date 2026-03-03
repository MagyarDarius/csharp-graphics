namespace BlackJack
{
    partial class FormBJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBJ));
            this.textBoxTet = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonTetRakasa = new System.Windows.Forms.Button();
            this.labelTet = new System.Windows.Forms.Label();
            this.buttonTetKezdes = new System.Windows.Forms.Button();
            this.pictureBoxSlots = new System.Windows.Forms.PictureBox();
            this.buttonGameStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTetOsszeg = new System.Windows.Forms.Label();
            this.panelTet = new System.Windows.Forms.Panel();
            this.panelCards = new System.Windows.Forms.Panel();
            this.labelCards = new System.Windows.Forms.Label();
            this.labelAceCard = new System.Windows.Forms.Label();
            this.buttonAceInfo = new System.Windows.Forms.Button();
            this.labelHeadCards = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlots)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTet.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTet
            // 
            this.textBoxTet.BackColor = System.Drawing.Color.White;
            this.textBoxTet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTet.ForeColor = System.Drawing.Color.Crimson;
            this.textBoxTet.Location = new System.Drawing.Point(172, 4);
            this.textBoxTet.Name = "textBoxTet";
            this.textBoxTet.Size = new System.Drawing.Size(120, 19);
            this.textBoxTet.TabIndex = 0;
            this.textBoxTet.TextChanged += new System.EventHandler(this.textBoxTet_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Location = new System.Drawing.Point(46, 29);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 30);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonTetRakasa
            // 
            this.buttonTetRakasa.BackColor = System.Drawing.Color.White;
            this.buttonTetRakasa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTetRakasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTetRakasa.ForeColor = System.Drawing.Color.Crimson;
            this.buttonTetRakasa.Location = new System.Drawing.Point(172, 29);
            this.buttonTetRakasa.Name = "buttonTetRakasa";
            this.buttonTetRakasa.Size = new System.Drawing.Size(120, 30);
            this.buttonTetRakasa.TabIndex = 3;
            this.buttonTetRakasa.Text = "Véglegesités";
            this.buttonTetRakasa.UseVisualStyleBackColor = false;
            this.buttonTetRakasa.Click += new System.EventHandler(this.buttonTetRakasa_Click);
            // 
            // labelTet
            // 
            this.labelTet.AutoSize = true;
            this.labelTet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTet.ForeColor = System.Drawing.Color.Crimson;
            this.labelTet.Location = new System.Drawing.Point(20, 9);
            this.labelTet.Name = "labelTet";
            this.labelTet.Size = new System.Drawing.Size(129, 16);
            this.labelTet.TabIndex = 4;
            this.labelTet.Text = "Tedd meg tétjeid!";
            // 
            // buttonTetKezdes
            // 
            this.buttonTetKezdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTetKezdes.ForeColor = System.Drawing.Color.Crimson;
            this.buttonTetKezdes.Location = new System.Drawing.Point(25, 28);
            this.buttonTetKezdes.Name = "buttonTetKezdes";
            this.buttonTetKezdes.Size = new System.Drawing.Size(120, 23);
            this.buttonTetKezdes.TabIndex = 5;
            this.buttonTetKezdes.Text = "Tét Megtétele";
            this.buttonTetKezdes.UseVisualStyleBackColor = true;
            this.buttonTetKezdes.Click += new System.EventHandler(this.buttonTetKezdes_Click);
            // 
            // pictureBoxSlots
            // 
            this.pictureBoxSlots.BackColor = System.Drawing.Color.Black;
            this.pictureBoxSlots.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSlots.BackgroundImage")));
            this.pictureBoxSlots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSlots.ErrorImage = null;
            this.pictureBoxSlots.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSlots.InitialImage")));
            this.pictureBoxSlots.Location = new System.Drawing.Point(523, -4);
            this.pictureBoxSlots.Name = "pictureBoxSlots";
            this.pictureBoxSlots.Size = new System.Drawing.Size(278, 168);
            this.pictureBoxSlots.TabIndex = 6;
            this.pictureBoxSlots.TabStop = false;
            // 
            // buttonGameStart
            // 
            this.buttonGameStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGameStart.ForeColor = System.Drawing.Color.Crimson;
            this.buttonGameStart.Location = new System.Drawing.Point(3, 3);
            this.buttonGameStart.Name = "buttonGameStart";
            this.buttonGameStart.Size = new System.Drawing.Size(143, 35);
            this.buttonGameStart.TabIndex = 7;
            this.buttonGameStart.Text = "Játék Inditása";
            this.buttonGameStart.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonGameStart);
            this.panel1.Location = new System.Drawing.Point(1, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 176);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // labelTetOsszeg
            // 
            this.labelTetOsszeg.AutoSize = true;
            this.labelTetOsszeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTetOsszeg.ForeColor = System.Drawing.Color.Crimson;
            this.labelTetOsszeg.Location = new System.Drawing.Point(-3, 7);
            this.labelTetOsszeg.Name = "labelTetOsszeg";
            this.labelTetOsszeg.Size = new System.Drawing.Size(176, 16);
            this.labelTetOsszeg.TabIndex = 4;
            this.labelTetOsszeg.Text = "Adja meg a tét összegét (Ft):";
            // 
            // panelTet
            // 
            this.panelTet.Controls.Add(this.labelTetOsszeg);
            this.panelTet.Controls.Add(this.buttonCancel);
            this.panelTet.Controls.Add(this.textBoxTet);
            this.panelTet.Controls.Add(this.buttonTetRakasa);
            this.panelTet.Location = new System.Drawing.Point(25, 55);
            this.panelTet.Name = "panelTet";
            this.panelTet.Size = new System.Drawing.Size(299, 112);
            this.panelTet.TabIndex = 9;
            this.panelTet.Visible = false;
            // 
            // panelCards
            // 
            this.panelCards.Controls.Add(this.labelHeadCards);
            this.panelCards.Controls.Add(this.buttonAceInfo);
            this.panelCards.Controls.Add(this.labelAceCard);
            this.panelCards.Controls.Add(this.labelCards);
            this.panelCards.Location = new System.Drawing.Point(330, 55);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(187, 109);
            this.panelCards.TabIndex = 10;
            // 
            // labelCards
            // 
            this.labelCards.AutoSize = true;
            this.labelCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCards.ForeColor = System.Drawing.Color.Black;
            this.labelCards.Location = new System.Drawing.Point(4, 7);
            this.labelCards.Name = "labelCards";
            this.labelCards.Size = new System.Drawing.Size(123, 18);
            this.labelCards.TabIndex = 0;
            this.labelCards.Text = "Kártyák összege:";
            // 
            // labelAceCard
            // 
            this.labelAceCard.AutoSize = true;
            this.labelAceCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAceCard.ForeColor = System.Drawing.Color.Black;
            this.labelAceCard.Location = new System.Drawing.Point(7, 29);
            this.labelAceCard.Name = "labelAceCard";
            this.labelAceCard.Size = new System.Drawing.Size(96, 18);
            this.labelAceCard.TabIndex = 1;
            this.labelAceCard.Text = "A = 11 vagy 1";
            // 
            // buttonAceInfo
            // 
            this.buttonAceInfo.BackColor = System.Drawing.Color.White;
            this.buttonAceInfo.FlatAppearance.BorderSize = 0;
            this.buttonAceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAceInfo.Location = new System.Drawing.Point(109, 28);
            this.buttonAceInfo.Name = "buttonAceInfo";
            this.buttonAceInfo.Size = new System.Drawing.Size(18, 31);
            this.buttonAceInfo.TabIndex = 2;
            this.buttonAceInfo.Text = "?";
            this.buttonAceInfo.UseVisualStyleBackColor = false;
            this.buttonAceInfo.Click += new System.EventHandler(this.buttonAceInfo_Click);
            // 
            // labelHeadCards
            // 
            this.labelHeadCards.AutoSize = true;
            this.labelHeadCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHeadCards.Location = new System.Drawing.Point(4, 72);
            this.labelHeadCards.Name = "labelHeadCards";
            this.labelHeadCards.Size = new System.Drawing.Size(79, 18);
            this.labelHeadCards.TabIndex = 3;
            this.labelHeadCards.Text = "J,Q,K = 10";
            // 
            // FormBJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.panelTet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxSlots);
            this.Controls.Add(this.buttonTetKezdes);
            this.Controls.Add(this.labelTet);
            this.Name = "FormBJ";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.FormBJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlots)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelTet.ResumeLayout(false);
            this.panelTet.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.panelCards.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTet;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonTetRakasa;
        private System.Windows.Forms.Label labelTet;
        private System.Windows.Forms.Button buttonTetKezdes;
        private System.Windows.Forms.PictureBox pictureBoxSlots;
        private System.Windows.Forms.Button buttonGameStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTetOsszeg;
        private System.Windows.Forms.Panel panelTet;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Label labelCards;
        private System.Windows.Forms.Label labelAceCard;
        private System.Windows.Forms.Button buttonAceInfo;
        private System.Windows.Forms.Label labelHeadCards;
    }
}

