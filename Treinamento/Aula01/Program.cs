using System;
using Aula01.Model;

namespace Aula01
{
    class Program
    {
        public static void Print(object o)
        {
            Console.WriteLine(o.ToString());
        }

        public static void Show(Local local)
        {
            Console.WriteLine("{0} - {1}", local.Code, local.Size);
            local.Harvest();
        }

        static void Main(string[] args)
        {
            int i = 10;
            bool b = true;
            string s = "Luís Roberto";

            /*
            Print(i);
            Print(b);
            Print(s);
            */

            Sector sector1 = new Sector("S1", 100);

            Farm farm1 = new Farm();
            farm1.Code = "FM1";

            Block block1 = new Block();
            block1.Code = "B1";
            block1.Size = 50;

            Field field1 = new Field();
            field1.Code = "F1";
            field1.Size = 10;
            field1.Culture = "Sugar Cane";

            Show(sector1);
            Show(farm1);
            Show(block1);
            Show(field1);

            Console.ReadKey();
        }
    }
}
