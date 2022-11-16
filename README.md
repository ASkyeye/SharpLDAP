# SharpLDAP
SharpLDAP is a tool writting in C# that aims to do enumeration via LDAP queries

![image](https://user-images.githubusercontent.com/48562581/202061112-e176ce22-894f-43bb-a049-98b39ac648c4.png)

## USAGE

Custom Querying:<br><br>
![image](https://user-images.githubusercontent.com/48562581/202072521-18826f16-ce6a-46f0-bc25-62e56ddff289.png)

SharpLDAP.exe dcname.local Custom query<br>
```
Example1: SharpLDAP.exe redlab.local Custom (objectCategory=user)(objectClass=user))
```
<br>

```
Example2: SharpLDAP.exe redlab.local Custom (objectClass=computer))
```
<br>
<br>

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
Enumerating Users:<br>
``
SharpLDAP.exe dcname.local Users
``
<br>
Enumerating Computers:<br>
``
SharpLDAP.exe dcname.local Computers
``
