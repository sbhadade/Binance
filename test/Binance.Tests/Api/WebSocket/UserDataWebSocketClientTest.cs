﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Binance.Api;
using Binance.WebSocket;
using Moq;
using Xunit;

namespace Binance.Tests.Api.WebSocket
{
    public class UserDataWebSocketClientTest
    {
        [Fact]
        public async Task StreamThrows()
        {
            var client = new SingleUserDataWebSocketClient(new Mock<IBinanceApi>().Object, new WebSocketStreamProvider());

            using (var cts = new CancellationTokenSource())
            {
                await Assert.ThrowsAsync<ArgumentNullException>("user", () => client.SubscribeAndStreamAsync(null, cts.Token));
            }
        }
    }
}
