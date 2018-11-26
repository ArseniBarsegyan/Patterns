using CreationalPatterns.AbstractFactory.Abstract.Products;

namespace CreationalPatterns.AbstractFactory
{
    public class FactoryConsumer
    {
        private readonly AbstractProductA _productA;
        private readonly AbstractProductB _productB;

        public FactoryConsumer(Abstract.AbstractFactory factory)
        {
            _productA = factory.CreateAbstractProductA();
            _productB = factory.CreateAbstractProductB();
        }
    }
}