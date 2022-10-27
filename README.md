# Customily .NET Challenge
Congratulations for getting to this point! If you complete this task the job will be almost yours 💪  

In this callenge we'll be using the model described below:  
A `Page` has a title and can contain several `Images` and `Texts`. Each of these elements has a position (X,Y) on the page. This is an example of 3 different pages:

![alt text](https://i.imgur.com/YPJ1uKN.png)

1)This repo contains the Sample ASP.NET Framework Web Application. Clone it and write an endpoint that receives a page as a json, and stores it on a database. **Use [this postman request](https://www.postman.com/collections/6a5e200bee63b5f02f72) as a starting point.** Once you are done, the postman request should be working (returning a 2XX). 

  * All the entities you create should have a `CreatedDate` and a `ModfiedDate` field. 
  * You can use any database that you want.
  * You must use Entity Framework 6.  

  *(If you don't know how to import a collection into postman, you can check [this guide](https://learning.postman.com/docs/getting-started/importing-and-exporting-data/))*


b)Write an endpoint that receives an (X,Y) pair and returns the `Title` of the pages that have **every element** with positions >= (X,Y).  
For example, if we call the endpoint passing (3,3) with the 3 Pages listed in the image avobe, we should get "3 stacked texts" as the response

2)Connect your solution to a PG database hosted on [this Docker image](https://hub.docker.com/_/postgres) using [this ADO.NET Data provider](https://www.npgsql.org/ef6/index.html)

3)Migrate your solution to .NET 6 and run it on VS Code

Take into account that apart from the correct funcioning we'll pay special attention to the **proper application of design patterns** and the  **maintainability** of your code.  

  * Make sure to share your screen and have your camara on at all times. 
  * Googling is completley fine.  
  * You must complete the challenge using only 1 monitor.
  
You have 3 hours now. Good luck!! 🤞
