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

            Console.WriteLine("Usage:\n\n Custom Query: SharpLDAP.exe dcname.local CUSTOM \"query\" \n\n Enumerating Domain Admins: SharpLDAP.exe dcname.local DA \n\n Enumerating Enterprise Admins: SharpLDAP.exe dcname.local EA \n\n Enumerating Organizational Units: SharpLDAP.exe dcname.local Ou \n\n Enumerating Domain Computers: SharpLDAP.exe dcname.local DC \n\n Enumerating Service Accounts: SharpLDAP.exe dcname.local SERVICE \n\n Enumerating Members of Spesific Group: SharpLDAP.exe dcname.local GroupMembers \"Group Name\"\n\nEnumerating Users: SharpLDAP.exe dcname.local Users\n\nEnumerating Computers: SharpLDAP.exe dcname.local Computers");
        }
    }
}
