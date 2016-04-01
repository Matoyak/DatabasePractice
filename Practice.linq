<Query Kind="Expression">
  <Connection>
    <ID>03851fc0-6b5d-4d4f-854d-530a559d1234</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://services.odata.org/Northwind/Northwind.svc</Server>
  </Connection>
  <Output>DataGrids</Output>
</Query>

//from e in Employees select e
//Employees.Select(e => e)

(from e in Employees
where e.City == "Seattle"
orderby e.LastName descending, e.FirstName ascending
select new { //select is a projection, it transforms the data.
	FN = e.FirstName, Blah = e.LastName
}).Skip(3).Take(1).ToList()

/*Employees.Select(e => new {
	FirstName = e.FirstName,
	LastName = e.LastName
})*/

Employees
.Where(e => e.City == "Seattle")
.OrderByDescending(e => e.LastName).ThenBy(e => e.FirstName)
.Select(e => new {
	e.FirstName, e.LastName
})