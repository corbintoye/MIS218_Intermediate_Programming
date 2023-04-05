
--These are SQL queries to be used in the Simple Gradebook

--1
SELECT 
FirstName, 
LastName, 
Name, 
EarnedPoints, 
TotalPoints, 
CAST((CAST(EarnedPoints AS DECIMAL) / CAST(TotalPoints AS DECIMAL) * 100) AS DECIMAL(5, 2)) AS Grade
FROM Students
JOIN CompletedAssignments ON Students.StudentId = CompletedAssignments.StudentId
JOIN Assignments ON CompletedAssignments.AssignmentId = Assignments.AssignmentId

--2
SELECT
FirstName,
LastName,
SUM(CompletedAssignments.EarnedPoints) AS EarnedPoints,
SUM(Assignments.TotalPoints) AS TotalPoints,
CAST(((SUM(CAST(EarnedPoints AS DECIMAL)) / SUM(CAST(TotalPoints AS DECIMAL))) * 100) AS DECIMAL(5, 2)) AS Grade
FROM Students
JOIN CompletedAssignments ON Students.StudentId = CompletedAssignments.StudentId
JOIN Assignments ON CompletedAssignments.AssignmentId = Assignments.AssignmentId
GROUP BY Students.FirstName, Students.LastName, Students.StudentId