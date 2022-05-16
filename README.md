# Micro ORM EntityToDB
This is a tool repo that helps building line of business apps. The main project is EntitytoDB. EntityToDB is a simple and straightforward micro ORM for SQL Server and C#.

It has the following features:

  1. It's database first approach. You design, change your database, then generate mapping model/entity. A utility Egen will help the model/entity generation
  2. The mapping is straightforward one on one for all tables and views in the database.  There is no data annotation required. The entity class is just plain C# class.
  3. It supports database migration. The migration is one way up: You can add table, view and index. You can also add fields to table or change field type. 
  4. It uses SQL with parameters for database query and update. it does not use LINQ.
  5. The performance is close to raw ADO.Net
  6. It's easy to handle SQL transaction.
  7. Egen is the utility project you use to generate model and entity. You also use this utility to script the database schema and save it with you application for database migration
  8. DbTest is a demo project for the use of EntityToDB.
