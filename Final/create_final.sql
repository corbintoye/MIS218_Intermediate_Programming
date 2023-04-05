/*
Creates database for MIS 218  Final
Corbin  Toye
03/08/23
*/

--DDL
USE [master]
IF DB_ID('final') IS NOT NULL
	DROP DATABASE final

CREATE DATABASE final
GO

USE [final]
GO


CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CatName VARCHAR(50) NOT NULL
);

CREATE TABLE Accounts (
    AccountID INT IDENTITY(1,1) PRIMARY KEY,
    AcctName VARCHAR(50) NOT NULL 
);


CREATE TABLE Payees (
    PayeeID INT IDENTITY(1,1) PRIMARY KEY,
    PayeeName VARCHAR(50) NOT NULL,
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID)
);

CREATE TABLE Transactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    Date DATE NOT NULL,
    Amount MONEY DEFAULT 0 NOT NULL,
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID),
    PayeeID INT FOREIGN KEY REFERENCES Payees(PayeeID),
    AccountID INT FOREIGN KEY REFERENCES Accounts(AccountID),
    Note VARCHAR(75) DEFAULT 'NA'
);

--DML
GO

INSERT INTO Accounts (AcctName)
VALUES
('Savings'),
('Checking')

INSERT INTO Categories (CatName)
VALUES
('Gas'),
('Groceries'),
('Deposit'),
('Withdrawal'),
('Transfer')

INSERT INTO Payees (PayeeName, CategoryID)
VALUES
('Chevron', 1),
('Safeway', 2),
('Account Transfer', 5),
('Account Deposit', 3),
('Account Withdrawal', 4)

INSERT INTO Transactions (Date, Amount, CategoryID, PayeeID, AccountID, Note)
VALUES
('2023-03-13', 10.50, 1, 1, 2, 'Filled tank'),
('2023-03-12', 23.75, 2, 2, 2, 'Weekly grocery trip'),
('2023-03-14', 100, 3, 4, 1, 'Initial deposit')
