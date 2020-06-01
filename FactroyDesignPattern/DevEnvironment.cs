using System;
using System.Collections.Generic;
using System.Text;

namespace FactroyDesignPattern
{
    class DevEnvironment : Environment
    {

        public override string getBaseUrl()
        {
            return "http://dev-cybvegit.com";
        }
    }
}
