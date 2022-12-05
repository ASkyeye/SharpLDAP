using System;

namespace SharpLDAP
{
    internal class Information
    {
        public static void Banner()
        {
            var bannerText = @"
          ____  _                      _     ____    _    ____  
         / ___|| |__   __ _ _ __ _ __ | |   |  _ \  / \  |  _ \ 
         \___ \| '_ \ / _` | '__| '_ \| |   | | | |/ _ \ | |_) |
          ___) | | | | (_| | |  | |_) | |___| |_| / ___ \|  __/ 
         |____/|_| |_|\__,_|_|  | .__/|_____|____/_/   \_\_|    
                                |_|                             

                                Mert Daş @merterpreter
                                   version: v1.0
           

        ";
            Console.WriteLine(bannerText);
        }
    }
}