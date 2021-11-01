using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Game
{
    class Letters
    {
        Random random = new Random();
        char letter;
        int xPos;
        int yPos;

       public char Letter
        {
            get;set;
        }
        public int XPos
        {
            get;
        }

        public int YPos
        {
            get;
        }

        public Letters(char c,int x,int y)
        {
            Letter = c;
            XPos = x;
            YPos = y;
        }


    }
}
