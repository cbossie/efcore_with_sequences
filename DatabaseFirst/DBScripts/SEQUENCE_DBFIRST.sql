/****** Object:  Sequence [dbo].[roleAttributeIds]    Script Date: 8/29/2018 12:04:36 PM ******/
CREATE SEQUENCE [dbo].[roleAttributeIds] 
 AS [bigint]
 START WITH 19777
 INCREMENT BY 14
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Sequence [dbo].[UserRoleIDs]    Script Date: 8/29/2018 12:04:36 PM ******/
CREATE SEQUENCE [dbo].[UserRoleIDs] 
 AS [bigint]
 START WITH 5000
 INCREMENT BY 2
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[RoleAttributes]    Script Date: 8/29/2018 12:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAttributes](
	[RoleAttributeId] [int] NOT NULL,
	[UserRoleId] [int] NOT NULL,
	[Attribute] [nvarchar](max) NULL,
	[Value] [nvarchar](max) NULL,
	[Seq] [int] NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[RoleAttributeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 8/29/2018 12:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserId] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 8/29/2018 12:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[RoleId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[RoleName] [nvarchar](max) NULL,
 CONSTRAINT [PK_RoleId] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_RoleAttributes_UserRoleId]    Script Date: 8/29/2018 12:04:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoleAttributes_UserRoleId] ON [dbo].[RoleAttributes]
(
	[UserRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserRole_UserId]    Script Date: 8/29/2018 12:04:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserRole_UserId] ON [dbo].[UserRole]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RoleAttributes] ADD  DEFAULT (NEXT VALUE FOR [dbo].[roleAttributeIds]) FOR [RoleAttributeId]
GO
ALTER TABLE [dbo].[RoleAttributes] ADD  DEFAULT (NEXT VALUE FOR [dbo].[roleAttributeIds]) FOR [Seq]
GO
ALTER TABLE [dbo].[UserRole] ADD  DEFAULT (NEXT VALUE FOR [dbo].[UserRoleIDs]) FOR [RoleId]
GO