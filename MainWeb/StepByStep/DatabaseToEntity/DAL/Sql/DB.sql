IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.Course') AND type in (N'U'))
    DROP TABLE dbo.Course
GO
CREATE TABLE dbo.Course(
       CourseId int identity(1,1) PRIMARY KEY,
       Title nvarchar(128) default '' not null,
       Credits int default 1 not null
)
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.Student') AND type in (N'U'))
    DROP TABLE dbo.Student
GO
CREATE TABLE dbo.Student(
   StudentId int identity(1,1) PRIMARY KEY,
   LastName nvarchar(64) not null,
   FirstMidName nvarchar(64) not null,
   EnrollmentDate DateTime not null
)
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.Enrollment') AND type in (N'U'))
    DROP TABLE dbo.Enrollment
GO
CREATE TABLE dbo.Enrollment(
        EnrollmentId int identity(1,1) PRIMARY KEY,
        CourseId int not null,
        StudentId int not null,
        Grade int default 0 not null
)
GO

  ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Student] FOREIGN KEY([StudentId])
        REFERENCES [dbo].[Student] ([StudentId])
  GO


    ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Course] FOREIGN KEY([CourseId])
        REFERENCES [dbo].[Course] ([CourseId])
  GO








