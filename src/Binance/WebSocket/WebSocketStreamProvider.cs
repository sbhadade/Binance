﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Binance.WebSocket
{
    public sealed class WebSocketStreamProvider : IWebSocketStreamProvider
    {
        private IServiceProvider _services;

        public WebSocketStreamProvider()
        { }

        public WebSocketStreamProvider(IServiceProvider services)
        {
            Throw.IfNull(services, nameof(services));

            _services = services;
        }

        public IWebSocketStream CreateStream()
        {
            if (_services == null)
                return new BinanceWebSocketStream();

            var client = _services.GetService<IWebSocketClient>();
            var loggerFactory = _services.GetService<ILoggerFactory>();

            return new BinanceWebSocketStream(client, loggerFactory.CreateLogger<BinanceWebSocketStream>());
        }
    }
}
