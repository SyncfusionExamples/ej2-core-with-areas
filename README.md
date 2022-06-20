# ej2-core-with-areas

## Getting started for EJ2 core with Areas concept

This article explains creating a modular web application in ASP.NET Core using the area feature. 

## Modular programming

Modular programming is one of the design patterns, which splits the projects into several modules based on features and considers the modules as separate projects.
For example, consider a requirement to create a web application for a college. The application must provide information about available facilities and courses, admission process, faculty details, achievements (both academic and extracurricular activities) so far and contact details. 
You can split the requirement into 6 modules as follows: Facilities, Courses, Admission, Faculty, Achievements, and Contact Us. Each module will be considered as separate project and handled by separate team. Finally, all these projects are integrated.

## Benefits of modular programming
•	Rapid development
Working on all modules simultaneously by different teams or members will reduce the completion time.
•	Easily manageable code base
Code base will be managed without any hassle. 
•	Easy troubleshooting
Troubleshooting will be more conducive since a separate code base is provided for each module.
•	Definite responsibility for teams/members
Each team or member will have precisely predefined responsibility in the project.

##Area Feature in ASP.NET Core
	ASP.NET Core provides an area feature for creating a modular web application, where each module is created as area in an ASP.NET Core application. 
Microsoft Documentation: https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/areas?view=aspnetcore-6.0

