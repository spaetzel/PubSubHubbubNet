using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PubSubHubbubNet;

namespace PubSubHubbubNetExample
{
    public partial class Subscribe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            SubscriptionRequest request = new SubscriptionRequest()
            {
                Topic = new Uri( topicUrl.Text.Trim() ),
                Hub = new Uri ( hubUrl.Text.Trim() )

            };

            HttpResponse response = request.Submit();

            subscribePanel.Visible = true;
            resultsPanel.Visible = true;

            responseCode.Text = response.StatusCode.ToString();


        }
    }
}
