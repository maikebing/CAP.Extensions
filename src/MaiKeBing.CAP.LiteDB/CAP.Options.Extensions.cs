// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using DotNetCore.CAP;
using MaiKeBing.CAP;
using MaiKeBing.CAP.LiteDB;
using System;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class CapOptionsExtensions
    {
        public static CapOptions UseLiteDBStorage(this CapOptions options)
        {
            return options.UseLiteDBStorage(opt => opt.ConnectionString =$"{System.Reflection.Assembly.GetEntryAssembly().GetName().Name}.db");
        }
        public static CapOptions UseLiteDBStorage(this CapOptions options, string connectionString)
        {
            return options.UseLiteDBStorage(opt => opt.ConnectionString = connectionString);
        }
        public static CapOptions UseLiteDBStorage(this CapOptions options, Action<LiteDBOptions> configure)
        {
            options.RegisterExtension(new LiteDBCapOptionsExtension(configure));
            return options;
        }
    }
}