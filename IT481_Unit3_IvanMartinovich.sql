CREATE LOGIN User_CEO WITH PASSWORD = 'CEOPass';
CREATE LOGIN User_HR WITH PASSWORD = 'HRPass';
CREATE LOGIN User_Sales WITH PASSWORD= 'SalesPass';

USE Northwind;

CREATE USER User_CEO FOR LOGIN User_CEO;
CREATE USER User_HR FOR LOGIN User_HR;
CREATE USER User_Sales FOR LOGIN User_Sales;

CREATE ROLE SalesRole;
CREATE ROLE HRRole;
CREATE ROLE CEORole;

GRANT SELECT ON OBJECT:: Orders TO SalesRole;
GRANT SELECT ON OBJECT:: Customers TO SalesRole;

GRANT SELECT ON OBJECT:: Employees TO HRRole;

GRANT SELECT ON OBJECT:: Orders TO CEORole;
GRANT SELECT ON OBJECT:: Customers TO CEORole;
GRANT SELECT ON OBJECT:: Employees TO CEORole;

ALTER ROLE SalesRole ADD MEMBER User_Sales;
ALTER ROLE HRRole ADD MEMBER User_HR;
ALTER ROLE CEORole ADD MEMBER User_CEO;