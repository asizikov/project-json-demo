using System;
using System.Linq;
using System.Reactive.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeter = new Greeter();

            Enumerable.Range(0, 10).ToObservable().Subscribe(i =>
            {
                Console.WriteLine(greeter.Greet());
            });
            Console.ReadKey();
        }
    }
}
