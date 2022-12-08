using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLDAP.Enum
{
    public class Ou
    {

        public static void Users1(string[] args)
        {
            DirectoryEntry de = new DirectoryEntry("LDAP://" + args[0]);
            {
                DirectorySearcher dsFindOUs = new DirectorySearcher(de);

                dsFindOUs.Filter = "(objectClass=organizationalUnit)";

                dsFindOUs.SearchScope = SearchScope.Subtree;

                dsFindOUs.PropertiesToLoad.Add("name");

                foreach (SearchResult result in dsFindOUs.FindAll())
                {
                    Console.WriteLine("Found: " +
                    result.Properties["name"][0].ToString());

                }
            }
        }
    }
}

