
IF OBJECT_ID('dbo.Items', 'U') IS NOT NULL
    DROP TABLE dbo.Items;

CREATE TABLE Items(
    ItemID INT NOT NULL PRIMARY KEY,
    ItemName VARCHAR(255) NOT NULL,
    ItemDesc VARCHAR(MAX) NULL,
    --Category VARCHAR(255) NOT NULL,
    --Price DECIMAL(10,2) NOT NULL,
    --Quantity INT NOT NULL DEFAULT 0
);