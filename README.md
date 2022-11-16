# SharpLDAP
SharpLDAP is a tool writting in C# that aims to do enumeration via LDAP queries

![image](https://user-images.githubusercontent.com/48562581/202061112-e176ce22-894f-43bb-a049-98b39ac648c4.png)

## USAGE

Enumerating Domain Admins:<br>
``
SharpLDAP.exe dcname.local DA
``
<br>
Enumerating Enterprise Admins:<br>
``
SharpLDAP.exe dcname.local EA
``
<br>
Enumerating Members of Spesific Group:<br>
``
SharpLDAP.exe dcname.local GroupMembers "Group Name"
``
<br>
Enumerating Users:<br>
``
SharpLDAP.exe dcname.local Users
``
<br>
Enumerating Computers:<br>
``
SharpLDAP.exe dcname.local Computers
``
<br>
Enumerating Organizational Units:<br>
``
SharpLDAP.exe dcname.local Ou
``
