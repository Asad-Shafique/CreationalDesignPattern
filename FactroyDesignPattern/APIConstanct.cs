using System;
using System.Collections.Generic;
using System.Text;

namespace FactroyDesignPattern
{
   public  class APIConstanct
    {

        public static string API_BASE_URL =  new EnvironmentFactory().getEnvironment().getBaseUrl();
    }
}
