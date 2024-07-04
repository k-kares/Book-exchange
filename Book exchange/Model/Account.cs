using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_exchange.Model
{
    public class Account
    {
        public int IDAccount { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
    }
}
