# Description

## Introduction
Create an application to demonstrate your skills. It does not need to be perfect, just a high level example of what you like to work with.
We will focus on the good that is made in the example you provide.

*NB* Focus on the things you are already familiar with, to avoid spending too much time on investigations. 
Approximate time to spend on the task: 2-4 hours

**Environment**:
The demo should run in Visual Studio and only make use of frameworks available through NuGet.

## Guideline
Start off by forking this repository.

There is no requirement to the type of demo you choose to make. An example could be a
website where it is possible to enter a series of letters that when send to a web service will be manipulated
and stored. Through the website it will also be possible to retrieve already saved data and display it.

*NB* Please focus on the SOLID principle

*NB* Please do small commits, and many commits with a simple, yet good message.


## Ideas
The folowing is a list of ideas. It does not have to be one of these exact items you create. Use this as insiration.

1) Create a selfhosted aspnetcore application with
	- NPM packages and Webpack build frontend
	- MVC or single page application within the aspnetcore hosted enviroment
		- Add a GIS map and place items on the map. 
	-It is fine to use the inbuilt IoC/DI from MS
	- Utilize aspnetcore rest and place symbols on the map collected from a sqlite db in the app_data folder.
		- Use an ORM for the db work
		
2) Create and Xamarin app with:
	- GIS map integrqated
	- Add place symbols on the map collected from a sqlite db in the assets folder
		- Use an ORM for the db work
	- Integrate the GPS and locate your position on the map.

3) Create a selfhosted console / application with:
	- Topshelf integration
	- NancyFx for resf self hosting
	- Utilize rest and and expose any data from a sqlite db in a app_data folder.
		- Use an ORM for the db work

### General concepts that could be demonstrated:
- Integration of an IoC/Di (Ninject, Windsor, Autofac, Simple, Tiny) usitilizing constructor injection.
- Communication between backend and frontend (WCF, Rest, SOAP) 
- A fundamental understanding of how to make and organize UI code. Any pattern (MVC, MVVM etc.) and framework (ASP .NET, Xamarin, WPF) can be used
- Data storage on the backend. E.g. Serialization/Deserialization to file or integration with Sql. Sql script, Entity Framework, Serialization
- A firm understanding of more advanced .Net concepts. E.g. Reflection, Generics and Linq, Threading
- Unit tests on all code, or at least, be able to show how all code is unit testable. E.g. NUnit, Moq/Subversion, Constructor Injection
		

# Result

Please fill out any result here. and send us the url to your fork.
