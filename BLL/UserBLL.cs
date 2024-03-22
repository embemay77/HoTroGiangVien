using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class UserBLL 
    {
        private UserAccess userAccess=new UserAccess();
        public User getAccByID(int id)
        {
            return userAccess.getAccByID(id) ;
        }
    }
}
