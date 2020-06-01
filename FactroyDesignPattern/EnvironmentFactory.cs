using System;
using System.Collections.Generic;
using System.Text;

namespace FactroyDesignPattern
{
    class EnvironmentFactory
    {

        public Environment getEnvironment()
        {
           
            if (EnvironmentConfig.ENVIRONMENT_TYPE == "LIVE")
            {
                return  new LiveEnvironment();
            }
            else
            {
                return new DevEnvironment();
            }

         


        }
    }
}
