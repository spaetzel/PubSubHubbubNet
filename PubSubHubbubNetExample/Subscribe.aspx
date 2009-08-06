<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Subscribe.aspx.cs" Inherits="PubSubHubbubNetExample.Subscribe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="subscribePanel" runat="server">
        <table>
            <tr>
            <th>Topic Url:</th><td><asp:TextBox Width="500px" runat="server" ID="topicUrl" Text="http://www.google.com/reader/public/atom/user%2F09880134018427269230%2Fstate%2Fcom.google%2Fbroadcast" /></td>
            </tr>
              <tr>
            <th>Hub Url:</th><td><asp:TextBox Width="500px" runat="server" ID="hubUrl" Text="http://pubsubhubbub.appspot.com/" /></td>
            </tr>
        </table>
        <asp:Button ID="submitButton" runat="server" onclick="submitButton_Click" 
            Text="Subscribe" />
            </asp:Panel>
            <asp:Panel ID="resultsPanel" runat="server" Visible="false">
                Recieved response code <asp:Label ID="responseCode" runat="server" />
                
                <a href="Subscribe.aspx">Subscribe another feed</a>
            </asp:Panel>
        
    </div>
    </form>
</body>
</html>
