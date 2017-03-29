using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class RepositoryFactory
    {
        public static InterfaceUserRepository UserRepository { get { return new UserRepository(); } }
    }
}
