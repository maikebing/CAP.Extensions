using DotNetCore.CAP;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CapOptionsExts
    {
        public static CapOptions UseRabbitMQ(this CapOptions options, Uri url)
        {
            return options.UseRabbitMQ(opt => opt.ConnectionFactoryOptions = factory => factory.Uri = url);
        }
    }
}
