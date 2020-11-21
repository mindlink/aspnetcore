// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.IO.Pipelines;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
    internal class ServiceContext
    {
        public ServiceContext(
            IKestrelTrace log,
            PipeScheduler scheduler,
            IHttpParser<Http1ParsingHandler> httpParser,
            ISystemClock systemClock,
            DateHeaderValueManager dateHeaderValueManager,
            ConnectionManager connectionManager,
            Heartbeat heartbeat,
            KestrelServerOptions serverOptions)
        {
            Log = log;
            Scheduler = scheduler;
            HttpParser = httpParser;
            SystemClock = systemClock;
            DateHeaderValueManager = dateHeaderValueManager;
            ConnectionManager = connectionManager;
            Heartbeat = heartbeat;
            ServerOptions = serverOptions;
        }

        public IKestrelTrace Log { get; }

        public PipeScheduler Scheduler { get; }

        public IHttpParser<Http1ParsingHandler> HttpParser { get; }

        public ISystemClock SystemClock { get; }

        public DateHeaderValueManager DateHeaderValueManager { get; }

        public ConnectionManager ConnectionManager { get; }

        public Heartbeat Heartbeat { get; }

        public KestrelServerOptions ServerOptions { get; }
    }
}
