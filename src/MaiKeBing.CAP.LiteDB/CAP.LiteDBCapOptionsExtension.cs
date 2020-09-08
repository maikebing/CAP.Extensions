// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using DotNetCore.CAP;
using DotNetCore.CAP.Persistence;
using MaiKeBing.CAP.LiteDB;
using Microsoft.Extensions.DependencyInjection;
using System;

// ReSharper disable once CheckNamespace
namespace MaiKeBing.CAP
{
    internal class LiteDBCapOptionsExtension : ICapOptionsExtension
    {
        private Action<LiteDBOptions> configure;

        public LiteDBCapOptionsExtension(Action<LiteDBOptions> configure)
        {
            this.configure = configure;
        }

        public void AddServices(IServiceCollection services)
        {
            services.AddSingleton<CapStorageMarkerService>();
            services.Configure(configure);
            services.AddTransient<ICapTransaction, LiteDBCapTransaction>();
            services.AddSingleton<IDataStorage, LiteDB.LiteDBStorage>();
            services.AddSingleton<IStorageInitializer, LiteDBStorageInitializer>();
        }
    }
}