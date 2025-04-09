IF OBJECT_ID('dbo.Sales', 'U') IS NOT NULL
    DROP TABLE dbo.Sales;

CREATE TABLE dbo.Sales (
    Sale_id INT PRIMARY KEY IDENTITY(1,1),
    Price DECIMAL(10,2) NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    Sale_Date DATETIME2(3) DEFAULT SYSDATETIME(),  -- 3 decimal precision
);
