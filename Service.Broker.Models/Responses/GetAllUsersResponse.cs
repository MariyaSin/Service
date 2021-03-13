using Service.ModeldsDB;
using Service.Models;
using System.Collections.Generic;

namespace Broker.Models.Responses
{
    public class GetAllUsersResponse
    {
        public List<DbUser> Users { get; set; }
    }
}
