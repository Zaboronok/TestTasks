SELECT p.name AS ProductName, c.name AS CategoryName
FROM Products p
LEFT JOIN ProductCategory pc ON p.id = pc.product_id
LEFT JOIN Categories c ON pc.category_id = c.id;