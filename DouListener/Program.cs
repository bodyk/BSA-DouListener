using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace DouListener
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninject.IKernel kernal = new StandardKernel();
            kernal.Bind<ILogger>().To<CombinedLogger>();
            var listener = kernal.Get<SiteListener>();
            listener.Listen();
        }
    }
}
