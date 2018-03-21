using System;
using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Behaviors.QuackBehaviors
{
    public class RobotQuackBehavior : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("bleep bloop quack quack!");

    }
}