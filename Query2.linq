<Query Kind="Expression">
  <Connection>
    <ID>03851fc0-6b5d-4d4f-854d-530a559d1234</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://services.odata.org/Northwind/Northwind.svc</Server>
  </Connection>
</Query>

//Query syntax
//from c in Customers
//from o in c.Orders
//where c.Country == "Mexico"
//select o

//method syntax
Customers
.Where(c => c.Country == "Mexico")
.SelectMany(c => c.Orders).Select( o => o)