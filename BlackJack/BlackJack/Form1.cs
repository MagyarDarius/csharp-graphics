using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BJClassLibrary.ClassLibraryBJ;

namespace BlackJack
{
    public partial class FormBJ : Form
    {
        public FormBJ()
        {
            InitializeComponent();
        }
        BlackjackGame game = new BlackjackGame();

        private void FormBJ_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panelTet.Visible = false;
        }

        private void buttonPlaceBet_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxBet.Text, out int bet))
            {
                if (game.PlaceBet(bet))
                {
                    panelTet.Visible = false;

                    ResetGameControls();

                    game.StartGame();
                    UpdateUI();

                    string instantResult = game.CheckInitialBlackjack();

                    if (instantResult != null)
                    {
                        labelResult.Text = instantResult;
                        labelResult.Visible = true;

                        EndRoundUI();
                        UpdateUI();
                        return;
                    }

                    buttonHit.Visible = true;
                    buttonStand.Visible = true;
                    labelDealerValue.Visible = true;
                    labelPlayerValue.Visible = true;
                    panelDealerCards.Visible = true;
                    panelPlayerCards.Visible = true;

                    labelResult.Visible = false;

                    buttonHit.Enabled = true;
                    buttonStand.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Invalid bet! Check your balance.");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid number for your bet.");
            }
        }

        private void buttonTetKezdes_Click(object sender, EventArgs e)
        {
            panelTet.Visible = true;
        }

        private void buttonAceInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Az ász alapértelmezésben 11-nek számít, ha így a kéz összértéke nem haladja meg a 21-et. Ha 11-ként számolva a kéz értéke 21 fölé menne (azaz „besokallnál”), akkor az ász automatikusan 1-re változik.",
                "Ász információ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private void UpdateUI()
        {
            labelPlayerValue.Text = game.PlayerHand.GetValue().ToString();
            labelDealerValue.Text = game.DealerHand.GetValue().ToString();

            DisplayCards();

            labelBalance.Text = $"Balance: {game.PlayerBalance}";
        }

        private void buttonHit_Click(object sender, EventArgs e)
        {
            game.PlayerHit();
            UpdateUI();

            if (game.PlayerHand.IsBust())
            {
                labelResult.Text = $"Dealer Wins, Lost {game.CurrentBet}";
                labelResult.Visible = true;

                DisableGameControls();

                game.ResetBet();

                EndRoundUI();
            }
        }

        private void buttonStand_Click(object sender, EventArgs e)
        {
            string result = game.Stand();
            UpdateUI();

            labelResult.Text = result;
            labelResult.Visible = true;

            DisableGameControls();

            EndRoundUI();
        }
        private void DisableGameControls()
        {
            buttonHit.Enabled = false;
            buttonStand.Enabled = false;
            buttonHit.BackColor = Color.LightGray;
            buttonStand.BackColor = Color.LightGray;
        }
        private void ResetGameControls()
        {
            buttonHit.BackColor = Color.Gray;
            buttonStand.BackColor = Color.Gray;
        }
        private void EndRoundUI()
        {
            DisableGameControls();
            panelTet.Visible = true;
        }
        private Image GetCardImage(Card card)
        {
            string suit = card.Suit.ToString().ToLower();

            string rank = card.Rank.ToString();

            if (rank == "Two") rank = "2";
            else if (rank == "Three") rank = "3";
            else if (rank == "Four") rank = "4";
            else if (rank == "Five") rank = "5";
            else if (rank == "Six") rank = "6";
            else if (rank == "Seven") rank = "7";
            else if (rank == "Eight") rank = "8";
            else if (rank == "Nine") rank = "9";
            else if (rank == "Ten") rank = "10";

            string fileName = $"{suit}_{rank}.png";

            string path = Path.Combine(Application.StartupPath, "Cards", fileName);

            return Image.FromFile(path);
        }
        private void DisplayCards()
        {
            panelPlayerCards.Controls.Clear();
            panelDealerCards.Controls.Clear();

            int offset = 0;

            foreach (var card in game.PlayerHand.Cards)
            {
                PictureBox pic = new PictureBox();
                pic.Image = GetCardImage(card);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 80;
                pic.Height = 120;
                pic.Left = offset;

                panelPlayerCards.Controls.Add(pic);

                offset += 85;
            }

            offset = 0;

            foreach (var card in game.DealerHand.Cards)
            {
                PictureBox pic = new PictureBox();
                pic.Image = GetCardImage(card);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 80;
                pic.Height = 120;
                pic.Left = offset;

                panelDealerCards.Controls.Add(pic);

                offset += 85;
            }
        }
    }
}
