using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MO
{
    public class BlogSvc
    {

        public I_BlogUserRepo BlogUser;
        public I_BlogDataRepo BlogData;

        public BlogSvc() {
            this.BlogUser = new BlogUserRepo();
            this.BlogData = new BlogDataRepo();

        
        }
    }
}
