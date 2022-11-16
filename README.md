# SharpLDAP
SharpLDAP is a tool writting in C# that aims to do enumeration via LDAP queries

![image](https://user-images.githubusercontent.com/48562581/202248870-90ccb30f-3df0-4591-bd0f-18e86068e729.png)


## USAGE

Enumerating Domain Admins:<br>
```
SharpLDAP.exe dcname.local DA
```
Enumerating Enterprise Admins:<br>
```
SharpLDAP.exe dcname.local EA
```
Enumerating Organizational Units:<br>
```
SharpLDAP.exe dcname.local Ou
```
Enumerating Members of Spesific Group:<br>
```
SharpLDAP.exe dcname.local GroupMembers "Group Name"
```
Enumerating Users:<br>
```
SharpLDAP.exe dcname.local Users
```
Enumerating Computers:<br>
```
SharpLDAP.exe dcname.local Computers
```

![image](https://user-images.githubusercontent.com/48562581/202061112-e176ce22-894f-43bb-a049-98b39ac648c4.png)
