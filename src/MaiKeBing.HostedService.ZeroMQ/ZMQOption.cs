using System;
using System.Collections.Generic;
using System.Text;

namespace MaiKeBing.HostedService.ZeroMQ
{
    public class ZMQOption
    {
        /// <summary>
        /// tcp://127.0.0.1:5556
        /// </summary>
        public string SendAddress { get; set; }
        /// <summary>
        /// tcp://127.0.0.1:5557
        /// </summary>
        public string ReceiveAddress { get; set; }
    }
}
