using System;
using System.Collections.Generic;
using System.Text;

namespace FactroyDesignPattern
{
    public abstract class Environment
    {
        private string baseUrl;
        public abstract string getBaseUrl();
        

    }
}
