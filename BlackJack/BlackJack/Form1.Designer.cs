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
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPlaceBet = new System.Windows.Forms.Button();
            this.buttonTetKezdes = new System.Windows.Forms.Button();
            this.pictureBoxSlots = new System.Windows.Forms.PictureBox();
            this.buttonGameStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonStand = new System.Windows.Forms.Button();
            this.buttonHit = new System.Windows.Forms.Button();
            this.listBoxDealerCards = new System.Windows.Forms.ListBox();
            this.listBoxPlayerCards = new System.Windows.Forms.ListBox();
            this.labelDealerValue = new System.Windows.Forms.Label();
            this.labelPlayerValue = new System.Windows.Forms.Label();
            this.labelTetOsszeg = new System.Windows.Forms.Label();
            this.panelTet = new System.Windows.Forms.Panel();
            this.panelCards = new System.Windows.Forms.Panel();
            this.labelHeadCards = new System.Windows.Forms.Label();
            this.buttonAceInfo = new System.Windows.Forms.Button();
            this.labelAceCard = new System.Windows.Forms.Label();
            this.labelCards = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlots)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTet.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBet
            // 
            this.textBoxBet.BackColor = System.Drawing.Color.Gray;
            this.textBoxBet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBet.ForeColor = System.Drawing.Color.Crimson;
            this.textBoxBet.Location = new System.Drawing.Point(124, 7);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(120, 19);
            this.textBoxBet.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Gray;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCancel.Location = new System.Drawing.Point(46, 29);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 30);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonPlaceBet
            // 
            this.buttonPlaceBet.BackColor = System.Drawing.Color.Gray;
            this.buttonPlaceBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlaceBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlaceBet.ForeColor = System.Drawing.Color.Maroon;
            this.buttonPlaceBet.Location = new System.Drawing.Point(172, 29);
            this.buttonPlaceBet.Name = "buttonPlaceBet";
            this.buttonPlaceBet.Size = new System.Drawing.Size(120, 30);
            this.buttonPlaceBet.TabIndex = 3;
            this.buttonPlaceBet.Text = "Place Bet";
            this.buttonPlaceBet.UseVisualStyleBackColor = false;
            this.buttonPlaceBet.Click += new System.EventHandler(this.buttonPlaceBet_Click);
            // 
            // buttonTetKezdes
            // 
            this.buttonTetKezdes.BackColor = System.Drawing.Color.Gray;
            this.buttonTetKezdes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTetKezdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTetKezdes.ForeColor = System.Drawing.Color.Maroon;
            this.buttonTetKezdes.Location = new System.Drawing.Point(23, 18);
            this.buttonTetKezdes.Name = "buttonTetKezdes";
            this.buttonTetKezdes.Size = new System.Drawing.Size(120, 31);
            this.buttonTetKezdes.TabIndex = 5;
            this.buttonTetKezdes.Text = "Make Your Bet";
            this.buttonTetKezdes.UseVisualStyleBackColor = false;
            this.buttonTetKezdes.Click += new System.EventHandler(this.buttonTetKezdes_Click);
            // 
            // pictureBoxSlots
            // 
            this.pictureBoxSlots.BackColor = System.Drawing.Color.Black;
            this.pictureBoxSlots.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSlots.BackgroundImage")));
            this.pictureBoxSlots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSlots.ErrorImage = null;
            this.pictureBoxSlots.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSlots.InitialImage")));
            this.pictureBoxSlots.Location = new System.Drawing.Point(523, -1);
            this.pictureBoxSlots.Name = "pictureBoxSlots";
            this.pictureBoxSlots.Size = new System.Drawing.Size(278, 168);
            this.pictureBoxSlots.TabIndex = 6;
            this.pictureBoxSlots.TabStop = false;
            // 
            // buttonGameStart
            // 
            this.buttonGameStart.BackColor = System.Drawing.Color.Gray;
            this.buttonGameStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGameStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGameStart.ForeColor = System.Drawing.Color.Maroon;
            this.buttonGameStart.Location = new System.Drawing.Point(22, 24);
            this.buttonGameStart.Name = "buttonGameStart";
            this.buttonGameStart.Size = new System.Drawing.Size(143, 35);
            this.buttonGameStart.TabIndex = 7;
            this.buttonGameStart.Text = "Start The Game";
            this.buttonGameStart.UseVisualStyleBackColor = false;
            this.buttonGameStart.Visible = false;
            this.buttonGameStart.Click += new System.EventHandler(this.buttonGameStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.labelResult);
            this.panel1.Controls.Add(this.buttonStand);
            this.panel1.Controls.Add(this.buttonHit);
            this.panel1.Controls.Add(this.listBoxDealerCards);
            this.panel1.Controls.Add(this.listBoxPlayerCards);
            this.panel1.Controls.Add(this.labelDealerValue);
            this.panel1.Controls.Add(this.labelPlayerValue);
            this.panel1.Controls.Add(this.buttonGameStart);
            this.panel1.Location = new System.Drawing.Point(1, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 268);
            this.panel1.TabIndex = 8;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.Maroon;
            this.labelResult.Location = new System.Drawing.Point(455, 149);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(92, 31);
            this.labelResult.TabIndex = 14;
            this.labelResult.Text = "Result";
            this.labelResult.Visible = false;
            // 
            // buttonStand
            // 
            this.buttonStand.BackColor = System.Drawing.Color.Gray;
            this.buttonStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStand.ForeColor = System.Drawing.Color.Maroon;
            this.buttonStand.Location = new System.Drawing.Point(102, 203);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(76, 42);
            this.buttonStand.TabIndex = 13;
            this.buttonStand.Text = "Stand";
            this.buttonStand.UseVisualStyleBackColor = false;
            this.buttonStand.Visible = false;
            this.buttonStand.Click += new System.EventHandler(this.buttonStand_Click);
            // 
            // buttonHit
            // 
            this.buttonHit.BackColor = System.Drawing.Color.Gray;
            this.buttonHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHit.ForeColor = System.Drawing.Color.Maroon;
            this.buttonHit.Location = new System.Drawing.Point(102, 155);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(75, 42);
            this.buttonHit.TabIndex = 12;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = false;
            this.buttonHit.Visible = false;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            // 
            // listBoxDealerCards
            // 
            this.listBoxDealerCards.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.listBoxDealerCards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDealerCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDealerCards.ForeColor = System.Drawing.Color.Maroon;
            this.listBoxDealerCards.FormattingEnabled = true;
            this.listBoxDealerCards.ItemHeight = 18;
            this.listBoxDealerCards.Location = new System.Drawing.Point(329, 27);
            this.listBoxDealerCards.Name = "listBoxDealerCards";
            this.listBoxDealerCards.Size = new System.Drawing.Size(120, 72);
            this.listBoxDealerCards.TabIndex = 11;
            this.listBoxDealerCards.Visible = false;
            // 
            // listBoxPlayerCards
            // 
            this.listBoxPlayerCards.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.listBoxPlayerCards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlayerCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayerCards.ForeColor = System.Drawing.Color.Maroon;
            this.listBoxPlayerCards.FormattingEnabled = true;
            this.listBoxPlayerCards.ItemHeight = 18;
            this.listBoxPlayerCards.Location = new System.Drawing.Point(329, 155);
            this.listBoxPlayerCards.Name = "listBoxPlayerCards";
            this.listBoxPlayerCards.Size = new System.Drawing.Size(120, 72);
            this.listBoxPlayerCards.TabIndex = 10;
            this.listBoxPlayerCards.Visible = false;
            // 
            // labelDealerValue
            // 
            this.labelDealerValue.AutoSize = true;
            this.labelDealerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDealerValue.ForeColor = System.Drawing.Color.Maroon;
            this.labelDealerValue.Location = new System.Drawing.Point(191, 27);
            this.labelDealerValue.Name = "labelDealerValue";
            this.labelDealerValue.Size = new System.Drawing.Size(130, 25);
            this.labelDealerValue.TabIndex = 9;
            this.labelDealerValue.Text = "DealerValue";
            this.labelDealerValue.Visible = false;
            // 
            // labelPlayerValue
            // 
            this.labelPlayerValue.AutoSize = true;
            this.labelPlayerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerValue.ForeColor = System.Drawing.Color.Maroon;
            this.labelPlayerValue.Location = new System.Drawing.Point(191, 155);
            this.labelPlayerValue.Name = "labelPlayerValue";
            this.labelPlayerValue.Size = new System.Drawing.Size(128, 25);
            this.labelPlayerValue.TabIndex = 8;
            this.labelPlayerValue.Text = "PlayerValue";
            this.labelPlayerValue.Visible = false;
            // 
            // labelTetOsszeg
            // 
            this.labelTetOsszeg.AutoSize = true;
            this.labelTetOsszeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTetOsszeg.ForeColor = System.Drawing.Color.Maroon;
            this.labelTetOsszeg.Location = new System.Drawing.Point(18, 7);
            this.labelTetOsszeg.Name = "labelTetOsszeg";
            this.labelTetOsszeg.Size = new System.Drawing.Size(100, 16);
            this.labelTetOsszeg.TabIndex = 4;
            this.labelTetOsszeg.Text = "Bet Amount (Ft):";
            // 
            // panelTet
            // 
            this.panelTet.Controls.Add(this.labelTetOsszeg);
            this.panelTet.Controls.Add(this.buttonCancel);
            this.panelTet.Controls.Add(this.textBoxBet);
            this.panelTet.Controls.Add(this.buttonPlaceBet);
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
            // labelHeadCards
            // 
            this.labelHeadCards.AutoSize = true;
            this.labelHeadCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHeadCards.ForeColor = System.Drawing.Color.Maroon;
            this.labelHeadCards.Location = new System.Drawing.Point(7, 67);
            this.labelHeadCards.Name = "labelHeadCards";
            this.labelHeadCards.Size = new System.Drawing.Size(79, 18);
            this.labelHeadCards.TabIndex = 3;
            this.labelHeadCards.Text = "J,Q,K = 10";
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
            // labelAceCard
            // 
            this.labelAceCard.AutoSize = true;
            this.labelAceCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAceCard.ForeColor = System.Drawing.Color.Maroon;
            this.labelAceCard.Location = new System.Drawing.Point(7, 29);
            this.labelAceCard.Name = "labelAceCard";
            this.labelAceCard.Size = new System.Drawing.Size(96, 18);
            this.labelAceCard.TabIndex = 1;
            this.labelAceCard.Text = "A = 11 vagy 1";
            // 
            // labelCards
            // 
            this.labelCards.AutoSize = true;
            this.labelCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCards.ForeColor = System.Drawing.Color.Maroon;
            this.labelCards.Location = new System.Drawing.Point(4, 7);
            this.labelCards.Name = "labelCards";
            this.labelCards.Size = new System.Drawing.Size(123, 18);
            this.labelCards.TabIndex = 0;
            this.labelCards.Text = "Kártyák összege:";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.ForeColor = System.Drawing.Color.Crimson;
            this.labelBalance.Location = new System.Drawing.Point(149, 25);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(0, 24);
            this.labelBalance.TabIndex = 11;
            // 
            // FormBJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.panelTet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxSlots);
            this.Controls.Add(this.buttonTetKezdes);
            this.Name = "FormBJ";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.FormBJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlots)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTet.ResumeLayout(false);
            this.panelTet.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.panelCards.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPlaceBet;
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
        private System.Windows.Forms.Label labelPlayerValue;
        private System.Windows.Forms.Label labelDealerValue;
        private System.Windows.Forms.ListBox listBoxDealerCards;
        private System.Windows.Forms.ListBox listBoxPlayerCards;
        private System.Windows.Forms.Button buttonStand;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelBalance;
    }
}

