using System;

namespace DesignPatterns.DesignPatternsPart1.ObservablePattern.Excercise
{
    public class Stock : Subject
    {
        private String symbol;
        private float price;

        public Stock(String symbol, float price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public float getPrice()
        {
            return price;
        }

        public void setPrice(float price)
        {
            this.price = price;
            NotifyObservers();
        }

        public override string ToString()
        {
            return "Stock{" +
                    "symbol='" + symbol + '\'' +
                    ", price=" + price +
                    '}';
        }
    }
}
