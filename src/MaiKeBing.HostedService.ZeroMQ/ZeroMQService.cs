using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MaiKeBing.HostedService.ZeroMQ
{

    public class ZeroMQService : BackgroundService
    {
        private readonly NetMQSocket xsubSocket;
        private readonly NetMQSocket xpubSocket;
        private readonly ZMQOption _option;
        private readonly ILogger _logger;
        private Proxy _proxy;
        private bool disposedValue;

        public ZeroMQService(ILogger<ZeroMQService> logger, IOptions<ZMQOption> option)
        {
            _logger = logger;
            this.xsubSocket = new XSubscriberSocket();
            this.xpubSocket = new XPublisherSocket();
            this.xsubSocket = new PullSocket();
            this.xpubSocket = new PushSocket();
            _option = option.Value;
            xpubSocket.Bind(_option?.SendAddress ?? "tcp://127.0.0.1:5556");
            xsubSocket.Bind(_option?.ReceiveAddress ?? "tcp://127.0.0.1:5557");
            _proxy = new Proxy(xsubSocket, xpubSocket);
        }



        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.xsubSocket?.Dispose();
                    this.xpubSocket?.Dispose();

                }
                _proxy = null;
                disposedValue = true;
            }
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("ZeroMQService is started");
            return Task.Run(_proxy.Start);
        }
    }

}
