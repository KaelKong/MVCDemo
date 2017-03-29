using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface InterfaceUserService:InterfaceBaseService<User>
    {
        bool Exist(string userName);
        User Find(int userID);
        User Find(string userName);
        IQueryable<User> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order);
    }
}
