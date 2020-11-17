using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Races
{
    // burasi tazi sinifi 
    public class Greyhound
    {
        public string Name;
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;// burasi goruntunun tamamini kapsadigi yer ve tazilari kapsadigi yer
        public bool Winner = false;
        public int Location = 0;// tazilarin baslangic noktalari
        public decimal oddsFor; // oranlar
        public decimal oddsAgainst; //karsi oranlar

        public Random Randomizer;// rastgele degerler

        public bool Run()
        {
            int move = Randomizer.Next(1, 6);
            Location = Location + move;
            MyPictureBox.Left = StartingPosition + Location;
            if (MyPictureBox.Left >= RaceTrackLength)
            {
                Winner = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
