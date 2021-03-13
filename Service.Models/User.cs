using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
    }
}
