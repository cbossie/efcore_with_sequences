# Sequence Demo in EF Core

Each of these projects demonstrates sequences and bulk inserts using EF core. The data model is:
User
--> Has multiple Roles

Role
--> Has multiple Attributes

## Directories / Projects

### CodeFirst
Project uses code first with migrations 

- Tables created will all have their primary key generated from the "AllIDs" sequence.
- Role IDs will be generated from the "userRoleIDs" sequence
- Role Attribute IDs will be generated from the "roleAttributeIds" sequence

All tables are connected by foreign keys in the DB.

Connection string pushes the migrations to a DB called "SEQUENCE" on a local instance.

Modify the Connection String and run "dotnet ef database update" to create the DB structure.

### Database First
Project uses the fluent API to construct the model in code.

- User table has an embedded identity column
- Role IDs will be generated from the "userRoleIDs" sequence
- Role Attribute IDs will be generated from the "roleAttributeIds" sequence

No tables have explicit FKs in the DB

Connection string use a DB called "SEQUENCE_DBFIRST" on a local instance. You will need to run the contents of the "SEQUENCE_DBFIRST" script to bootstrap the database.

