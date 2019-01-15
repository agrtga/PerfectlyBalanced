using System;

namespace PerfectlyBalanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new[] {
                new BalancedInput("xxxyyyzzz"),
                new BalancedInput("abccbaabccba"),
                new BalancedInput("xxxyyyzzzz"),
                new BalancedInput("abcdefghijklmnopqrstuvwxyz"),
                new BalancedInput("pqq"),
                new BalancedInput("fdedfdeffeddefeeeefddf"),
                new BalancedInput("www"),
                new BalancedInput("x"),
                new BalancedInput("")
            };

            Array.ForEach(inputs, i => Console.WriteLine($"input({i.Input} => {i.IsBalanced().ToString()}"));
        }
    }
}
