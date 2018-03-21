using System;
using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Behaviors.QuackBehaviors
{
    public class NormalQuackBehavior : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("Quack Quack Quack!!!");
    }
}