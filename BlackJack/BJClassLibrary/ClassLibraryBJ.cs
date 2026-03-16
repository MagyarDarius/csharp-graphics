using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJClassLibrary
{
    public class ClassLibraryBJ
    {
        public enum Suit { Hearts, Diamonds, Clubs, Spades }

        public enum Rank { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack = 10, Queen = 10, King = 10, Ace = 11 }

        public class Card
        {
            public Suit Suit { get; set; }
            public Rank Rank { get; set; }

            public int Value => (int)Rank;

            public override string ToString()
            {
                return $"{Rank} of {Suit}";
            }
        }
        public class Deck
        {
            private List<Card> cards;
            private Random rng = new Random();

            public Deck()
            {
                cards = new List<Card>();

                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                    {
                        cards.Add(new Card { Suit = suit, Rank = rank });
                    }
                }

                Shuffle();
            }

            public void Shuffle()
            {
                cards = cards.OrderBy(x => rng.Next()).ToList();
            }

            public Card DrawCard()
            {
                Card card = cards[0];
                cards.RemoveAt(0);
                return card;
            }
        }
        public class Hand
        {
            public List<Card> Cards { get; private set; } = new List<Card>();

            public void AddCard(Card card)
            {
                Cards.Add(card);
            }

            public int GetValue()
            {
                int value = Cards.Sum(c => c.Value);

                int aceCount = Cards.Count(c => c.Rank == Rank.Ace);

                while (value > 21 && aceCount > 0)
                {
                    value -= 10;
                    aceCount--;
                }

                return value;
            }

            public bool IsBust()
            {
                return GetValue() > 21;
            }

            public void Clear()
            {
                Cards.Clear();
            }
        }
        public class BlackjackGame
        {
            public Deck Deck { get; private set; }
            public Hand PlayerHand { get; private set; }
            public Hand DealerHand { get; private set; }

            public bool GameOver { get; private set; }

            public BlackjackGame()
            {
                Deck = new Deck();
                PlayerHand = new Hand();
                DealerHand = new Hand();
            }
            public void StartGame()
            {
                Deck = new Deck();
                PlayerHand.Clear();
                DealerHand.Clear();
                GameOver = false;

                PlayerHand.AddCard(Deck.DrawCard());
                DealerHand.AddCard(Deck.DrawCard());
                PlayerHand.AddCard(Deck.DrawCard());
                DealerHand.AddCard(Deck.DrawCard());

            }

            public void PlayerHit()
            {
                if (GameOver)
                    return;

                PlayerHand.AddCard(Deck.DrawCard());

                if (PlayerHand.IsBust())
                    GameOver = true;
            }
            public string Stand()
            {
                while (DealerHand.GetValue() < 17)
                {
                    DealerHand.AddCard(Deck.DrawCard());
                }

                GameOver = true;

                int player = PlayerHand.GetValue();
                int dealer = DealerHand.GetValue();
                string result;

                if (DealerHand.IsBust())
                {
                    PlayerBalance += CurrentBet * 2;
                    result = $"Dealer Busts, Won {CurrentBet *2}";
                }
                else if (PlayerHand.IsBust())
                {
                    result = $"Player Busts, Lost {CurrentBet}";
                }

                else if (player > dealer)
                {
                    PlayerBalance += CurrentBet * 2;
                    result = $"Player Wins, Won {CurrentBet * 2}";
                }


                else if (dealer > player)
                {
                    result = $"Dealer Wins, Lost {CurrentBet}";
                }
                else
                {
                    result = $"Push! Bet Returned";
                    PlayerBalance += CurrentBet;
                }
                CurrentBet = 0;
                return result;
            }
            public int PlayerBalance { get; private set; } = 1000;
            public int CurrentBet { get; private set; } = 0;
            public void ResetBet()
            {
                CurrentBet = 0;
            }
            public bool PlaceBet(int amount)
            {
                if (amount <= 0 || amount > PlayerBalance)
                    return false;

                CurrentBet = amount;
                PlayerBalance -= amount;
                return true;
            }
            public string CheckInitialBlackjack()
            {
                bool playerBJ = PlayerHand.GetValue() == 21 && PlayerHand.Cards.Count == 2;
                bool dealerBJ = DealerHand.GetValue() == 21 && DealerHand.Cards.Count == 2;

                if (playerBJ && dealerBJ)
                {
                    PlayerBalance += CurrentBet;
                    int betAmount = CurrentBet;
                    CurrentBet = 0;
                    GameOver = true;
                    return $"Both have Blackjack! Push. Bet of {betAmount} returned.";
                }
                else if (playerBJ)
                {
                    PlayerBalance += (int)(CurrentBet * 2.5);
                    int wonAmount = (int)(CurrentBet * 2.5);
                    CurrentBet = 0;
                    GameOver = true;
                    return $"Blackjack! You win {wonAmount}";
                }
                else if (dealerBJ)
                {
                    int lostAmount = CurrentBet;
                    CurrentBet = 0;
                    GameOver = true;
                    return $"Dealer has Blackjack! You lost {lostAmount}";
                }

                return null;
            }
        }
    }
}
