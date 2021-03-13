using Broker.Models.Requests;
using Broker.Models.Responds;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Service.ModeldsDB;
using Service.SQL;
using System;
using System.Threading.Tasks;

namespace Service.Broker.Command
{
    public class PostUserConsumer : IConsumer<PostUserRequest>
    {
        public async Task Consume(ConsumeContext<PostUserRequest> context)
        {
            DbUser newUser = new DbUser()
            {
                Id = Guid.NewGuid(),
                Name = context.Message.User.Name,
                Nickname = context.Message.User.Nickname
            };

            var dbContext = new ServiceDBContext(new DbContextOptions<ServiceDBContext>());
            dbContext.Add(newUser);
            dbContext.SaveChanges();
            
            await context.RespondAsync<PostUserResponse>(new PostUserResponse()
            {
                Id = newUser.Id
            });

        }
    }
}
