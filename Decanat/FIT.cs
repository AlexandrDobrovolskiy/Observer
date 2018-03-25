using System;
using System.Collections.Generic;
using System.Text;

namespace Decanat
{
    class FIT : Faculty
    {
        public override void PostNews()
        {
            Console.Clear();
            foreach (Post post in News)
            {
                Console.WriteLine(post);
            }
        }

    }
}
