INSERT INTO [dbo].[EducationLevel] ([EduLevel_ID], [EduLevel]) VALUES (1, N'University')
INSERT INTO [dbo].[EducationLevel] ([EduLevel_ID], [EduLevel]) VALUES (2, N'College')
INSERT INTO [dbo].[EducationLevel] ([EduLevel_ID], [EduLevel]) VALUES (3, N'High School')

INSERT INTO [dbo].[Institution] ([Inst_ID], [Name], [StudyDate], [InstitutionAddress], [EduLevel_ID]) VALUES (1, N'Birmingham City University', N'2016-01-01', N'Birmingham City University, 
City North Campus
, Birmingham,
 B42 2SU
', 1)
INSERT INTO [dbo].[Institution] ([Inst_ID], [Name], [StudyDate], [InstitutionAddress], [EduLevel_ID]) VALUES (2, N'Birmingham Metropolitan College', N'2012-01-01', N'Birmingham Metropolitan College, Matthew Boulton Campus, Jennens Road, Birmingham, B4 7PS', 2)
INSERT INTO [dbo].[Institution] ([Inst_ID], [Name], [StudyDate], [InstitutionAddress], [EduLevel_ID]) VALUES (3, N'George Dixon International School', N'2007-01-01', N'George Dixon International School, City Road, Edgbaston, Birmingham, B17 8LF', 3)

INSERT INTO [dbo].[PERSONALSTATMENT] ([ID], [PStatment]) VALUES (1, N'As former student At Birmingham City University, 
I am very enthusiastic, and energetic. Logical and analytical, I have excellent communication with everyone around me, 
customers and employees alike. This helps to attract and retain high profile clients. Quick thinking, 
focused and a fast learner when it comes to solving problems or generating new ideas. I offer versatility across the computing spectrum, 
both hardware and software, programing and designing. I am Professional yet laid back, to embrace a good work/life balance.
 Employees and/or customers will be impressed by the excellent presentation, and friendliness that I bring to your business.')

 INSERT INTO [dbo].[Qualification] ([Qual_ID], [Qualification], [Module], [ModuleDetail], [Grade], [EduLevel_ID], [Inst_ID]) VALUES (1, N'Degree', N'Computer Sceince', N'Mobile and Web Technologies - 72, Advanced Software Development - 60, Discrete Computing and Algorithms - 68, Web Technologies - 79, Computer and Network Fundamentals - 68', N'2:1', 1, 1)
INSERT INTO [dbo].[Qualification] ([Qual_ID], [Qualification], [Module], [ModuleDetail], [Grade], [EduLevel_ID], [Inst_ID]) VALUES (2, N'Access To IT', N'Software Development', NULL, N'Distinction', 2, 2)
INSERT INTO [dbo].[Qualification] ([Qual_ID], [Qualification], [Module], [ModuleDetail], [Grade], [EduLevel_ID], [Inst_ID]) VALUES (3, N'BTEC Certificate', N'Software Development', NULL, N'Pass', 2, 2)
INSERT INTO [dbo].[Qualification] ([Qual_ID], [Qualification], [Module], [ModuleDetail], [Grade], [EduLevel_ID], [Inst_ID]) VALUES (4, N'GCSE', N'English', NULL, N'C', 2, 2)
INSERT INTO [dbo].[Qualification] ([Qual_ID], [Qualification], [Module], [ModuleDetail], [Grade], [EduLevel_ID], [Inst_ID]) VALUES (5, N'GCSE', N'Science', NULL, N'C', 3, 3)
INSERT INTO [dbo].[Qualification] ([Qual_ID], [Qualification], [Module], [ModuleDetail], [Grade], [EduLevel_ID], [Inst_ID]) VALUES (6, N'GCSE', N'Math', NULL, N'C', 3, 3)
