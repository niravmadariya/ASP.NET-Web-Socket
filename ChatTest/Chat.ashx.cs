using Microsoft.Web.WebSockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatTest
{
    /// <summary>
    /// Summary description for Chat
    /// </summary>
    public class Chat : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.IsWebSocketRequest)
                context.AcceptWebSocketRequest(new WebSocketChatHandler());
        }

        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}