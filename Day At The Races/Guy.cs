using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Races
{
    public class Guy : Bet // tazi sahipleri class`i bahis class`indan kalitim edilmistir.
    {
        public Bet MyBet;// bahis class`ini cagirdik placeBet metodunda nesnesini olsturduk
        public decimal Cash;
        public int[] GuyArray;
        public RadioButton MyRadioButton;
        public Label MyLabel;
        public Label MyLabel2;


        // burda kazanilan cash miktarini ad ile beraber soyler
        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has $" + Cash;
        }
        // bahis oranlarini temizlemek ve default degerleri gostermek
        public void ClearBet()
        {
            MyBet = null;
            MyLabel2.Text = Name + " hasn't placed a bet";
        }
        // burda bahis classindan gelen parametrelerin degerini verdik
        public bool PlaceBet(int BetAmount, string DogToWin, decimal Test)
        {
            this.MyBet = new Bet()
            {
                Amount = BetAmount,
                Dog = DogToWin,
                Bettor = this,
                odds = Test,
            };
            // bahisMiktari guys`in nakit parasindan kucuk ise oyunu oyna 
            if (BetAmount <= Cash)
            {
                MyLabel2.Text = this.Name + " bets " + BetAmount + " dollars on " + DogToWin;
                this.UpdateLabels();
                return true;
            }
            // bahisMiktari guys`in nakit parsindan buyukse uyari mesaji gondersin
            else
            {
                MessageBox.Show(Name + " does not have enough cash to cover that bet ");
                this.MyBet = null;
                return false;
            }
        }

        public void Collect(string Winner)
        {
            if (MyBet != null)
                Cash = Cash + MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
