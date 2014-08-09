using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MO
{
    public class BaseSvc
    {

        public UserRepo BusRepo;
        public I_UserRepo UserRepo;
        public I_BlogDataRepo BlogDataRepo;
        public I_MathCalc MathCalc;


        public BaseSvc() {

            BusRepo = new UserRepo();
            UserRepo = new UserRepo();
            BlogDataRepo = new BlogDataRepo();
            MathCalc = new MathCalc();


        }



    }
}
