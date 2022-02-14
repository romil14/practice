using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            for (int i = 0; i < 20; i++)
            {
                DemoClass obj = new DemoClass();
                obj.Id = i + 10;
                obj.Name = "Object " + i;
            }
            Console.WriteLine("Hello World!");
        }
    }

    public class DemoClass
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
