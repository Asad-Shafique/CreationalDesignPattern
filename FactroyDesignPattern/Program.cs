using System;

namespace FactroyDesignPattern
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("API URL "+APIConstanct.API_BASE_URL);
            
            Console.WriteLine("Hello World!");
            Environment env = new EnvironmentFactory().getEnvironment();
            string envType = env.getBaseUrl();
            Console.WriteLine(envType);
            Console.WriteLine("Example of non abstract method " +env.getBusinessFigureUrl());
        }
    }

}
