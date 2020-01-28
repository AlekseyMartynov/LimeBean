# LimeBean

[RedBeanPHP](http://redbeanphp.com/)-inspired data access layer for .NET and Mono.

## Supported Databases
* MySQL/MariaDB
* SQLite
* SQL Server
* PostgreSQL

## Synopsis

LimeBean treats your data entities as `IDictionary<string, object>` and maintains the database schema on the fly (when in fluid mode).

LimeBean does not use any Reflection, IL emitting, `dynamic`, etc. Instead it relies on strings, dictionaries and fragments of plain SQL.  

## Code Samples

* [Untyped CRUD](https://github.com/AlekseyMartynov/LimeBean/blob/master/LimeBean.Tests/Examples/Crud.cs)
* [Strongly-typed models with inter-bean links and lifecycle hooks](https://github.com/AlekseyMartynov/LimeBean/blob/master/LimeBean.Tests/Examples/Northwind.cs)
* [Usage in ASP.NET](https://github.com/AlekseyMartynov/LimeBean/blob/master/LimeBean.Tests/Examples/AspNet.cs)
* [GUID primary keys](https://github.com/AlekseyMartynov/LimeBean/blob/master/LimeBean.Tests/Examples/AutoGuidKeys.cs)

## API

All available properties and methods are exposed via the [BeanApi facade class](https://github.com/AlekseyMartynov/LimeBean/blob/master/LimeBean/BeanApi.cs).
