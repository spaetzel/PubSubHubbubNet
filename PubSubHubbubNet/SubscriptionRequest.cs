using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace PubSubHubbubNet
{
    public class SubscriptionRequest : Subscription
    {
       

        /// <summary>
        /// If you wish to subscribe or unsubscribe from the topic
        /// </summary>
        public Action Action { get; set; }

        /// <summary>
        /// The subscriber's callback URL. This URL should not contain query-string parameters or an anchor fragment. 
        /// </summary>
        public Uri Callback { get; set; }

       




        /// <summary>
        /// Submits the subscription request to the hub. Returns the actual http response from the hub
        /// On success an http 204 code will be returned
        /// </summary>
        /// <returns></returns>
        public System.Web.HttpResponse Submit()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Handles a subscription verification request. Returns the actual subscription that was created on the hub.
        /// The LeaseSeconds may be different than the requested lease seconds.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Subscription Verify(HttpRequest request)
        {
            throw new NotImplementedException();
        }



    }
}
