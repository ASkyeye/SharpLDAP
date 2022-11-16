# SharpLDAP
SharpLDAP is a tool writting in C# that aims to do enumeration via LDAP queries

![image](https://user-images.githubusercontent.com/48562581/202061112-e176ce22-894f-43bb-a049-98b39ac648c4.png)

## USAGE

Custom Querying:<br><br>
![image](https://user-images.githubusercontent.com/48562581/202072521-18826f16-ce6a-46f0-bc25-62e56ddff289.png)

SharpLDAP.exe dcname.local Custom query<br>
```
Example 1 Retrieve Users: SharpLDAP.exe redlab.local Custom (objectCategory=user)(objectClass=user))
```
<br>

```
Example 2 Computers: SharpLDAP.exe redlab.local Custom (objectClass=computer))
```

```
Example 3 Find Computer by name: SharpLDAP.exe redlab.local Custom (objectclass=computer)(name=*red*))
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
