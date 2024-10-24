using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask
{
    internal class Pineapple:Fruit
    {
        public int VitaminE;
        public int VitaminD;
        public Pineapple(decimal price,int vitaminE, int vitaminD) : base(price, "Pineapple")
        {
            VitaminE = vitaminE;

            VitaminD = vitaminD;


        }
        public override void Taste()
        {
            Console.WriteLine("Ananas sirindir");
        }
    }
}
