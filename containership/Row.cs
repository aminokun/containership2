using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containership
{
    public class Row
    {
        List<Stack> stacks = new List<Stack>();
        private static int Length;
        private int AmountOfStacksLeft()
        {
            return Length / 2;
        }
        private int AmountOfStacksRight()
        {
            int LeftSide = AmountOfStacksLeft();
            int RightSide = Length - LeftSide;
            return RightSide;
        }
        public Row (int length)
        {
            Length = length;
        }
    }
}
