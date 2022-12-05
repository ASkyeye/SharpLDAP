using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLDAP.Enum
{
    public class DC
    {
        public static void DC1(string[] args)
        {

            DirectoryEntry de = new DirectoryEntry("LDAP://" + args[0]);
            string ldapquery = $"(&(objectCategory=computer)(userAccountControl:1.2.840.113556.1.4.803:=8192))";

            var Userlist = new List<string>();
            DirectorySearcher ds = new DirectorySearcher(de, ldapquery,
                                        new string[] { "cn" });
            ds.SizeLimit = int.MaxValue;
            ds.PageSize = int.MaxValue;
            foreach (SearchResult user in ds.FindAll())
            {
                string cn = user.Properties["cn"][0].ToString();
                Console.WriteLine(cn);
                Userlist.Add(cn);

            }
        }
    }
}