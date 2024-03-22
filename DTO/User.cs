using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        public int UserId { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string SoHD { get; set; }
        public DateTime NgayHetHan { get; set; }
        public float Luong { get; set; }
    }

}
