using CreationalPatterns.AbstractFactory.Abstract.Products;
using CreationalPatterns.AbstractFactory.Concrete.Products;

namespace CreationalPatterns.AbstractFactory.Concrete
{
    public class ConcreteFactory : Abstract.AbstractFactory
    {
        public override AbstractProductA CreateAbstractProductA()
        {
            return new ConcreteProductA();
        }

        public override AbstractProductB CreateAbstractProductB()
        {
            return new ConcreteProductB();
        }
    }
}