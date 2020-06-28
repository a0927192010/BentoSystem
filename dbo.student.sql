CREATE TABLE [dbo].[student] (
    [stu_id] INT NOT NULL IDENTITY,
    [name]   NVARCHAR (50) NULL,
    [phone]  NVARCHAR (50) NULL,
    [class]  NVARCHAR (50) NULL,
    CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED ([stu_id] ASC)
);

