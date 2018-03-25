using System;
using System.Collections.Generic;
using System.Text;

namespace Decanat
{
    abstract class Faculty : IObserver
    {
        protected List<Post> News= new List<Post>();

        public abstract void PostNews();

        public virtual void Update(List<Post> posts)
        {
            foreach (Post post in posts)
            {
                if (!News.Contains(post))
                {
                    News.Add(post);
                }
            }
        }
    }
}
