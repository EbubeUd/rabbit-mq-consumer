using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xend.Notification;

namespace CoreLayer
{
    public interface ICustomService
    {
        void SendMessage(OutgoingMessageModel message);
    }
}
