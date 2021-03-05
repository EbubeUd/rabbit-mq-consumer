using MassTransit;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class DummyConsumer : IConsumer<NodeModel>
    {
        public Task Consume(ConsumeContext<NodeModel> context)
        {
            // var envelope = new JsonMessageEnvelope(context, context.Message, TypeMetadataCache<NodeModel>.MessageTypeNames);

            if (context != null && context.Message != null)
            {
                var m = context.Message;
            }

            return Task.CompletedTask;

        }
    }
}
