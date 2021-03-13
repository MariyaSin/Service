using Broker.Models;
using Broker.Models.Requests;
using Broker.Models.Responds;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Broker.Models.consumer
{
    public class UserConsumer : IConsumer<PostUserRequest>
    {
        public async Task Consume(ConsumeContext<PostUserRequest> context)
        {
            await context.RespondAsync<PostUserResponse>(new PostUserResponse()
            {
                Id = Guid.NewGuid()
            });

        }
    }
}
