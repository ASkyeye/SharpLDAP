using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLDAP.Enum
{
    public class Help
    {
        public static void Help1()
        {

            Console.WriteLine("\nUsage:\n\n Enumerate Users: SharpLDAP.exe dcname.local Users \n\n Enumerate Computers: SharpLDAP.exe dcname.local Computers");
        }
    }
}
