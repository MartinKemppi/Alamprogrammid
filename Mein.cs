using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alamprogrammid
{
    internal class Mein
    {
        public static void Main(string[] args)
        {

            double aritm = Alamprogramm.Keskmine(2);
            Console.WriteLine(aritm);

            string kassid = Alamprogramm.Kassi_kalkulaator(25,35,'+');
            Console.WriteLine(kassid);

            Alamprogramm.Stars(20);

            Alamprogramm.NStars(5);

        }


    }
}
