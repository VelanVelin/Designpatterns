using System;
using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Behaviors.QuackBehaviors
{
    public class NoQuackBehavior : IQuackBehavior
    {
        public void Quack() => Console.WriteLine(@"I have no quack :´(");
    }
}