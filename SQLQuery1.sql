CREATE TABLE [dbo].[Staffs]
(
 [Id] [int] IDENTITY (1,1) not null,
 [FirstName][nvarchar] (50) NOT NULL,
 [LastName][nvarchar] (50) NOT NULL,
 [sex][nvarchar] (50) NOT NULL,
 [@Address][nvarchar] (100) NOT NULL,
 [Email][nvarchar] (50) NOT NULL,
 [DOB][nvarchar] (50) NOT NULL,
 [PhoneNumber][nvarchar](50) NOT NULL,
 [NicNo][nvarchar] (100) NOT NULL,
 [Qualification][nvarchar](50) NOT NULL,
 [Specialization][nvarchar] (50) NOT NULL,
 [VisitationCharge][nvarchar](50) NOT NULL,
 [ConsultationCharge][nvarchar] (100) NOT NULL,
 [StaffType][nvarchar](50) NOT NULL,
 [Department][nvarchar] (50) NOT NULL,
 [MaritalStatus][nvarchar](50) NOT NULL,
 [Religion][nvarchar] (100) NOT NULL,
 [BloodGroup][nvarchar](50) NOT NULL,
 [Genotype][nvarchar] (100) NOT NULL,
)

Alter Table Staffs 
Add [Address] nvarchar (100)




Create Table [dbo].[Pharmacy](
[Id] [int] IDENTITY (1,1) primary Key not null,
 [DrugName][nvarchar] (50) NOT NULL,
 [Description][nvarchar] (100) NOT NULL,
 [Cost] [nvarchar] (50) NOT NULL,
 [Purpose][nvarchar] (100) NOT NULL,
 [PurchaseDate]DateTime  NOT NULL,
 [CreatedBy] DateTime NOT NULL,
 [CreatedDate]DateTime  NOT NULL,

)

Create Table [dbo].[Wards](
[Id] [int] IDENTITY (1,1) Primary Key not null,
 [WardName][nvarchar] (50) NOT NULL,
 [Description][nvarchar] (100) NOT NULL,
 [Location] [nvarchar] (100) NOT NULL,
 [Type][nvarchar] (50) NOT NULL,
 [CreatedBy] DateTime NOT NULL,
 [CreatedDate]DateTime  NOT NULL

)

create Table AccessLogs(
[Id] [int] IDENTITY (1,1) primary key not null,
 [UserName][nvarchar] (50) NOT NULL,
 [ComputerName][nvarchar] (50),
 [LogDate] DateTime NOT NULL,
 [Description][nvarchar] (100),
 
)


create table Patients(
 [Id] [int] IDENTITY(1,1) primary key  not null,
 WardId Int CONSTRAINT fx_Patients_Wards FOREIGN KEY (WardId) references Wards(Id),
 [FirstName][nvarchar] (50) NOT NULL,
 [LastName][nvarchar] (50) NOT NULL,
 [sex][nvarchar] (50) NOT NULL,
 [WorkAddress][nvarchar] (100) NOT NULL,
 [Email][nvarchar] (50) NOT NULL,
 [DOB][nvarchar] (50) NOT NULL,
 [PhoneNumber][nvarchar](50) NOT NULL,
 [NicNo][nvarchar] (100) NOT NULL,
 [NkPhoneNumber][nvarchar](50) NOT NULL,
 [NkEmail][nvarchar] (50) NOT NULL,
 [NkFirstName][nvarchar](50) NOT NULL,
 [NkSurname][nvarchar] (50) NOT NULL,
 [NkHomeAddress][nvarchar] (100) NOT NULL,
 [NkWorkAddress][nvarchar](50) NOT NULL,
 [MaritalStatus][nvarchar](50) NOT NULL,
 [Religion][nvarchar] (100) NOT NULL,
 [BloodGroup][nvarchar](50) NOT NULL,
 [Genotype][nvarchar] (100) NOT NULL,
 [Ethnic] [nvarchar] (20) Not Null,
 [Occupation] [nvarchar] (20) Not Null,
 [Picture] [nvarchar] (100) Not Null,
 [Balance] [int] ,
 [CreatedBy] DateTime ,
 [CreatedDate]DateTime,

)
create table Accounts(
 [Id] [int] IDENTITY (1,1) Primary Key not null,
 PatientId Int CONSTRAINT fx_Accounts_Patients FOREIGN KEY (PatientId) references Patients(Id),
 [Amount]int,
 [Comment] [nvarchar],
 [AccountDate]DateTime,
 [CreatedBy] DateTime NOT NULL,
 [CreatedDate]DateTime  NOT NULL,
       )

create table Tests(
Id int Primary Key Identity(1,1),
PatientId Int CONSTRAINT fx_Tests_Patients FOREIGN KEY (PatientId) references Patients(Id),
MedTest nvarchar (20),
Diagnosis nvarchar (100),
[Date] DateTime Not Null,
Remark nvarchar,
Doctor Nvarchar,
[Image] nvarchar,
[CreatedBy] DateTime,
 [CreatedDate]DateTime,

)

create Table[dbo].[Consultations](

Id int Primary Key Identity(1,1) not null,
PatientId Int CONSTRAINT fx_Consultations_Patients FOREIGN KEY (PatientId) references Patients(Id),
Doctor nvarchar,
AppointmantDate DateTime,
Note nvarchar(500),
[CreatedBy] DateTime,
 [CreatedDate]DateTime,
)


create table PatientHistory(
Id int Primary Key Identity (1,1) not null,
PatientId Int CONSTRAINT fx_PatientHistory_Patients FOREIGN KEY (PatientId) references Patients(Id),
WardId int Constraint fx_PatientHistory_wards Foreign Key (WardId) references Wards(Id),
DateAdmitted DateTime,
ReferredBy nvarchar,
Physician nvarchar,
AdmittedFor nvarchar,
DateDischarged nvarchar,
DischargedBy nvarchar,
Remark nvarchar,
[Status] nvarchar,
[CreatedBy] DateTime,
[CreatedDate]DateTime,
)

create table Payments(
Id int Primary Key Identity(1,1) not null,
PatientId Int CONSTRAINT fx_Payments_Patients FOREIGN KEY (PatientId) references Patients(Id),
PaymentFor nvarchar,
Amount nvarchar,
[CreatedBy] DateTime,
[CreatedDate]DateTime
)


create table Login(
Id int Primary key Identity(1,1) not null,
Username nvarchar,
[passwordHash] nvarchar(64),
Email nvarchar,
IsLock BIT CONSTRAINT CK_Login_IsLock CHECK (IsLock IN (0, 1)),
FailedCount int,
CountThreshold int,
[CreatedBy] DateTime,
[CreatedDate]DateTime

)