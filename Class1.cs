using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square
    {
        //instance var
        private float squareLength;

        //constructor
        public Square(){}

        public float SquareLength
        {
            get { return squareLength; }
            set { squareLength = value; }
        }

        //SquareAreaCalc method
        public float SquareAreaCalc()
        {
             float area = squareLength * 4;
            return area;
        }
    }
}
