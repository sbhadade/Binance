﻿// ReSharper disable once CheckNamespace
namespace Binance.Client
{
    public static class TradeClientExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="symbol"></param>
        public static void Subscribe(this ITradeClient client, string symbol)
            => client.Subscribe(symbol, null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="symbol"></param>
        public static void Unsubscribe(this ITradeClient client, string symbol)
            => client.Unsubscribe(symbol, null);
    }
}