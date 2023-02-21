using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            Vector vek1 = new Vector(5,6,7);
                        Vector vek2 = new Vector(5, 6, 7);
                        vek1 = vek1 + vek2;
                        vek1.Show();*/
            Numbers num1 = new Numbers(150);
            num1.InVosSystem();
            Console.ReadLine();
        }
    }
}
