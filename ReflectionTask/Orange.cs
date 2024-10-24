using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask
{
    internal class Orange:Fruit
    {
        public int VitaminC;
        public Orange(decimal price,int vitaminC) : base(price, "Orange")
        {
            VitaminC = vitaminC;

        }
        public override void Taste()
        {
            Console.WriteLine("Portagal sulu,sirin");
        }
    }
}
