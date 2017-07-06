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
        public int RequestCount { get; set; } = 100;

        private readonly ILogger _logger;

        public SiteListener(ILogger logger)
        {
            _logger = logger;
        }
        public void Listen()
        {
            foreach(var i in Enumerable.Range(0, RequestCount))
            {
                try
                {
                    var ping = new System.Net.NetworkInformation.Ping();
                    var result = ping.Send(SiteAddress);
                    _logger.Log($"{result?.Status.ToString()} {DateTime.Now}");
                }
                catch (Exception e)
                {
                    _logger.Log($"{e.Message} {DateTime.Now}");
                }
                finally
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
