using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MO
{
    public class BlogSvc
    {

        public I_BlogUserRepo BlogUserRepo;
        public I_BlogDataRepo BlogData;
        public I_MathCalc MathCalc;

        public BlogSvc() {
            this.BlogUserRepo = new BlogUserRepo();
            this.BlogData = new BlogDataRepo();
            MathCalc = new MathCalc();

        
        }
    }
}
