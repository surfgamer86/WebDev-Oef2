using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDev_Oef2_Domain.Business
{
    public class Bc
    {
        Persistence _persistence = new Persistence();
        public int SaveUserRegistration(User user)
        {
            return _persistence.AddUser(user);
        }
    }
}
