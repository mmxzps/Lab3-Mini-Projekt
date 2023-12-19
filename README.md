
---

<p align="center">
  <kbd>﻿My first minimal API project</kbd>
</p>

***
<BR>
<BR>
<BR>

## 💡Call commands to interact with the API

### 🔷Person calls

> 
>
>**Show all persons**
> <BR>
>🔸*Use the endpoint "/Person"*
><br>
>🔸*E.G. → **GET**: http://localhost:5136/Person*
><BR>
>**Show one person**
><BR>
>🔸*Use the endpoint "/Person/PersonId"*
><BR>
>🔸*E.G. → **GET**: http://localhost:5136/Person/1003*
><BR>
>**Add new person**
><BR>
>🔸*Use the endpoint "/Person"*
><BR>
>🔸*E.G. → **POST**: http://localhost:5136/Person*
>```json
> {
>	"firstname":"Jon",
>	"lastname":"Doe",
>	"PhoneNumber": "0739097412"
>}
>```
><BR>
### 🔷Interest calls
>**Show all Interest**
> <BR>
>🔸*Use the endpoint "/Interest"*
><br>
>🔸*E.G. → **GET**: http://localhost:5136/Interest*
><BR>
>**Show all interests connected to one person**
> <BR>
>🔸*Use the endpoint "/Interest/Interests/PersonId"*
><br>
>🔸*E.G. → **GET**: http://localhost:5136/Interest/interests/1003*
><BR>
>**Add interest to one person**
> <BR>
>🔸*Use the endpoint "/Interest/PersonId"*
><br>
>🔸*E.G. → **POST**: http://localhost:5136/Interest/1003*
>```json
>{
>	"interestname": "C#",
>	"InterestDescription":"C# is a programming language developed by Microsoft that runs on the .NET Framework."
>}
>```
><BR>

### 🔷WebLink calls
>**Show all WebLinks**
> <BR>
>🔸*Use the endpoint "/InterestWebLink"*
><br>
>🔸*E.G. → **GET**: http://localhost:5136/InterestWebLink*
><BR>
>**Show all WebLinks connected to one person**
> <BR>
>🔸*Use the endpoint "/InterestWebLink/links/PersonId"*
><br>
>🔸*E.G. → **GET**: http://localhost:5136/InterestWebLink/links/1003*
><BR>
>**Add WebLinks to one person and their interest**
> <BR>
>🔸*Use the endpoint "/InterestWebLink/PersonId/InterestId"*
><br>
>🔸*E.G. → **POST**: http://localhost:5136/InterestWebLink/1003/1015*
>```json
>{
>	"link":"https://www.w3schools.com/cs/index.php",
>	"PersonId":1003,
>	"interestId":1015
>}
>```
><BR>

 ## ER diagram of the database
![ER-minial-API-projekt - Sida 2](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/4655c290-1094-4c76-abf6-2640e50e3b45)
## UML diagram of the program
![UML-minial-API-projekt - Page 1](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/97aa18c0-3ded-4684-a9bf-2370b74d25f6)


