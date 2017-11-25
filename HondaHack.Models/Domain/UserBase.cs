using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HondaHack.Models.Domain
{
    public class UserBase : IUserAuthData
    {
        public int Id
        {
            get;set;
        }

        public string Name
        {
            get; set;
        }

        public IEnumerable<string> Roles
        {
            get; set;
        }
    }
}
