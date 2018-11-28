using BehavioralPatterns.ChainOfResponsibility.Abstract;

namespace BehavioralPatterns.ChainOfResponsibility.Concrete
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int condition)
        {
            if (condition == 1)
            {
                // handle
            }
            else
            {
                Successor?.HandleRequest(condition);
            }
        }
    }
}