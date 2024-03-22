using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SessionManagement
    {
        public int SessionId { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public DateTime ExpirationTime { get; set; }
    }

}
