using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace PubSubHubbubNet
{
    public class PublishNotification
    {
        /// <summary>
        /// The URI of the topic that has been updated
        /// </summary>
        public Uri Topic { get; set; }


        /// <summary>
        /// The URI of the hub to notify
        /// </summary>
        public Uri Hub { get; set; }

        private int _timeOut = 10;

        public int TimeOut
        {
            get { return _timeOut; }
            set { _timeOut = value; }
        }

        /// <summary>
        /// Notifies the hub about the updatel
        /// </summary>
        public void Submit()
        {
            var ping = new Ping();

            string hostName = Hub.AbsoluteUri;
            string payload = Topic.AbsoluteUri;
            ping.SendAsync(hostName, TimeOut, payload.ToCharArray());
                
            
        }


    }
}
