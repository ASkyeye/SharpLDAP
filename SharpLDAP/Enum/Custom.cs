using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLDAP.Enum
{
    public class Custom
    {
        public static void Custom1(string[] args)
        {

            DirectoryEntry de = new DirectoryEntry("LDAP://" + args[0]);
            string ldapquery = args[2];

            var Computerlist = new List<string>();
            DirectorySearcher ds = new DirectorySearcher(de, ldapquery,
                                        new string[] { "samAccountName" });
            ds.SizeLimit = int.MaxValue;
            ds.PageSize = int.MaxValue;
            foreach (SearchResult user in ds.FindAll())
            {
                string name = user.Properties["samAccountName"][0].ToString();
                Console.WriteLine(name);
                Computerlist.Add(name);
            }
        }
    }
}
