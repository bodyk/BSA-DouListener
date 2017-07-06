using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouListener
{
    class Program
    {
        static void Main(string[] args)
        {
            SiteListener listener = new SiteListener();
            listener.Listen(new CombinedLogger());
        }
    }
}
