using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Behaviors;
using StrategyPattern.Behaviors.FlyBehaviors;
using StrategyPattern.Behaviors.QuackBehaviors;
using StrategyPattern.Entities;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var jetPoweredRobotDuck = new Duck(new JetFlyBehavior(), new RobotQuackBehavior());
            jetPoweredRobotDuck.Fly();
            jetPoweredRobotDuck.Quack();
            Console.Read();
        }
    }
}
