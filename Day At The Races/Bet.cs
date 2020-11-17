using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    public class Bet:Greyhound // Olasilik class`i Tazi class`indan kalitim yapiyor!!
    {
        public decimal Amount;//miktar
        public string Dog;//kopekler
        public Guy Bettor;//bahisciler
        public decimal odds;//olasiliklar
       
        // bets`in onceki ve yaris sonrasi aciklamalari
        public string GetDescription()
        {
            if (Amount == 0)
                return Bettor.Name + "hasn't placed a bet";
            else
                return Bettor.Name + " placed a bet of " + Amount + " dollars on " + Dog;
        }
        // yaris bittikten sonra kazanan ve kaybedenlerin dollars.
        public decimal PayOut(string Winner)
        {
            if (Winner == Dog)
                return Amount * odds;
            else
                return (0 - Amount);
        }
    }
}
