using System;
using System.Threading;

namespace Decanat
{
    class Program
    {
        static void Main(string[] args)
        {

            Post post1  = new Post("Hitler win!", "Hello evreone today hitler win's ! dakfjsdfhsdfhasldbfjksdb bfjskj fasjkhf lashdfl khsdfh slkhflks dhflksdh lkf hsdlkfh lsdkhf ldskfhslk fhldskhf lksdhflkd", DateTime.Now);
            Post post2 = new Post("Hitler win!", "Hello evreone today hitler win's ! dakfjsdfhsdfhasldbfjksdb bfjskj fasjkhf lashdfl khsdfh slkhflks dhflksdh lkf hsdlkfh lsdkhf ldskfhslk fhldskhf lksdhflkd", DateTime.Now.AddDays(1));
            Post post3 = new Post("Hitler win!", "Hello evreone today hitler win's ! dakfjsdfhsdfhasldbfjksdb bfjskj fasjkhf lashdfl khsdfh slkhflks dhflksdh lkf hsdlkfh lsdkhf ldskfhslk fhldskhf lksdhflkd", DateTime.Now.AddDays(3));

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
