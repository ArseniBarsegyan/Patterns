using CreationalPatterns.AbstractFactory.Abstract.Products;

namespace CreationalPatterns.AbstractFactory.Abstract
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateAbstractProductA();
        public abstract AbstractProductB CreateAbstractProductB();
    }
}