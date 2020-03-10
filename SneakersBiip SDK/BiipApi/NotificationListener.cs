using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;

namespace SneakersBiip.BiipApi
{
    public static  class NotificationListener
    {
        public static string ApiToken { get; set; }

        public static event BiipEventHandler NotificationReceived;

        private static HubConnection _connection;
        private static IHubProxy _hubProxy;

        public static void StartListening()
        {
            var queryString = new Dictionary<string, string>(){ {"token", ApiToken}};
            _connection = new HubConnection("https://stormaio.net/", queryString);
            _hubProxy= _connection.CreateHubProxy("BiipApi");
            _hubProxy.On<Product>("ProductUpdated", product => NotificationReceived?.Invoke(product));
            _connection.Start();
        }

        public static void StopListening()
        {
            _connection?.Dispose();
        }
    }

    public delegate void BiipEventHandler(Product product);
}
