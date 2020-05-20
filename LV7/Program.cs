using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class Program
    {
        double[] array = new double[] { 4.5, 2.43, 6.4, 7.5, 5.6, 7.4, 3.8, 8.3, 9.3, 2.92 };
        NumberSequence numberSequence = new NumberSequence(array);

        SortStrategy seqSort = new SequentialSort();
        SortStrategy bubbleSort = new BubbleSort();
        SortStrategy combSort = new CombSort();

        numberSequence.SetSortStrategy(seqSort);
        numberSequence.Sort();
        Console.WriteLine(numberSequence.ToString());

        numberSequence.SetSortStrategy(bubbleSort);
        numberSequence.Sort();
        Console.WriteLine(numberSequence.ToString());

        numberSequence.SetSortStrategy(combSort);
        numberSequence.Sort();
        Console.WriteLine(numberSequence.ToString());

        double numberToSearch = 3.6;
        LinearSearch linearSearch = new LinearSearch(numberToSearch);
        numberSequence.SetSearchStrategy(linearSearch);

        if(numberSequence.Search())
        {
            Console.WriteLine(numberToSearch + " is found.");
        }
        else 
        { 
            Console.WriteLine(numberToSearch + " is not found."); 
        }
        /*
        SystemDataProvider provider = new SystemDataProvider();
        FileLogger fileLoggerOne = new FileLogger("data1.txt");
        ConsoleLogger consoleLogger = new ConsoleLogger();

        provider.Attach(fileLoggerOne);
        provider.Attach(consoleLogger);

        while(1 == 1)
        {
            provider.GetAvailableRAM();
            provider.GetCPULoad();
            System.Threading.Thread.Sleep(1000);
        }*/
        
        SystemDataProvider provider = new SystemDataProvider();
        FileLogger fileLoggerTwo = new FileLogger("data2.txt");
        ConsoleLogger consoleLogger = new ConsoleLogger();

        provider.Attach(fileLoggerTwo);
        provider.Attach(consoleLogger);

        while(1 == 1)
        {
            provider.GetAvailableRAM();
            provider.GetCPULoad();
            System.Threading.Thread.Sleep(1000);
        }

        BuyVisitor buyVisitor = new BuyVisitor();
        DVD dvd = new DVD("The Godfather", DVDType.MOVIE, 19.99);
        VHS vhs = new VHS("Beauty and the Beast", 16.49);
        Book book = new Book("The Stranger", 13.99);

        Console.WriteLine(dvd.Accept(buyVisitor) + " DVD");
        Console.WriteLine(vhs.Accept(buyVisitor) + " VHS");
        Console.WriteLine(book.Accept(buyVisitor) + " book");
        
        Visitor visitor = new Visitor();
        Console.WriteLine(dvd.Accept(visitor) + " DVD");
        Console.WriteLine(vhs.Accept(visitor) + " VHS");
        Console.WriteLine(book.Accept(visitor) + " book");
    }
}
