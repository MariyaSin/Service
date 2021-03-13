using Broker.Models.Responds;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Broker.Models.Requests;
using Broker.Models.Responses;
using Service.Models;
using Service.SQL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Service.ModeldsDB;

namespace Service.Broker.Command
{
    public class GetAllUsersConsumer : IConsumer<GetAllUsersRequest>
    {

        public async Task Consume(ConsumeContext<GetAllUsersRequest> context)
        {
            var dbContext = new ServiceDBContext(new DbContextOptions<ServiceDBContext>());
            GetAllUsersResponse users = new GetAllUsersResponse();
            users.Users = await dbContext.UsersService.ToListAsync();
            await context.RespondAsync<GetAllUsersResponse>(
                new GetAllUsersResponse()
                { 
                    Users = await dbContext.UsersService.ToListAsync()
                });
        }
    }
}
