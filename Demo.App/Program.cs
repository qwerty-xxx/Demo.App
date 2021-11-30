using System;

namespace Demo.App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var demo = new Lib.Demo();

            var result = demo.GetTwoMin(new[] { 4, 0, 3, 19, 492, -10, 1 });
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
