CREATE TABLE [dbo].[PERSONALSTATMENT] (
    [ID]        INT           NOT NULL,
    [PStatment] VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[EducationLevel] (
    [EduLevel_ID] INT           NOT NULL,
    [EduLevel]    VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([EduLevel_ID] ASC)
);

CREATE TABLE [dbo].[Institution] (
    [Inst_ID]            INT           NOT NULL,
    [Name]               VARCHAR (255) NULL,
    [StudyDate]          DATE          NULL,
    [InstitutionAddress] VARCHAR (MAX) NULL,
    [EduLevel_ID]        INT           NULL,
    PRIMARY KEY CLUSTERED ([Inst_ID] ASC),
    FOREIGN KEY ([EduLevel_ID]) REFERENCES [dbo].[EducationLevel] ([EduLevel_ID])
);

CREATE TABLE [dbo].[Qualification] (
    [Qual_ID]       INT           NOT NULL,
    [Qualification] VARCHAR (MAX) NULL,
    [Module]        VARCHAR (MAX) NULL,
    [ModuleDetail]  VARCHAR (MAX) NULL,
    [Grade]         VARCHAR (255) NULL,
    [EduLevel_ID]   INT           NULL,
    [Inst_ID]       INT           NULL,
    PRIMARY KEY CLUSTERED ([Qual_ID] ASC),
    FOREIGN KEY ([EduLevel_ID]) REFERENCES [dbo].[EducationLevel] ([EduLevel_ID]),
    FOREIGN KEY ([Inst_ID]) REFERENCES [dbo].[Institution] ([Inst_ID])
);

