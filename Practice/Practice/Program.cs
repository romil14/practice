using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //int a = 10;
            //for (int i = 0; i < 20; i++)
            //{
            //    DemoClass obj = new DemoClass();
            //    obj.Id = i + 10;
            //    obj.Name = "Object " + i;
            //}

            //Demo3 d3 = new Demo3();
            //IDemo2 id2 = new Demo3();
            //IDemo3 id3 = new Demo3();

            //id2.GetName();
            //id3.GetName();

            MultipleAsyncCall multipleAsyncCall = new MultipleAsyncCall();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var data = await multipleAsyncCall.GetData();
            stopwatch.Stop();
            Console.WriteLine($"Time taken: {stopwatch.Elapsed.ToString(@"m\:ss\.fff")}");
            Console.WriteLine("Hello World!");
        }
    }

    public class DemoClass
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public interface IDemo1
    {

        int GetId();
    }

    public class Demo1
    {
        public virtual void GetName()
        {
            Console.WriteLine("From Demo1 Class"); 
        } 
    }

    public class Demo2 : Demo1
    {
        public override void GetName()
        {
            Console.WriteLine("From Demo2 Class");
        }
    }

    public interface IDemo2
    {
        void GetName();
    }

    public interface IDemo3
    {
      
        void GetName();
    }

    public class Demo3 : IDemo2, IDemo3
    {
         void IDemo2.GetName()
        {
            Console.WriteLine("From IDemo2.GetName()");
        }

          void IDemo3.GetName()
        {
            Console.WriteLine("From IDemo3.GetName()");
        }

        public void TestName()
        {
           
            Console.WriteLine("From TestName Method");
        }
    }

    public class Demo4
    {
        public void GetName()
        {
            Console.WriteLine("From Demo4 Class");
        }
    }
}
