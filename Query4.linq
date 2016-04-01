<Query Kind="Expression">
  <Connection>
    <ID>03851fc0-6b5d-4d4f-854d-530a559d1234</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://services.odata.org/Northwind/Northwind.svc</Server>
  </Connection>
</Query>

//(from o in Orders
//where o.Order_Details.Any(od => od.Product.ProductName == "Chai")
//select o).Count()
//
//(from od in Order_Details
//where od.Product.ProductName == "Chai"
//select new { od.Order }).Distinct().Count()

(from p in Products
from od in p.Order_Details
where p.ProductName == "Chai"
select new {od.Order}).Distinct().Count()