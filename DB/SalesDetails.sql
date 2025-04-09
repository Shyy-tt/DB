IF OBJECT_ID('dbo.SalesDetails', 'U') IS NOT NULL
    DROP TABLE dbo.SalesDetails;

CREATE TABLE SalesDetails (
    SaleDetailID INT PRIMARY KEY IDENTITY(1,1),
    Sale_id INT NOT NULL FOREIGN KEY REFERENCES  Sales(Sale_id),
    InventoryID INT NOT NULL FOREIGN KEY REFERENCES  Inventory(InventoryID),
    Quantity INT NOT NULL CHECK (Quantity > 0),
    UnitPrice DECIMAL(10,2) NOT NULL,
    LineTotal AS (Quantity * UnitPrice)
);

-- NOW INSERT SAMPLE DATA:

-- Insert sample items
INSERT INTO Items (Name) 
VALUES ('Laptop'), ('Mouse'), ('Keyboard');

-- Initialize inventory
INSERT INTO Inventory (ItemID, QuantityInStock)
VALUES (1, 50), (2, 100), (3, 75);

-- Create a sale
INSERT INTO Sales (Price, Amount)
VALUES (100, 10); -- Start with 0 total

-- Add items to sale (this automatically updates inventory through the trigger)
INSERT INTO SalesDetails (Sale_id, InventoryID, Quantity, UnitPrice)
VALUES 
    (1, 1, 1, 999.99), -- Explicit laptop price
        (1, 2, 2, 19.99);   -- Explicit mouse price

-- Update sale total
UPDATE Sales
SET Amount = (SELECT SUM(LineTotal) FROM SalesDetails WHERE Sale_id = 1)
WHERE Sale_id = 1;

-- Verify the data
SELECT * FROM Items;
SELECT * FROM Inventory; -- Should show reduced quantities
SELECT * FROM Sales;
SELECT * FROM SalesDetails;