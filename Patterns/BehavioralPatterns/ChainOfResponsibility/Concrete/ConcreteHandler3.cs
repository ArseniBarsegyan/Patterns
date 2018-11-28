using BehavioralPatterns.ChainOfResponsibility.Abstract;

namespace BehavioralPatterns.ChainOfResponsibility.Concrete
{
    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int condition)
        {
            if (condition == 3)
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