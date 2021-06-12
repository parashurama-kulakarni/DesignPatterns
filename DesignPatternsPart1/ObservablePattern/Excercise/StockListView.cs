using System;
using System.Collections.Generic;

namespace DesignPatterns.DesignPatternsPart1.ObservablePattern.Excercise
{
    public class StockListView : IObservable
    {
        private List<Stock> stocks = new List<Stock>();


        public void AddStock(Stock stock)
        {
            stocks.Add(stock); stock.AddObserver(this);
        }

        public void show()
        {
            foreach (var stock in stocks)
                Console.WriteLine(stock);
        }

        public void Update()
        {
            Console.WriteLine("StockList is refreshed..");
            show();
        }
    }
}
