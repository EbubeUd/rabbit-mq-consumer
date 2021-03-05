using CoreLayer;
using MassTransit;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xend.Notification;

namespace ServiceLayer
{
    public class MassTransitService : IMassTransitService
    {
        IBusControl bus;

        ICustomService customService;

        public async Task InitAsync()
        {
            bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
            {
                sbc.Host("rabbitmq://localhost");

                sbc.ReceiveEndpoint("receiver_queue", ep =>
                {

                    //Map Consumers to this queue
                    ep.Bind("ModelLayer:NodeModel");
                    ep.Bind("Xend.Subscription.ModelLayer.ViewModels.Messaging:OutgoingMessageModel");

                    //Map the queue to the exchanges that we will be expecting message from
                    // ep.Bind<NodeModel>();
                    ep.Handler<OutgoingMessageModel>(context => {
                        customService.SendMessage(context.Message);
                        return Console.Out.WriteLineAsync($"Received: {context.Message.MerchantXendCode}");
                    });

                    // ep.Handler<NodeModel>(context =>
                    //{
                    //    customService.SendMessage(context.Message);
                    //     return Console.Out.WriteLineAsync($"Received: {context.Message.NodeName}");
                    //});


                    // ep.Handler<NewMessageModel>(context =>
                    // {
                    //     return Console.Out.WriteLineAsync($"Received: {context.Message.Email}");
                    // });
                });


            });


            await bus.StartAsync(); // This is important!



            Console.WriteLine("Press any key to exit");
        }

        public Task SendMessage()
        {
            throw new NotImplementedException();
        }
    }
}
