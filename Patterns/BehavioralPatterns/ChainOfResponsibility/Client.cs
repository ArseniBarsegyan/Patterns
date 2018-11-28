using BehavioralPatterns.ChainOfResponsibility.Abstract;
using BehavioralPatterns.ChainOfResponsibility.Concrete;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class Client
    {
        void Main()
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.Successor = h2;
            h2.Successor = h3;
            h1.HandleRequest(2);
        }
    }
}