using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Opgave
{
    class Program
    {    
        static void Main(string[] args)
        {
            // Her opretter vi vores første kvadrat med en side på 5
            Square kvadrat = new Square(5);
            Console.WriteLine(kvadrat.Perimiter());
            Console.WriteLine(kvadrat.Area());

            // Her opretter vi vores anden kvadrat med en side på 10
            Square kvadrat2 = new Square(10);
            Console.WriteLine(kvadrat2.Perimiter());
            Console.WriteLine(kvadrat2.Area());
            
            // Her opretter vi vores tredje kvadrat fra en tom constructor og giver først siden en værdi efter den er oprettet
            Square kvadrat3 = new Square();
            kvadrat3.Side = 15;
            Console.WriteLine(kvadrat3.Perimiter());
            Console.WriteLine(kvadrat3.Area());
            Console.ReadLine();
        }
    }
}
