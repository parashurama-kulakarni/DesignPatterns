using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.ObservablePattern.Excercise
{
    public class Demo
    {
        static void Main(string[] args)
        {
            var statusBar = new StatusBar();
            var stockListView = new StockListView();
            
            var stock1 = new Stock("Rs",100);
            var stock2 = new Stock("Rs",200);
            var stock3= new Stock("Rs",300);

            statusBar.AddStock(stock1);
            statusBar.AddStock(stock2);

            stockListView.AddStock(stock1);
            stockListView.AddStock(stock2);
            stockListView.AddStock(stock3);

            //stock2.setPrice(500);

            stock3.setPrice(400);

            Console.ReadKey();
        }
    }
}
