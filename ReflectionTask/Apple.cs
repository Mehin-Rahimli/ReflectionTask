using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask
{
    internal class Apple:Fruit
    {
        public int VitaminA;
        public int VitaminB;
        public Apple(decimal price,int vitaminA,int vitaminB):base(price,"Apple")
        {
            VitaminA = vitaminA;

            VitaminB = vitaminB;

            
        }
        public override void Taste()
        {
            
            Console.WriteLine("Alma berk,sirin");
        }
    }
}
