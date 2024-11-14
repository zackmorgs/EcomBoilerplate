# EcomBoilerplate
First off, this is just a brief "sketch" of a repo.

It's pretty simple. I'm offering services on Fiverr to make ecommerce sites. Having worked on a couple e-commerce sites in my career, here is my boilerplate for bespoke web projects. 

## Basic Structure
`./src/EcomComponents`
This is a razor class library that holds UI components. 

`./src/EcomServer`
This is a Blazor server that ingests components from the aforementioned razor class library. It holds an Entity Framework Core ORM Sqlite3 database with 

- Carts
- Product 
- Orders
- Products
- Product Reviews
- Users (Overloading IdentityUser)

## TailwindCSS Integration
Project uses SCSS and tailwind's PurgeCSS features to ensure only the actually used styles are "compiled" to the `./src/EcomComponents/wwwroot/css/styles.css` file which is included in the `EcomServer` Blazor server project.

