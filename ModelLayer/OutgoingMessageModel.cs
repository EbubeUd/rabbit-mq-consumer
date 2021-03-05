using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xend.Notification
{
    public class OutgoingMessageModel
    {

        /// <summary>
        /// The Xend Code of the Merchant
        /// </summary>
        public string MerchantXendCode { get; set; }
        /// <summary>
        /// The Message Type
        /// </summary>
        public List<int> MessageType { get; set; }
        /// <summary>
        /// The Purpose determines the template that will be used to send the message
        /// </summary>
        public string Purpose { get; set; }
        /// <summary>
        /// The Source of the Message: eg Xend Subscription
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// The Subject is only going to be required if an email is being sent
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// The Message that will be sent to the recipient. This will be used when sending an in ap Notification
        /// </summary>
        public string Message { get; set; }
    }
}
