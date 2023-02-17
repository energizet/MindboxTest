SELECT p.Name AS Product, c.Name AS Product FROM Product p
LEFT JOIN ProductCategory pc ON pc.ProductId = p.Id
LEFT JOIN Category c ON pc.CategoryId = c.Id