USE [dotnet21_project]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/11/2023 8:58:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Email] [nvarchar](500) NULL,
	[Password] [nvarchar](500) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Email], [Password]) VALUES (1, N'Nguyễn Văn A', N'nva@gmail.com', N'$2a$11$61G.em05kF/ZoDcm5I4BieVZ13kThIROocOj/M5nScChh9gvvfMZe')
INSERT [dbo].[Users] ([Id], [Name], [Email], [Password]) VALUES (2, N'Nguyễn Văn B', N'nvb@gmail.com', N'$2a$11$61G.em05kF/ZoDcm5I4BieVZ13kThIROocOj/M5nScChh9gvvfMZe')
INSERT [dbo].[Users] ([Id], [Name], [Email], [Password]) VALUES (3, N'Nguyễn Văn C', N'nvc@gmail.com', N'$2a$11$61G.em05kF/ZoDcm5I4BieVZ13kThIROocOj/M5nScChh9gvvfMZe')
INSERT [dbo].[Users] ([Id], [Name], [Email], [Password]) VALUES (4, N'Nguyễn Văn D', N'nvd@gmail.com', N'$2a$11$61G.em05kF/ZoDcm5I4BieVZ13kThIROocOj/M5nScChh9gvvfMZe')
INSERT [dbo].[Users] ([Id], [Name], [Email], [Password]) VALUES (5, N'Nguyễn Văn E', N'nve@gmail.com', N'$2a$11$61G.em05kF/ZoDcm5I4BieVZ13kThIROocOj/M5nScChh9gvvfMZe')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
