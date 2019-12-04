using System;
using System.Threading;

namespace Decanat
{
    class Program
    {
        static void Main(string[] args)
        {

            Post post1  = new Post(
                "Yves Saint-Laurent, was a French fashion designer who, in 1961, founded his eponymous fashion label. He is regarded as being among the foremost fashion designers in the twentieth century.[2] In 1985, Caroline Rennolds Milbank wrote, \"The most consistently celebrated and influential designer of the past twenty-five years, Yves Saint Laurent can be credited with both spurring the couture's rise from its 1960s ashes and with finally rendering ready-to-wear reputable.",
                DateTime.Now
            );

            Post post2  = new Post(
                "Yves Saint-Laurent, was a French fashion designer who, in 1961, founded his eponymous fashion label. He is regarded as being among the foremost fashion designers in the twentieth century.[2] In 1985, Caroline Rennolds Milbank wrote, \"The most consistently celebrated and influential designer of the past twenty-five years, Yves Saint Laurent can be credited with both spurring the couture's rise from its 1960s ashes and with finally rendering ready-to-wear reputable.",
                DateTime.Now
            );

            Post post3  = new Post(
                "Yves Saint-Laurent, was a French fashion designer who, in 1961, founded his eponymous fashion label. He is regarded as being among the foremost fashion designers in the twentieth century.[2] In 1985, Caroline Rennolds Milbank wrote, \"The most consistently celebrated and influential designer of the past twenty-five years, Yves Saint Laurent can be credited with both spurring the couture's rise from its 1960s ashes and with finally rendering ready-to-wear reputable.",
                DateTime.Now
            );

            Faculty FIT = new FIT();
            Decanat KNUDecanat = new Decanat();

            KNUDecanat.RegisterObserver(FIT);
            KNUDecanat.News.Add(post1);
            KNUDecanat.NotifyObservers();

            FIT.PostNews();
            Thread.Sleep(3000);

            KNUDecanat.News.Add(post2);
            KNUDecanat.NotifyObservers();

            FIT.PostNews();
            Thread.Sleep(3000);

            KNUDecanat.News.Add(post3);
            KNUDecanat.NotifyObservers();

            FIT.PostNews();
            Thread.Sleep(3000);

            Console.ReadKey();
        }
    }
}
