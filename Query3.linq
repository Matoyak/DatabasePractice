<Query Kind="Expression">
  <Connection>
    <ID>03851fc0-6b5d-4d4f-854d-530a559d1234</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://services.odata.org/Northwind/Northwind.svc</Server>
  </Connection>
  <Output>DataGrids</Output>
</Query>

from e in Employees
where e.ReportsTo == null
select e