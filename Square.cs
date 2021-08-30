using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Opgave
{
    public class Square
    {
        // Opgave A og B

        // Attribute til vores firkant
        private int side;

        public int Side
        {
            get
            {
                return this.side;
            }
            set
            {
                this.side = value;
            }
        }

        // Constructor som ikke kræver en værdi
        public Square()
        {
        }

        // Constructer som kræver en værdi
        public Square(int a)
        {
            this.side = a;
        }

        // Metode til at udregne omkreds
        public int Perimiter()
        {
            return (4 * side);
        }
        // Metode til at udregne areal
        public int Area()
        {
            return (side * side);
        }
    }
}
