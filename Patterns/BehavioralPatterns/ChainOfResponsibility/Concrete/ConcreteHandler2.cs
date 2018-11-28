using BehavioralPatterns.ChainOfResponsibility.Abstract;

namespace BehavioralPatterns.ChainOfResponsibility.Concrete
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int condition)
        {
            if (condition == 2)
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