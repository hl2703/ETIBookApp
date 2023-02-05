# ETIBookApp

BookApp is a simple library web application which allows users to view the book catalogue and events in the library.

Main Features:

1a. View All Books

1b. View book details:
- ISBN
- Title
- Category
- Author
- Book Description

2a. View all events

2b. View event details:
- Event name
- Event description
- Event start date 
- Event end date

Design considerations
-	Each service is responsible for a single part of the functionality.
Each of the features are managed with a distinct microservice. Each microservice is autonomous, independently deployable, and responsible for its own data.  For example, one microservice for managing books and one microservice for events management. Having a single concern makes the microservice easier to maintain and scale.
-	Have separate databases for each microservice. Each database will store the data needed for the microservice  and used only for that microservice. For example, the books service stores its data in a SQL database. The events service uses a another SQL database.  There's no single master data store with which all services interact. Instead, inter-service communication occurs on an as-needed basis, either via synchronous API calls or asynchronously through messaging. This data isolation gives every service the autonomy to independently apply data schema updates, without breaking other services in the production environment.For example, book microservice has its own database and event microservice has its own database.
-	Loosely coupled design: A loosely coupled service depends minimally on other services. Microservices are loosely coupled if you can change one service without requiring other services to be updated at the same time. For example, bugs in the books microservice can be fixed and updated without having to modify the events microservice.
-	High cohesion: Each microservice should perform only one main function and do it well. Having high cohesion requires that the design of the service should follow the single responsibility principle. Each microservice is designed so that it has minimal dependencies on other microservice. For example, book  microservice should only cover management of books and not include event functions.

Architecture Diagram
![image](https://user-images.githubusercontent.com/73155822/215783002-4d4d96b0-989f-4e2e-bdeb-d0a66394008f.png)


Microservices
- consists of small, individually deployable services performing different operations.
- focus on a single business domain that can be implemented as fully independent deployable services
- Using domain driven design
- This architecture enables each microservice to implement the data store that is best optimized for its workload, storage needs, and read/write patterns.

As seen in the diagram, the microservices are:
- Events  
- Books 

Communications between microservices are done with lightweight mechanisms-REST API calls

Databases for storing data for each microservice:
- Book database: Stores book details such as ISBN, Name, Author, Category and Description
- Event Database: Stores event details such EventID, EventName, StartDate, EndDate, EventDescription

API gateway
- The microservices are accessible to clients via the API gateway. 
- API gateways provide the following benefits:
1. Better isolation: An API Gateway provides isolation by preventing direct access to internal concerns. Additionally, an API Gateway enables you to add more microservices or change boundaries without impacting the external consumers.
2. Improved security: An API Gateway provides a security layer for your microservices that can help prevent attack vectors such as SQL Injection, Denial-of-Service (DoS), etc.
3. Reduced complexity: Microservices have specific common concerns. An API Gateway can eliminate code duplication hence reducing the effort required to create these components.

Ocelot is a lightweight, open-source, scalable, and fast API Gateway based on .NET Core and specially designed for microservices architecture. It provides a unified point of entry into the system. The ocelot.json file specifies configuration of the API Gateway. There are two sections to the configuration- an array of ReRoutes and a GlobalConfiguration.

Containers
- Containers are the smallest compute unit in a cloud-native application. 
- By containerizing the microservices, cloud-native applications run independently of the underlying operating system and hardware. 
- The books microservice is deployed in one docker container and the events microservice in another docker container. 

Instructions for setting up and running the program
- Clone the files in the github repository. 
- Open the files using Visual Studio. 
- Create a new project for each of the folders and copy the respective files into the project folder
- Ensure that the databases has been set up using the SQL scripts. 
- Click the run button to start up the program. 

Setting up SQL database
- Open the sql files using MySQL or Microsoft SQL server management studio. 
- Execute each file to set up the database table.

Book Catalogue 
- View all books in the library using the book catalogue. 
- To see more information about the book and check its availability, click on the ‘Details’ button on the row of the book record. 
- The book details will be displayed.

Events
- View all ongoing and upcoming events at the library. 
- To see more information about an event, click on the event name. 
- You can check the event start date, end date and description of the event.

References:

https://cloud.google.com/appengine/docs/flexible/testing-and-deploying-your-app?tab=python#troubleshooting

https://learn.microsoft.com/en-us/training/modules/microservices-aspnet-core/3-solution-architecture

https://dotnettutorials.net/lesson/microservices-using-asp-net-core/

https://www.c-sharpcorner.com/article/building-api-gateway-using-ocelot-in-asp-net-core/

https://cloud.google.com/load-balancing/docs/load-balancing-overview

https://cloud.google.com/traffic-director

https://www.freecodecamp.org/news/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28/

https://www.c-sharpcorner.com/article/building-api-gateway-using-ocelot-in-asp-net-core/

https://www.twilio.com/blog/containerize-your-aspdotnet-core-application-and-sql-server-with-docker

https://www.3pillarglobal.com/insights/develop-microservices-net-core-docker/

https://auth0.com/blog/implementing-api-gateway-in-aspnet-core-with-ocelot/


