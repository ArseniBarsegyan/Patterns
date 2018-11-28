using BehavioralPatterns.Strategy.Abstract;

namespace BehavioralPatterns.Strategy
{
    public class Context
    {
        public IStrategy ContextStrategy { get; set; }

        public Context(IStrategy strategy)
        {
            ContextStrategy = strategy;
        }

        public void ExecuteAlgorithm()
        {
            ContextStrategy.Algorithm();
        }
    }
}