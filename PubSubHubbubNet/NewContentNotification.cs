using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace PubSubHubbubNet
{
    public class NewContentNotification
    {

        public NewContentNotification(HttpRequest request)
        {
            _mode = request.Form["hub.mode"];
            _topic = new Uri( request.Form["hub.url"] );
        }

        private string _mode;

        public string Mode
        {
            get { return _mode; }
        }

        private Uri _topic;

        public Uri Topic
        {
            get { return _topic; }
        }
    }
}
