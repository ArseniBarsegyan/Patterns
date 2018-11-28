namespace BehavioralPatterns.ChainOfResponsibility.Abstract
{
    public abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int condition);
    }
}