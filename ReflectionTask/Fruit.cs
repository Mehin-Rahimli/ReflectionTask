using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask
{
    internal abstract class Fruit
    {
        public decimal Price {  get; set; }
        public string Sort {  get;  set; }
        public Fruit(decimal price, string sort)
        {
            Price = price;
            Sort = sort;


        }
        public virtual void Taste()
        {

            Console.WriteLine("Sirindir");
        }
              

    }
}
