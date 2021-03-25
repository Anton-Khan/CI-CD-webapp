using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CI_CD_webapp
{
    public interface IViewRepository
    {
        public string getGreeting();
        public string GreetMe(string name);

    }
}
