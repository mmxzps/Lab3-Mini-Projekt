---

<p align="center">
  <kbd>﻿My first minimal API project</kbd>
</p>

***
<BR>

# <div align="center">💡Call commands to interact with the API</div>

## 🔷Person calls

>**➡️Add new person**
><BR>
>🔸*Use the endpoint "/person"*
><BR>
>🔸*E.G. → **POST**: http://localhost:5136/person*
>>**Input:**
>><BR> 
>>![addperson](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/6e095ebb-b242-4f15-abb6-1863ab3172ef)
>><BR>
>>
>>**Output:**
>><BR> 
>>![201Created](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/8e4faa12-a855-4ff6-bbf6-3f965761838d)
>>
><BR> 

>**➡️Show all persons**
> <BR>
>🔸*Use the endpoint "/person/persons/"*
><br>
>🔸*E.G. → **GET**: http://localhost:5136/person/persons/*
>>
>>**Output:**
>><BR> 
>> ![ShowAllPersons](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/797fb8c6-f0ae-42ee-93a4-9d88a011e854)
>
><BR>
>

>**➡️Show all information of one person**
><BR>
>🔸*Use the endpoint "/person/person-id"*
><BR>
>🔸*E.G. → **GET**: http://localhost:5136/person/1*
>>
>>**Output:**
>><BR> 
>>![ShowOnePerson](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/33d874da-6a70-4b43-953a-1a7cdb149dc4)
>
><BR>
>

>**➡️Add interest to one person**
> <BR>
>🔸*Use the endpoint "/person/person-id/interest"*
><br>
>🔸*E.G. → **POST**: http://localhost:5136/person/1/interest*
>>**Input:**
>><BR> 
>>![AddInterestToOnePerson](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/16c78d35-ecd2-43be-bc21-89ab8f7097b7)
>><BR>
>>
>>**Output:**
>><BR> 
>>![201Created](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/8e4faa12-a855-4ff6-bbf6-3f965761838d)
>>
><BR> 

>**➡️Connect person to one interest**
> <BR>
>🔸*Use the endpoint "/person/person-id/interests/interest-id"*
><br>
>🔸*E.G. → **POST**: http://localhost:5136/person/1/interests/1*
> <BR>
> <BR>
>> 
>>**Output:**
>><BR> 
>>![200OK](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/67421b35-68a4-44f3-913c-56f82dfa4959)
>>
><BR> 

>**➡️Show all interests connected to one person**
> <BR>
>🔸*Use the endpoint "/person/person-id/interests"*
><br>
>🔸*E.G. → **GET**: http://localhost:5136/person/1/interests*
>>
>>**Output:**
>><BR> 
>>![ShowAllInterestOfOnePerson](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/ab8be628-4ab6-4f8a-8221-5d08524cd8ca)
>>
><BR> 

>**➡️Add WebLinks to one person and their interest**
> <BR>
>🔸*Use the endpoint "/person/person-id/interest-id/interest-web-link"*
><br>
>🔸*E.G. → **POST**: http://localhost:5136/person/person-id/interest-id/interest-web-link*
>>**Input:**
>><BR> 
>>![AddWebLinkToPersonAndInterest](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/f9c8dc44-589e-4fc8-8aec-f212fd0e98f8)
>><BR>
>>
>>**Output:**
>><BR> 
>>![201Created](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/8e4faa12-a855-4ff6-bbf6-3f965761838d)
>
><BR> 

>**➡️Show all WebLinks connected to one person**
> <BR>
>🔸*Use the endpoint "/person/person-id/interest-web-link/links"*
><br>
>🔸*E.G. → **GET**: http://localhost:5136/person/person-id/interest-web-link/links*
>>
>>**Output:**
>><BR> 
>>![ShowAllWebLinksOfOnePerson](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/5ea9b2e9-9105-47c4-99ee-3a546a01c92c)
>>
><BR> 
><BR> 

## 🔷Interest calls

>**➡️Create new Interest**
><BR>
>🔸*Use the endpoint "/interest"*
><BR>
>🔸*E.G. → **POST**: http://localhost:5136/interest*
>>**Input:**
>><BR> 
>>![create-interest](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/5637a7fb-1a46-4065-afe9-4a7fa007f12d)
>><BR>
>>
>>**Output:**
>><BR> 
>>![201Created](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/8e4faa12-a855-4ff6-bbf6-3f965761838d)
>>
><BR> 

>**➡️Show all Interest**
> <BR>
>🔸*Use the endpoint "/interests"*
><br>
>🔸*E.G. → **GET**: http://localhost:5136/interests*
>>**Output:**
>><BR>
>>
>>![ShowAllInterests](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/d47034f8-2b66-4977-9807-733499e24dc5)
>>
><BR> 
><BR> 

## 🔷WebLink calls
>**➡️Show all WebLinks**
> <BR>
>🔸*Use the endpoint "/interest-web-links"*
><br>
>🔸*E.G. → **GET**: http://localhost:5136/interest-web-links*
>>**Output:**
>><BR>
>>
>>![ShowAllWebLinks](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/dd786ee6-0a1b-4e71-99f3-764fb0df66ee)
>>
><BR> 
><BR>

 ## ER diagram of the database
![ER-minial-API-projekt - Sida 2](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/4655c290-1094-4c76-abf6-2640e50e3b45)
## UML diagram of the program
![UML-minial-API-projekt - Page 1](https://github.com/mmxzps/Lab3-Mini-Projekt/assets/99285003/97aa18c0-3ded-4684-a9bf-2370b74d25f6)


