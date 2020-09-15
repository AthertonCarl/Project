------
### YOUR PET PORTFOLIO
------
### TABLE OF CONTENTS
[DESCRIPTION](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#description)  
[ERD](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#erd)  
[WIREFRAMES](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#wireframes)  
[USER STORIES](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#user-stories)  
[USE-CASES](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#use-cases)  
[USE-CASE DIAGRAM](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#use-case-diagram)  
[REQUIREMENTS](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#requirements)  
[TEST TABLE](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#test-table)  
[MODELS](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#models)

------
### DESCRIPTION
When I was asked to think of a web application that could improve or make something simpler.  I thought of creating an application that would make it easier for my local cat rescue to keep track of the cats on property and allow them to market them through their web page to potential adopters. This application would essentially benefit any animal rescue not just my local cat rescue.  

This web application will be a tool to help the rescue build their “library of cats”.  The library will organize and hold a variety of information available for adoption. To assist the rescue the application will have section where the information would be entered and allow for edits to be completed. The types information that will be able to be captured will be imagery and text.  Each cat at the rescue will have an image or images, name, age, sex, breed, coloring, description, and recommendation on the living conditions that would be best suited. The rescue would also be able to track medical and microchip information to provide to adopters.

The rescue would be able to all the information kept on the cats to allow potential adopters to search for their perfect pet. Potential adopters would be able to search using the following criteria color, breed, age, sex, or demeanor.  Once adopters find a cat that they are interested in, they would be able to complete an application capturing their information and the animal of interest. Their information would be provided to the rescue to complete their screening process.  

[Return To Top](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#your-pet-portfolio)

------
### ERD 

![ERD Design](https://github.com/AthertonCarl/Project/blob/master/Project%20ERD.png)  

[Return To Top](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#your-pet-portfolio)

------
### WIREFRAMES

![Admin Logon](https://github.com/AthertonCarl/Project/blob/master/Admin%20Logon.png)
![Admin Input](https://github.com/AthertonCarl/Project/blob/master/Admin%20Input.png)
![Adoption Display](https://github.com/AthertonCarl/Project/blob/master/Adoption%20Display.png)  

[Return To Top](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#your-pet-portfolio)

------
### USER STORIES

As an Administrator.  
I need to login to the application.  
So that I can update and add new animals.

As an Employee or Volunteer.  
I need to be able to review potential adopter requests.  
So that I can connect animals a forever home.

As a potential adopter.  
I need to be able to search for animals availabe for adoption.  
So that I can see all possible animals available for adoption.  

[Return To Top](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#your-pet-portfolio)

------
### USE-CASES

Given an administrator or user needs to update or add records  
When updates or records need to be added  
Then should be able to log on to update or add records.

Given an administrator needs to create log on accounts to assist in managing records  
When a new account is required  
Then a new account should be created and notify user when available.

Given a customer or potential client is looking for animals available for adoption  
When search criteria is entered in about the animal type they are looking for  
Then should return animals meeting search criteria that are available for adoption.  

Given an administrator or user see an adoptoion aplication has been completed  
When a customer or potential client have submitted an adoption applicaton  
Then should be able to review application and respond to customer or potential client.  

[Return To Top](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#your-pet-portfolio)

------
### USE-CASE DIAGRAM

![Your Pet Portfolio](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/Your%20Pet%20Portfolio.png)  

[Return To Top](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#your-pet-portfolio)

------
### REQUIREMENTS

|ID|Requirement|Test   Method|
|:---:|---|:---:|
|1.0|The application shall have a logon screen that allows administrators and users to enter in a username and password.|Inspection|
|1.1|The application shall have a submit button that changes color when clicked to logon.|Inspection|
|1.2|The application shall allow administrators to create user accounts for employees and volunteers.|Test|
|2.0|The application shall allow administrators and employees to add and update records.|Inspection|
|3.0|The application shall have search criteria allowing clients to search for animals avialable for adoption.|Inspection|
|3.1|The application shall allow clients to view animals available for adoption.|Inspection|
|3.2|The application shall allow clients to fill out adoption applications and submit them to the rescue.|Inspection|
|3.3|The application shall auto generate an email thanking the clients for their interest in adopting and that they will be contated once their application has been reviewed.|Test|
|4.0|The application shall notify administrators and employees when a new adoption application has been submitted.|Test| 
|4.1|The application shall allow the administrators and employees to view applications submitted to the rescue.|Test|

[Return To Top](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#your-pet-portfolio)

-------
### TEST TABLE

|Test   ID|Req   ID|Test Procedure |Current  Status|
|:---:|:---:|---|:---:|
|T1|1.0, 1.1, 1.2|Check for logon screen and if it takes username and password information and the submit button should change color when clicked. Administrators should be able to log in to their account select the create new account link and enter in new user information|Not Tested|
|T2|2.0|Check to see that animal information is able to be updated or new new animals are able to be added.|Not Tested|
|T3|3.0, 3.1|A client should be able to enter search criteria and view the results of their search.|Not Tested|
|T4|3.2|A client should be able to fill out and submit an adoption application to the rescue.|Not Tested|
|T5|3.3, 4.0, 4.1|When a client submits an adoption application it should generate an auto response to the clients email address and notify employees an adoption has been submitted to be reviewed.|Not Tested|
 

[Return To Top](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#your-pet-portfolio)

------
### ProtoType

[ProtoType From 29Aug2020 ](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/Prototype2020-09-01)
![Your Pet Portfolio](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/Prototype2020-09-01/LogInPrototype.png)
![Your Pet Portfolio](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/Prototype2020-09-01/AdminDisplayPrototype.png)
![Your Pet Portfolio](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/Prototype2020-09-01/AdminDisplayPrototype.png)  

[Return To Top](https://github.com/AthertonCarl/YourPetPortfolio/blob/master/README.md#your-pet-portfolio)
