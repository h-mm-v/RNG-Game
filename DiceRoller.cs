using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RNGGame_2
{
    internal class DiceRoller
    {
        //Fields
        private int diceResult;
        public int rollTotal = 0;
        Random randomNum = new Random();

        private Image d6_1 = new Bitmap("d6_1.png");
        private Image d6_2 = new Bitmap("d6_2.png");
        private Image d6_3 = new Bitmap("d6_3.png");
        private Image d6_4 = new Bitmap("d6_4.png");
        private Image d6_5 = new Bitmap("d6_5.png");
        private Image d6_6 = new Bitmap("d6_6.png");

        public PictureBox DiceRollImage { get; set; }

        //default constructor
        public DiceRoller()
        {
            rollTotal = 0;
            diceResult = 0;
        }

        public int DiceResult
        {
            get { return diceResult;}
            set { diceResult = value; }
        }

        public int Rolld4()
        {
            diceResult = randomNum.Next(4) + 1;
            return diceResult;
        }
        public int Rolld6()
        {
            diceResult = randomNum.Next(6) + 1;
            return diceResult;
        }
        public Image SetD6Image(int diceResult)
        {
            Image face = d6_1;
            switch (diceResult)
            {
                case 1:
                    face = d6_1;
                    return face;
                case 2:
                    face = d6_2;
                    return face;
                case 3:
                    face = d6_3;
                    return face;
                case 4:
                    face = d6_4;
                    return face;
                case 5:
                    face = d6_5;
                    return face;
                case 6:
                    face = d6_6;
                    return face;
                default:
                    return face;
            }
        }
        public int Rolld8()
        {
            diceResult = randomNum.Next(8) + 1;
            return diceResult;
        }
        public int Rolld10()
        {
            diceResult = randomNum.Next(10) + 1;
            return diceResult;
        }
        public int Rolld12()
        {
            diceResult = randomNum.Next(12) + 1;
            return diceResult;
        }
        public int Rolld20()
        {
            diceResult = randomNum.Next(20) + 1;
            return diceResult;
        }
    }
}
