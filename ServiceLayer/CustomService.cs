using CoreLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xend.Notification;

namespace ServiceLayer
{
    public class CustomService : ICustomService
    {
        public void SendMessage(OutgoingMessageModel message)
        {
            string name = message.Message;
        }
    }
}
