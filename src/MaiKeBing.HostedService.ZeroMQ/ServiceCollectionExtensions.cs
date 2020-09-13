using MaiKeBing.HostedService.ZeroMQ;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static  void AddZeroMQService(this IServiceCollection services, Action<ZMQOption> setupAction)
        {
            services.AddHostedService<ZeroMQService>();
            services.Configure(setupAction);
        }
    }
}