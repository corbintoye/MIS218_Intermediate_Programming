/* 
This script creates the Midterm database
MIS 218
Midterm Assignment
Corbin Toye
*/

--Creates database
USE [master]
IF DB_ID('Midterm') IS NOT NULL
	DROP DATABASE Midterm

CREATE DATABASE Midterm
GO

USE [Midterm]
GO

--Creates Students table
CREATE TABLE Students (
StudentId INT IDENTITY(1,1) PRIMARY KEY,
LastName VARCHAR(30) NOT NULL,
FirstName VARCHAR(30) NOT NULL,
Email VARCHAR(50) NOT NULL
)

--Creates Assignments table
CREATE TABLE Assignments (
AssignmentId INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(30) NOT NULL,
TotalPoints INT NOT NULL
)

--Creates CompletedAssignments table
CREATE TABLE CompletedAssignments (
StudentId INT FOREIGN KEY REFERENCES Students(StudentId),
AssignmentId INT FOREIGN KEY REFERENCES Assignments(AssignmentId),
EarnedPoints INT NOT NULL
)

--Inserts values into Students table
INSERT INTO Students (LastName, FirstName, Email) 
VALUES
('Cartman', 'Eric', 'cartmane@mail.com'),
('Marsh', 'Stan', 'marshs@mail.com'),
('McCormick', 'Kenny', 'mccormickk@mail.com')

--Inserts values into Assignments table
INSERT INTO Assignments (Name, TotalPoints)
VALUES
('Introduction', 10),
('Discussion', 10),
('Quiz', 10)

--Inserts scores into CompletedAssignments table
INSERT INTO CompletedAssignments (StudentId, AssignmentId, EarnedPoints)
VALUES
(1, 1, 8),
(1, 2, 6),
(1, 3, 7),
(2, 1, 10),
(3, 1, 9)
