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

![image](https://user-images.githubusercontent.com/73155822/215686022-bf4e9e1e-25de-41c8-bcb5-d45c2c7026fe.png)
