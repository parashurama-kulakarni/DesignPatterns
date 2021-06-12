using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.IteratorPattern.Excercise
{
    class ProductCollections
    {
        private List<Product> products = new List<Product>();

        public void Add(Product product)
        {
            products.Add(product);
        }

        public IGIterator<Product> CreateIterator() => new ListIterator(this);

        public class ListIterator : IGIterator<Product>
        {
            private int index;
            public ListIterator(ProductCollections productCollections)
            {
                this.productCollections = productCollections;
            }

            public ProductCollections productCollections { get; }

            public Product Current() => productCollections.products[index];


            public bool hasNext() => index < productCollections.products.Count;


            public void Next() => index++;
            
        }
    }
}
