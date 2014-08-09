using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MO
{
    public interface I_BlogUserRepo : I_BaseRepo<MD.BlogUser>
    {
        MD.BlogUser GetBlogger(string username, string password);
    }
}
