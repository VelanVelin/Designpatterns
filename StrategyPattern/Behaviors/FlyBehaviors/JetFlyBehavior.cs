using System;
using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Behaviors.FlyBehaviors
{
    public class JetFlyBehavior: IFlyBehavior
    {
        public void Fly() => Console.WriteLine("Im a jet powered duck!");
    }
}