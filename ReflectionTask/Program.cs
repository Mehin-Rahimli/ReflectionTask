using System.Reflection;

namespace ReflectionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Basket=new Fruit[3];
            Basket[0] = new Apple(1.99m,10,15);
            Basket[1] = new Pineapple(3.99m, 9, 12);
            Basket[2] = new Orange(2.99m,20);
        
            foreach (var fruit in Basket)
            {   
                Console.WriteLine("----------------");
                Type type=fruit.GetType();
                Console.WriteLine($"Type:{type.Name}");
                FieldInfo[] fields=type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                foreach (var field in fields)
                {
                    Console.WriteLine($"Field: {field.Name} = {field.GetValue(fruit)}");
                }

                PropertyInfo[] properties = type.GetProperties(BindingFlags.Public |BindingFlags.Instance);
                foreach (var property in properties)
                {
                    Console.WriteLine($"Property: {property.Name} = {property.GetValue(fruit)}");
                }


                MethodInfo tasteMethod = type.GetMethod("Taste");
                if (tasteMethod != null)
                {
                    tasteMethod.Invoke(fruit, null);
                }
                
            }


        }
    }
}
