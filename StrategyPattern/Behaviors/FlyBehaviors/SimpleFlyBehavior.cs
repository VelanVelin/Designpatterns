using System;
using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Behaviors.FlyBehaviors
{
    public class SimpleFlyBehavior : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I use my wings to fly! flap flap!");
    }
}