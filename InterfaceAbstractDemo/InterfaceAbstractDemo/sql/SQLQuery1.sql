select * from Customers

select * from Products where city = 'berlin'

select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and CategoryID = 3

select * from Products order by UnitPrice asc -- ascending increasing

select * from Products where CategoryID = 1 order by UnitPrice desc -- descending decreasing

select count(*) adet from Products where CategoryID = 1

select CategoryID,count(*) Adet from Products where UnitPrice > 20 group by CategoryID having count(*) < 10

select Products.ProductID,Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10 
order by Products.UnitPrice desc

--DTO data transformation object

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID 

select * from Customers c left join Orders o on c.CustomerID = o.customerId where o.CustomerID is null


