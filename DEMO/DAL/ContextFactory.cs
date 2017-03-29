using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContextFactory
    {
        public static MyDbContext GetCurrentContext()
        {
            MyDbContext _mContext = CallContext.GetData("myContext") as MyDbContext;
            if (_mContext == null)
            {
                _mContext = new MyDbContext();
                CallContext.SetData("myContext", _mContext);
            }

            return _mContext;
        }
    }
}
