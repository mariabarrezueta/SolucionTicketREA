USE REAbase
DROP TABLE IF EXISTS Compras;
CREATE TABLE Compra (
    PurchaseId INT PRIMARY KEY IDENTITY(1,1),
    HolderName NVARCHAR(MAX) NOT NULL,
    HolderId NVARCHAR(MAX) NOT NULL,
    TicketQuantity INT NOT NULL,
    TotalAmount DECIMAL(18,2) NOT NULL,
    EventName NVARCHAR(MAX) NOT NULL,
    CreditCardNumber NVARCHAR(MAX) NOT NULL,
    CardCode NVARCHAR(MAX) NOT NULL,
    ExpirationDate DATETIME NOT NULL
);

