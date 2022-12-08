using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLDAP.Enum
{
    public class Computers
    {
        public static void Computers1(string[] args)
        {

            DirectoryEntry de = new DirectoryEntry("LDAP://" + args[0]);
            string ldapquery = $"(&(objectClass=computer))";

            var Computerlist = new List<string>();
            DirectorySearcher ds = new DirectorySearcher(de, ldapquery,
                                        new string[] { "cn" });
            ds.SizeLimit = int.MaxValue;
            ds.PageSize = int.MaxValue;
            foreach (SearchResult user in ds.FindAll())
            {
                string name = user.Properties["cn"][0].ToString();
                Console.WriteLine(name);
                Computerlist.Add(name);
            }
        }
    }
}
