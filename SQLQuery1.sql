CREATE DATABASE StudentInformationDB;
go
USE StudentInformationDB;
go
-- User Account Management
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(50) NOT NULL, 
    Age INT,
    PhoneNumber NVARCHAR(20),
    Status NVARCHAR(20) -- Normal, Locked
);

-- Student Management
CREATE TABLE Students (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Age INT,
    PhoneNumber NVARCHAR(20),
    -- Add more student attributes as needed
);

-- Certificates for Students
CREATE TABLE Certificates (
    CertificateID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT,
    CertificateName NVARCHAR(100) NOT NULL,
    
);

-- Login History
CREATE TABLE LoginHistory (
    LoginHistoryID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT,
    LoginTime DATETIME
);

-- USE StudentInformationDB;
go
-- Insert a new user (Admin)
INSERT INTO Users (Username, Password, Role, Age, PhoneNumber, Status)
VALUES ('admin', 'adminpassword', 'Admin', 30, '123-456-7890', 'Normal');

-- Insert a new user (Manager)
INSERT INTO Users (Username, Password, Role, Age, PhoneNumber, Status)
VALUES ('manager', 'managerpassword', 'Manager', 28, '987-654-3210', 'Normal');

-- Insert a new user (Employee)
INSERT INTO Users (Username, Password, Role, Age, PhoneNumber, Status)
VALUES ('employee', 'employeepassword', 'Employee', 25, '555-555-5555', 'Normal');

-- Insert a new student
INSERT INTO Students (FirstName, LastName, Age, PhoneNumber)
VALUES ('John', 'Doe', 22, '111-222-3333');

-- Insert another student
INSERT INTO Students (FirstName, LastName, Age, PhoneNumber)
VALUES ('Jane', 'Smith', 20, '444-555-6666');

-- Insert certificates for students
INSERT INTO Certificates (StudentID, CertificateName)
VALUES (1, 'Certificate 1');

INSERT INTO Certificates (StudentID, CertificateName)
VALUES (2, 'Certificate 2');

-- Insert login history (Sample Data)
INSERT INTO LoginHistory (UserID, LoginTime)
VALUES (1, '2023-11-02 10:00:00');

INSERT INTO LoginHistory (UserID, LoginTime)
VALUES (2, '2023-11-02 09:30:00');
