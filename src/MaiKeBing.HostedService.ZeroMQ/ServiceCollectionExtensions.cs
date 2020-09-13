using MaiKeBing.HostedService.ZeroMQ;
using Microsoft.Extensions.Configuration;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddHostedZeroMQ(this IServiceCollection services, Action<ZMQOption> setupAction)
        {
            services.AddHostedService<ZeroMQService>();
            services.Configure(setupAction);
        }
        public static void AddHostedZeroMQ(this IServiceCollection services)
                            => services.AddHostedZeroMQ(opt =>
                                    new ZMQOption() { ReceiveAddress = "tcp://127.0.0.1:5557", SendAddress = "tcp://127.0.0.1:5556" }
                                    );

        public static void AddHostedZeroMQ(this IServiceCollection services, IConfiguration configuration)
                            => services.AddHostedZeroMQ(opt => configuration.GetSection("ZMQOption").Get<ZMQOption>());
    }
}