# MediatR-CQRS


We know how a traditional web API works. It mainly consists of the CRUD operations. All the four operations are tied together inside an API controller.
C – Create
R - Read
U – Update
D – Delete.
To decouple the application we create interfaces for our data access layer, inject it in the constructor of API controller and perform the actions. This works fine and all looks good. But as your application grow in size the number of dependencies also increases. Now we need to inject multiple interfaces in the API controller and hence the application complexity increases.
 
In order to solve this problem, let’s use CQRS & Mediator Patterns.

CQRS stands for Command Query Responsibility Segregation. That is separating Command (write) and Query (read) models of an application to scale read and write operations of an application independently. Instead of having all of the four CRUD operations together, let us segment out to two different pieces.


<img width="331" alt="1-1-fig" src="https://user-images.githubusercontent.com/38523330/151299909-23956378-64cd-40ef-864e-0f7a9db714ca.png">

Mediator is used to reduce communication complexity between multiple objects or classes. This pattern provides a mediator class which normally handles all the communications between different classes and supports easy maintenance of the code by loose coupling. Mediator pattern falls under behavioural pattern category.
 
Basically, a Mediator perform 2 operations.
· Accept the incoming request
· Handles the incoming request and provide the response.
CQRS + Mediator Patterns are prefered over large projects.
 
Let’s get into the code and see how this CQRS & Mediator patterns work together.
 
Read data using CQRS & MediatR


In this Project am using .Net Core 5 also am using C# 9.0 Record Feature
