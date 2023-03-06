SELECT CONCAT(C.FirstName, C.LastName) AS FullName
,C.Age
,O.OrderId
,O.MethodOfPurchase
,OD.ProductNumber
,OD.ProductOrigin
FROM Customer C INNER JOIN Orders O ON C.PersonId = O.PersonId
INNER JOIN OrderDetail OD ON O.OrderId = OD.OrderId
WHERE OD.ProductId = 1112222333
