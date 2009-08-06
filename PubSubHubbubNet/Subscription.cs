using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubSubHubbubNet
{
    public class Subscription
    {
        public enum Action { Subscribe, Unsubscribe };

        private Action _action = Action.Subscribe;

        /// <summary>
        /// The topic URL that the subscriber wishes to subscribe to. 
        /// </summary>
        public Uri Topic { get; set; }

        private string _verifyToken;
        /// <summary>
        /// A subscriber-provided opaque token that will be echoed back in the verification request to assist the subscriber in identifying which subscription request is being verified. If this is not included, no token will be included in the verification request. 
        /// If not provided, a value will be generated
        /// </summary>
        public string VerifyToken
        {
            get
            {
                if (_verifyToken.IsNullOrEmpty())
                {
                    _verifyToken = new Guid().ToString();
                }
                return _verifyToken;
            }
            set { _verifyToken = value; }
        }



        private int _leaseSeconds = 2592000;

        /// <summary>
        /// Number of seconds for which the subscriber would like to have the subscription active. Hubs SHOULD choose a default value of 30 days (2592000 seconds) if not supplied. Hubs MAY choose to respect this value or not, depending on their own policies. This parameter MAY be present for unsubscription requests and MUST be ignored by the hub in that case. 
        /// </summary>
        public int LeaseSeconds
        {
            get { return _leaseSeconds; }
            set { _leaseSeconds = value; }
        }

    }
}
