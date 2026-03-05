using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    MessageBox.Show($"Bet of {bet} accepted!");
                    buttonGameStart.Visible = true;
                    panelTet.Visible = false;
                    UpdateUI();
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

            listBoxPlayerCards.Items.Clear();
            listBoxDealerCards.Items.Clear();

            foreach (var card in game.PlayerHand.Cards)
                listBoxPlayerCards.Items.Add(card.ToString());

            foreach (var card in game.DealerHand.Cards)
                listBoxDealerCards.Items.Add(card.ToString());

            labelBalance.Text = $"Balance: {game.PlayerBalance}";
        }
        private void buttonGameStart_Click(object sender, EventArgs e)
        {
            ResetGameControls();
            if (game.CurrentBet == 0)
            {
                MessageBox.Show("Please place a bet before starting a new game.");
                return;
            }

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
            listBoxDealerCards.Visible = true;
            listBoxPlayerCards.Visible = true;

            labelResult.Visible = false;

            buttonHit.Enabled = true;
            buttonStand.Enabled = true;

            buttonGameStart.Visible = false;
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

                buttonGameStart.Text = "New Game!";
                buttonGameStart.Visible = true;
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

            buttonGameStart.Text = "New Game!";
            buttonGameStart.Visible = true;
            EndRoundUI();
        }
        private void DisableGameControls()
        {
            buttonHit.Enabled = false;
            buttonStand.Enabled = false;
            buttonHit.BackColor = Color.DimGray;
            buttonStand.BackColor = Color.DimGray;
        }
        private void ResetGameControls()
        {
            buttonHit.BackColor = Color.Gray;
            buttonStand.BackColor = Color.Gray;
        }
        private void EndRoundUI()
        {
            DisableGameControls();

            buttonGameStart.Text = "New Game!";
            buttonGameStart.Visible = true;

            panelTet.Visible = true;
        }
    }
}
