using System;
using System.Collections.Generic;
using System.Text;

namespace FactroyDesignPattern
{
    class LiveEnvironment : Environment
    {
        
       
        public override string getBaseUrl()
        {
           
            return "http://cybvegit.com/core";
        }
        public override string getBusinessFigureUrl()
        {
            return "http://cybvegit/businessfigures";
        }
    }
}
