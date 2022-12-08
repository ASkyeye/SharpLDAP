using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLDAP.Enum
{
    public class SPN
    {
        public static void SPN1(string[] args)
        {

            DirectoryEntry de = new DirectoryEntry("LDAP://" + args[0]);
            string ldapquery = $"(&(servicePrincipalName=*))";

            var Userlist = new List<string>();
            DirectorySearcher ds = new DirectorySearcher(de, ldapquery,
                                        new string[] { "samAccountName" });
            ds.SizeLimit = int.MaxValue;
            ds.PageSize = int.MaxValue;
            foreach (SearchResult user in ds.FindAll())
            {
                string samAccountName = user.Properties["samAccountName"][0].ToString();
                Console.WriteLine(samAccountName);
                Userlist.Add(samAccountName);

            }

        }
    }
}