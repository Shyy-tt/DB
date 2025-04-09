IF OBJECT_ID('dbo.Inventory', 'U') IS NOT NULL
    DROP TABLE dbo.Inventory;

CREATE TABLE Inventory (
    InventoryID INT IDENTITY(1,1) PRIMARY KEY,
    ItemID INT NOT NULL FOREIGN KEY REFERENCES Items(ItemID),
    QuantityInStock INT NOT NULL DEFAULT 0,
    LastStockUpdate DATETIME DEFAULT GETDATE(),
    ExpiryDate DATE,
    CONSTRAINT CHK_Quantity CHECK (QuantityInStock >= 0)
);

--INSERT INTO Inventory (ItemID, QuantityInStock)
--VALUES
    --(100, 15),  -- Orange
    --(204, 42),  -- Grapes
    --(308, 120); -- Mango

--SELECT * FROM Inventory;