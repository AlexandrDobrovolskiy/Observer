using System;
using System.Collections.Generic;
using System.Text;

namespace Decanat
{
    interface IObserver
    {
        void Update(List<Post> posts);
    }
}
