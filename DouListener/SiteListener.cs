using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DouListener
{
    class SiteListener
    {
        public string SiteAddress { get; set; } = "dou.ua";
        public int RequestCount { get; set; } = 10;
        public void Listen(ILogger logger)
        {
            foreach(var i in Enumerable.Range(0, RequestCount))
            {
                try
                {
                    var ping = new System.Net.NetworkInformation.Ping();

                    var result = ping.Send(SiteAddress);
                    logger.Log($"{result?.Status.ToString()} {DateTime.Now}");
                }
                catch (Exception e)
                {
                    logger.Log($"{e.Message} {DateTime.Now}");
                }
                finally
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
