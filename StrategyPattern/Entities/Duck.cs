using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Entities
{
    public class Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;
       

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            this._flyBehavior = flyBehavior;
            this._quackBehavior = quackBehavior;
        }

        public void Fly()
        {
            this._flyBehavior.Fly();
        }

        public void Quack()
        {
            this._quackBehavior.Quack();
        }
    }
    
}