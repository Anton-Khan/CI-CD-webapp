using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CI_CD_webapp
{
    public class ViewRepository : IViewRepository
    {
        private string _greetengs;
        public ViewRepository()
        {
            LoadData("Hello");
        }

        public string getGreeting()
        {
            return _greetengs + " Denis";
        }

        public string GreetMe(string name)
        {
            return _greetengs + " " + name;
        }

        private void LoadData(string word)
        {
            _greetengs = word;
        }
    }
}
