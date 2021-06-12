
using System;
namespace DesignPatterns.DesignPatternsPart1.IteratorPattern.Excercise
{
    public class Product
    {
        private int id;
        private String name;

        public Product(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public override String ToString()
        {
            return "Product{" +
                    "id=" + id +
                    ", name='" + name + '\'' +
                    '}';
        }
    }
}
