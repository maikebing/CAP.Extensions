using MaiKeBing.HostedService.ZeroMQ;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Sample.ZeroMQ.InMemory;
using System;

namespace Sample.ZeroMQ.InMemory
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddZeroMQService(x =>
            {
                x.SendAddress = "tcp://127.0.0.1:5556";
                x.ReceiveAddress = "tcp://127.0.0.1:5557";
            });
            services.AddCap(x =>
            {
                x.UseInMemoryStorage();
                x.UseZeroMQ(cfg =>
                {
                    cfg.HostName = "127.0.0.1";
                    cfg.SubPort = 5556;
                    cfg.PubPort = 5557;
                    cfg.Pattern = MaiKeBing.CAP.NetMQPattern.PushPull;

                });
                x.UseDashboard();
            });
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}