USE [master]
GO
/****** Object:  Database [Facebook]    Script Date: 5/19/2018 11:12:04 AM ******/
CREATE DATABASE [Facebook] ON  PRIMARY 
( NAME = N'Facebook', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Facebook.mdf' , SIZE = 253056KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Facebook_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Facebook_0.ldf' , SIZE = 2377088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Facebook].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Facebook] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Facebook] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Facebook] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Facebook] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Facebook] SET ARITHABORT OFF 
GO
ALTER DATABASE [Facebook] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Facebook] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Facebook] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Facebook] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Facebook] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Facebook] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Facebook] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Facebook] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Facebook] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Facebook] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Facebook] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Facebook] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Facebook] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Facebook] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Facebook] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Facebook] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Facebook] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Facebook] SET RECOVERY FULL 
GO
ALTER DATABASE [Facebook] SET  MULTI_USER 
GO
ALTER DATABASE [Facebook] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Facebook] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Facebook', N'ON'
GO
USE [Facebook]
GO
/****** Object:  UserDefinedFunction [dbo].[ConvertLanguage]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ConvertLanguage] 
(   
    @str nvarchar(max),
	@type varchar(100)
)
RETURNS NVARCHAR(50)
AS
BEGIN
 DECLARE @RESULT nvarchar(max);

 if(@type='gender')
 begin
    if(@str='male')
		set  @RESULT =N'Nam';
	else if(@str='female')
		set  @RESULT =N'Nữ';
	else
	    set @RESULT= N'Không Xác Định';
	return @RESULT
 end
 return null

end



GO
/****** Object:  UserDefinedFunction [dbo].[GetInfoDiaChi]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetInfoDiaChi] 
(   
    @strDiaChi_goc nvarchar(max) ,
	@strxxx varchar(5)
)
RETURNS NVARCHAR(max)
AS
BEGIN
    DECLARE @RESULT_STRING nvarchar(max);
	DECLARE @RESULT_Tinh nvarchar(max);
	DECLARE @RESULT_Huyen nvarchar(max);
	DECLARE @RESULT_Xa nvarchar(max);

    DECLARE @vtTinh int
	DECLARE @vtXa int
	DECLARE @vtHuyen int

	DECLARE @strDiaChi nvarchar(max);
	--SET @strDiaChi = REPLACE(@strDiaChi_goc,'-',',')
	set @strDiaChi=@strDiaChi_goc



	DECLARE @FindChar VARCHAR(1) = ','

	IF(@strxxx ='nuoc')
	begin
		if CHARINDEX(@FindChar,REVERSE(@strDiaChi)) >0
		begin
			set @RESULT_STRING  = RIGHT(@strDiaChi, CHARINDEX(@FindChar,REVERSE(@strDiaChi))-1) 
		end
	end
	if(@strxxx='tinh')
	begin
		
		Set @RESULT_Tinh = LEFT(@strDiaChi, LEN(@strDiaChi) - CHARINDEX(@FindChar,REVERSE(@strDiaChi)))
		if CHARINDEX(@FindChar,REVERSE(@RESULT_Tinh)) >0
		begin
			set @RESULT_STRING  = RIGHT(@RESULT_Tinh, CHARINDEX(@FindChar,REVERSE(@RESULT_Tinh))-1) 
		end
		else
		begin
		set @RESULT_STRING =@RESULT_Tinh
		end
	end

	if(@strxxx ='huyen')
	begin
		Set @RESULT_Tinh = LEFT(@strDiaChi, LEN(@strDiaChi) - CHARINDEX(@FindChar,REVERSE(@strDiaChi)))
		if CHARINDEX(@FindChar,REVERSE(@RESULT_Tinh))>0
		begin
			set @RESULT_Huyen= LEFT(@RESULT_Tinh, LEN(@RESULT_Tinh) - CHARINDEX(@FindChar,REVERSE(@RESULT_Tinh)))
			if CHARINDEX(@FindChar,REVERSE(@RESULT_Huyen))>0
			begin
				set @RESULT_STRING  = RIGHT(@RESULT_Huyen, CHARINDEX(@FindChar,REVERSE(@RESULT_Huyen))-1)
			end
			else
			begin
				set @RESULT_STRING =@RESULT_Huyen
			end 
		end
	end
	RETURN @RESULT_STRING

END

GO
/****** Object:  UserDefinedFunction [dbo].[GetYear]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--select dbo.[GetYear] ('02/1')



--select * from FbFollow where birthday <>''
CREATE FUNCTION [dbo].[GetYear] 
(   
    @strThoiGian nvarchar(max)
)
RETURNS NVARCHAR(20)
AS
BEGIN
	DECLARE @FindChar VARCHAR(1) = '/'
	if CHARINDEX(@FindChar,REVERSE(@strThoiGian)) =5
		begin
			return RIGHT(@strThoiGian, CHARINDEX(@FindChar,REVERSE(@strThoiGian))-1) 
		end
	RETURN null

END

GO
/****** Object:  Table [dbo].[CauHinh]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHinh](
	[LimitCallApi] [int] NULL,
	[TimerOut] [int] NULL,
	[GoiLai] [int] NULL CONSTRAINT [DF_CauHinh_sysLimitFriend]  DEFAULT ((700)),
	[LimitTimKiemFb] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ProductID] [int] NOT NULL,
	[CustomerName] [nvarchar](100) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dau_so]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dau_so](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nhamang] [nvarchar](50) NULL,
	[parentId] [int] NULL,
	[dauso] [nvarchar](5) NULL,
	[lenght] [int] NULL,
	[orderid] [int] NULL,
	[createdate] [datetime] NULL CONSTRAINT [DF_dau_so_createdate]  DEFAULT (getdate()),
 CONSTRAINT [PK_dau_so] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_QuocGia]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_QuocGia](
	[id] [uniqueidentifier] NOT NULL CONSTRAINT [DF_DM_QuocGia_id]  DEFAULT (newid()),
	[ma] [nchar](10) NULL,
	[name] [nvarchar](50) NULL,
	[isAct] [bit] NULL,
	[OrderId] [int] NULL,
 CONSTRAINT [PK_DM_QuocGia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[exportFbTemp]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[exportFbTemp](
	[UID_Chinh] [nvarchar](30) NULL,
	[id_baiviet] [nvarchar](60) NULL,
	[from_id] [nvarchar](100) NULL,
	[from_name] [nvarchar](100) NULL,
	[from_xac_nhan] [nvarchar](100) NULL,
	[message] [nvarchar](max) NULL,
	[story] [nvarchar](250) NULL,
	[type] [nvarchar](50) NULL,
	[status_type] [nvarchar](50) NULL,
	[description] [nvarchar](max) NULL,
	[List_Like] [nvarchar](max) NULL,
	[List_with_tags] [nvarchar](max) NULL,
	[story_tags] [xml] NULL,
	[created_time] [nvarchar](50) NULL,
	[update_time] [nvarchar](50) NULL,
	[is_hidden] [bit] NULL,
	[is_expired] [bit] NULL,
	[likes] [int] NULL,
	[comments] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FbAccount]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FbAccount](
	[id] [uniqueidentifier] NOT NULL CONSTRAINT [DF_FbAccount_id]  DEFAULT (newid()),
	[account] [varchar](50) NULL,
	[password] [nvarchar](100) NULL,
	[token] [nvarchar](400) NULL,
	[IsAct] [bit] NULL,
	[createdate] [datetime] NULL CONSTRAINT [DF_FbAccount_createdate]  DEFAULT (getdate()),
 CONSTRAINT [PK_FbAccount] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FbComments]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FbComments](
	[id] [uniqueidentifier] NOT NULL CONSTRAINT [DF_FbComments_id]  DEFAULT (newid()),
	[uid] [nvarchar](50) NULL,
	[feedid] [nvarchar](50) NULL,
	[commendId] [nvarchar](50) NULL,
	[message] [nvarchar](max) NULL,
	[from] [xml] NULL,
	[created_time] [nvarchar](50) NULL,
	[created_date] [datetime] NULL CONSTRAINT [DF_FbComments_created_date]  DEFAULT (getdate()),
 CONSTRAINT [PK_FbComments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FbFeed]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FbFeed](
	[id] [uniqueidentifier] NOT NULL CONSTRAINT [DF_FbFeed_id]  DEFAULT (newid()),
	[UID] [nvarchar](30) NULL,
	[feedid] [nvarchar](60) NULL,
	[from] [xml] NULL,
	[message] [nvarchar](max) NULL,
	[message_tags] [xml] NULL,
	[with_tags] [xml] NULL,
	[story] [nvarchar](250) NULL,
	[story_tags] [xml] NULL,
	[picture] [nvarchar](500) NULL,
	[link] [nvarchar](500) NULL,
	[name] [nvarchar](250) NULL,
	[description] [nvarchar](max) NULL,
	[actions] [xml] NULL,
	[privacy] [xml] NULL,
	[type] [nvarchar](50) NULL,
	[status_type] [nvarchar](50) NULL,
	[object_id] [nvarchar](50) NULL,
	[created_time] [nvarchar](50) NULL,
	[update_time] [nvarchar](50) NULL,
	[is_hidden] [bit] NULL,
	[is_expired] [bit] NULL,
	[likes] [int] NULL,
	[comments] [int] NULL,
	[create_date] [datetime] NULL CONSTRAINT [DF_FbFeed_create_date]  DEFAULT (getdate()),
 CONSTRAINT [PK_FbFeed] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FbFollow]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FbFollow](
	[id] [uniqueidentifier] NOT NULL,
	[UID] [nvarchar](30) NULL,
	[FollowUid] [nvarchar](30) NULL,
	[first_name] [nvarchar](100) NULL,
	[last_name] [nvarchar](100) NULL,
	[name_format] [nvarchar](50) NULL,
	[name] [nvarchar](200) NULL,
	[mobile_phone] [nvarchar](50) NULL,
	[birthday] [nchar](10) NULL,
	[email] [nvarchar](150) NULL,
	[gender] [nchar](10) NULL,
	[location] [xml] NULL,
	[age_range] [xml] NULL,
	[cover] [xml] NULL,
	[devices] [xml] NULL,
	[education] [xml] NULL,
	[favorite_athletes] [xml] NULL,
	[favorite_teams] [xml] NULL,
	[hometown] [xml] NULL,
	[install_type] [nvarchar](50) NULL,
	[installed] [bit] NULL,
	[interested_in] [xml] NULL,
	[is_verified] [bit] NULL,
	[languages] [xml] NULL,
	[link] [nvarchar](max) NULL,
	[locale] [nvarchar](300) NULL,
	[political] [nvarchar](max) NULL,
	[quotes] [nvarchar](max) NULL,
	[relationship_status] [nvarchar](50) NULL,
	[religion] [nvarchar](450) NULL,
	[sports] [xml] NULL,
	[third_party_id] [nvarchar](150) NULL,
	[website] [nvarchar](max) NULL,
	[work] [xml] NULL,
	[create_date] [datetime] NULL,
 CONSTRAINT [PK_FbFollow] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FbFriend]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FbFriend](
	[id] [uniqueidentifier] NOT NULL CONSTRAINT [DF_FbFriend_id]  DEFAULT (newid()),
	[UID] [nvarchar](30) NULL,
	[FriendUid] [nvarchar](30) NULL,
	[first_name] [nvarchar](100) NULL,
	[last_name] [nvarchar](100) NULL,
	[name_format] [nvarchar](50) NULL,
	[name] [nvarchar](200) NULL,
	[mobile_phone] [nvarchar](50) NULL,
	[birthday] [nchar](10) NULL,
	[email] [nvarchar](100) NULL,
	[gender] [nchar](10) NULL,
	[location] [xml] NULL,
	[age_range] [xml] NULL,
	[cover] [xml] NULL,
	[devices] [xml] NULL,
	[education] [xml] NULL,
	[favorite_athletes] [xml] NULL,
	[favorite_teams] [xml] NULL,
	[hometown] [xml] NULL,
	[install_type] [nvarchar](50) NULL,
	[installed] [bit] NULL,
	[interested_in] [xml] NULL,
	[is_verified] [bit] NULL,
	[languages] [xml] NULL,
	[link] [nvarchar](max) NULL,
	[locale] [nvarchar](300) NULL,
	[political] [nvarchar](max) NULL,
	[quotes] [nvarchar](max) NULL,
	[relationship_status] [nvarchar](50) NULL,
	[religion] [nvarchar](450) NULL,
	[sports] [xml] NULL,
	[third_party_id] [nvarchar](150) NULL,
	[website] [nvarchar](max) NULL,
	[work] [xml] NULL,
	[create_date] [datetime] NULL CONSTRAINT [DF_FbFriend_create_date]  DEFAULT (getdate()),
 CONSTRAINT [PK_FbFriend] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FbGUI]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FbGUI](
	[id] [uniqueidentifier] NOT NULL,
	[UID] [nvarchar](30) NULL,
	[name] [nvarchar](100) NULL,
	[description] [nvarchar](max) NULL,
	[email] [nvarchar](50) NULL,
	[icon] [nvarchar](400) NULL,
	[member_request_count] [int] NULL,
	[owner] [xml] NULL,
	[privacy] [nvarchar](50) NULL,
	[updated_time] [nvarchar](50) NULL,
	[create_date] [datetime] NULL,
 CONSTRAINT [PK_FbGUI] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FbLike]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FbLike](
	[id] [uniqueidentifier] NOT NULL CONSTRAINT [DF_FbLike_id]  DEFAULT (newid()),
	[uid] [nvarchar](30) NULL,
	[feedid] [nvarchar](60) NULL,
	[likeid] [nvarchar](30) NULL,
	[first_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NULL,
	[username] [nvarchar](150) NULL,
	[gender] [nvarchar](50) NULL,
	[link] [nvarchar](200) NULL,
	[location] [xml] NULL,
	[locale] [nvarchar](50) NULL,
	[updated_time] [nvarchar](50) NULL,
	[education] [xml] NULL,
	[favorite_athletes] [xml] NULL,
	[favorite_teams] [xml] NULL,
	[relationship_status] [nvarchar](50) NULL,
	[work] [xml] NULL,
	[can_post] [bit] NULL,
	[category] [nvarchar](150) NULL,
	[category_list] [xml] NULL,
	[cover] [xml] NULL,
	[has_added_app] [bit] NULL,
	[is_published] [bit] NULL,
	[likes] [int] NULL,
	[name] [nvarchar](150) NULL,
	[talking_about_count] [int] NULL,
	[were_here_count] [int] NULL,
	[create_date] [datetime] NULL CONSTRAINT [DF_FbLike_create_date_1]  DEFAULT (getdate()),
 CONSTRAINT [PK_FbLike] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FbLog]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FbLog](
	[id] [uniqueidentifier] NOT NULL CONSTRAINT [DF_FbLogCallApi_id]  DEFAULT (newid()),
	[account] [varchar](100) NULL,
	[command] [nvarchar](max) NULL,
	[create_date] [date] NULL CONSTRAINT [DF_FbLogCallApi_create_date]  DEFAULT (getdate()),
 CONSTRAINT [PK_FbLogCallApi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FbPage]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FbPage](
	[id] [uniqueidentifier] NOT NULL,
	[UID] [nvarchar](30) NULL,
	[name] [nvarchar](100) NULL,
	[app_links] [xml] NULL,
	[about] [nvarchar](250) NULL,
	[createdate] [datetime] NULL,
 CONSTRAINT [PK_FbPage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FbUID]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FbUID](
	[id] [uniqueidentifier] NOT NULL CONSTRAINT [DF_FbUID_id]  DEFAULT (newid()),
	[UID] [nvarchar](30) NULL,
	[name] [nvarchar](100) NULL,
	[age_ranges] [xml] NULL,
	[educations] [xml] NULL,
	[location] [xml] NULL,
	[mobile_phone] [varchar](50) NULL,
	[birthday] [nchar](10) NULL,
	[gender] [nchar](10) NULL,
	[locale] [varchar](50) NULL,
	[relationship_status] [varchar](50) NULL,
	[currency] [varchar](150) NULL,
	[email] [varchar](150) NULL,
	[cover] [xml] NULL,
	[devices] [xml] NULL,
	[work] [xml] NULL,
	[create_date] [datetime] NULL CONSTRAINT [DF_FbUID_create_date]  DEFAULT (getdate()),
 CONSTRAINT [PK_FbUID] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhomUID]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomUID](
	[id] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Nhom_id]  DEFAULT (newid()),
	[ParentId] [uniqueidentifier] NULL,
	[Name] [nvarchar](200) NULL,
	[UID] [nvarchar](30) NULL,
	[URD] [nvarchar](200) NULL,
	[Note] [nvarchar](50) NULL,
	[IsActi] [bit] NULL,
	[IsLoai] [int] NULL,
	[OrderID] [int] NULL,
	[CreateDate] [datetime] NULL CONSTRAINT [DF_DmNhom_CreateDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Nhom] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Regexs]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regexs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RegexName] [nvarchar](100) NULL,
	[Regex] [nvarchar](800) NULL,
	[Example] [nvarchar](500) NULL,
	[OrderID] [int] NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[FbFollow] ADD  CONSTRAINT [DF_FbFollow_id]  DEFAULT (newid()) FOR [id]
GO
ALTER TABLE [dbo].[FbFollow] ADD  CONSTRAINT [DF_FbFollow_create_date]  DEFAULT (getdate()) FOR [create_date]
GO
ALTER TABLE [dbo].[FbGUI] ADD  CONSTRAINT [DF_FbGUI_id]  DEFAULT (newid()) FOR [id]
GO
ALTER TABLE [dbo].[FbGUI] ADD  CONSTRAINT [DF_FbGUI_create_date]  DEFAULT (getdate()) FOR [create_date]
GO
ALTER TABLE [dbo].[FbPage] ADD  CONSTRAINT [DF_FbPage_id]  DEFAULT (newid()) FOR [id]
GO
ALTER TABLE [dbo].[FbPage] ADD  CONSTRAINT [DF_FbPage_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
/****** Object:  StoredProcedure [dbo].[spChuanHoa]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
--[spChuanHoa] 1
CREATE PROCEDURE [dbo].[spChuanHoa]
	@isKyTu int
AS
BEGIN
	if(@isKyTu=1) 
	begin
	update FbComments 	
		set message= REPLACE(REPLACE(message, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
			[from]= REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), [from]), CHAR(13), CHAR(32)),CHAR(10),CHAR(32))
	update FbFeed	
	set message= REPLACE(REPLACE(message, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		story= REPLACE(REPLACE(story, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		name= REPLACE(REPLACE(name, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		description= REPLACE(REPLACE(description, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		[from]= REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), [from]), CHAR(13), CHAR(32)),CHAR(10),CHAR(32))
	update FbFriend
	set  website = REPLACE(REPLACE(website, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		 location = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), location), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 education = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), education), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 favorite_athletes = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), favorite_athletes), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 favorite_teams = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), favorite_teams), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 languages = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), languages), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 quotes = REPLACE(REPLACE(quotes, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		 political = REPLACE(REPLACE(political, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		 relationship_status = REPLACE(REPLACE(relationship_status, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		 work = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), work), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 hometown = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), hometown), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 devices = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), devices), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 name = REPLACE(REPLACE(name, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		 first_name = REPLACE(REPLACE(first_name, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		 last_name = REPLACE(REPLACE(last_name, CHAR(13), CHAR(32)), CHAR(10), CHAR(32))

	update FbFollow
	set  website = REPLACE(REPLACE(website, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		 location = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), location), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 education = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), education), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 favorite_athletes = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), favorite_athletes), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 favorite_teams = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), favorite_teams), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 languages = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), languages), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 quotes = REPLACE(REPLACE(quotes, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		 political = REPLACE(REPLACE(political, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		 relationship_status = REPLACE(REPLACE(relationship_status, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		 work = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), work), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 hometown = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), hometown), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 devices = REPLACE(REPLACE (CONVERT(NVARCHAR(MAX), devices), CHAR(13), CHAR(32)),CHAR(10),CHAR(32)),
		 name = REPLACE(REPLACE(name, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		 first_name = REPLACE(REPLACE(first_name, CHAR(13), CHAR(32)), CHAR(10), CHAR(32)),
		 last_name = REPLACE(REPLACE(last_name, CHAR(13), CHAR(32)), CHAR(10), CHAR(32))
		 
		
		 
	end
end






GO
/****** Object:  StoredProcedure [dbo].[spDelDmGroupUIDAndInfo]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDelDmGroupUIDAndInfo]
@Id uniqueidentifier
AS
BEGIN
	DECLARE @Uid varchar(8000);
	/*dọn dep dữ liệu dm_hscty*/

	select @Uid=UID from NhomUID where id=@Id

	delete from FbFriend where UID=@Uid
	delete from FbComments where uid=@Uid
	delete from FbLike where uid =@Uid
	delete from FbPage where UID=@Uid
	delete from FbGUI where UID=@Uid
	delete from FbFeed where UID=@Uid
	delete from FbGUI where UID=@Uid
	delete from FbFollow where UID=@Uid

	delete from NhomUID where id=@Id

end





GO
/****** Object:  StoredProcedure [dbo].[spDelDmGroupUIDErr]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDelDmGroupUIDErr]
@ParentId uniqueidentifier
AS
BEGIN
	/*dọn dep dữ liệu dm_hscty*/
	
	delete from NhomUID 
	where ParentId=@ParentId and (UID='' or UID IS NULL)

end






GO
/****** Object:  StoredProcedure [dbo].[spDelInfo]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDelInfo]
@Id uniqueidentifier
AS
BEGIN
	DECLARE @Uid varchar(8000);
	/*dọn dep dữ liệu dm_hscty*/

	select @Uid=UID from NhomUID where id=@Id

	delete from FbFriend where UID=@Uid
	delete from FbComments where uid=@Uid
	delete from FbLike where uid =@Uid
	delete from FbPage where UID=@Uid
	delete from FbGUI where UID=@Uid
	delete from FbFeed where UID=@Uid
	delete from FbGUI where UID=@Uid
	delete from FbFollow where UID=@Uid
	

end






GO
/****** Object:  StoredProcedure [dbo].[spExportComment]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spExportComment]
	@uid varchar(30) = null,
	@databasename varchar(50),
	@path varchar(300)
AS
BEGIN
DECLARE @NAMES NVARCHAR(max)
	
	
	IF OBJECT_ID('dbo.exportFbTemp', 'U') IS NOT NULL 
	DROP TABLE dbo.exportFbTemp; 

	select 
	fee.UID as UID_Chinh,
	fee.feedid ,
	fee.message as message_baiviet,
	fee.description,is_hidden,is_expired,likes,comments,
	Tabfrom.Colfrom.value('id[1]', 'nvarchar(100)') as from_id_commend,
	Tabfrom.Colfrom.value('name[1]', 'nvarchar(100)') as from_name_commend,
	Tabfrom.Colfrom.value('is_verified[1]', 'nvarchar(100)') as from_xac_nhan_commend,
	b.message as message_comment, b.created_time as commend_create
	into exportFbTemp
	from  FbFeed fee inner join FbComments b on fee.feedid=b.feedid and fee.uid=b.uid
		 OUTER  APPLY b.[from].nodes('from') TabFrom(ColFrom)
	where fee.UID= @uid

	DECLARE @strCommand varchar(100);
	
	set @strCommand ='select  * from '+@databasename+ '.dbo.exportFbTemp order by feedid';

	DECLARE @sql varchar(8000);
	SELECT @sql = 'bcp "'+@strCommand+'" queryout "'+@path  + '" -w -t"\t" -T -S' + @@SERVERNAME 

	print @sql
	exec master..xp_cmdshell @sql;	

			

end





GO
/****** Object:  StoredProcedure [dbo].[spExportFeed]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spExportFeed]
	@uid varchar(30) = null
AS
BEGIN
DECLARE @NAMES NVARCHAR(max)
--select * from FbFeed

		/*ham này này chỉ lấy one (lưu code)*/
		--select ROW_NUMBER() OVER(ORDER BY name ASC) AS stt,UID ,	feedid,
		--TabWith.ColWith.value('(with_tags_data[1]/name)[1]', 'nvarchar(200)') as name --into #temp1
		--from FbFeed fr
		--CROSS  APPLY fr.with_tags.nodes('with_tags/data') TabWith(ColWith) 

		select ROW_NUMBER() OVER(ORDER BY name ASC) AS stt,UID ,	feedid,
		TabWith.ColWith.value('(name)[1]', 'nvarchar(200)') as name  into #temp1
		from FbFeed fr
			OUTER  APPLY fr.with_tags.nodes('with_tags/data/with_tags_data') TabWith(ColWith) 
		order by feedid

		--select * from #temp1
		--drop table #temp1
		SELECT DISTINCT c1.uid, c1.feedid, 
		STUFF(( SELECT  '; uid=' +c2.UID +' - '+ c2.name
                    FROM    #temp1 c2
                    WHERE   c1.feedid = c2.feedid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS listWith_Tags into #with_tags_data
		FROM #temp1 c1
		drop table #temp1

		--select * from #with_tags_data
		select fee.uid as uid_main, fee.feedid,
		TabWith.ColWith.value('(id[1])[1]', 'nvarchar(20)') as Uid_NguoiVietBai,
		TabWith.ColWith.value('(name[1])[1]', 'nvarchar(200)') as Name_NguoiVietBai,
		fee.message as NoiDungBaiViet, listWith_Tags as TagsWith,
		[picture],[link],[name],[description],[status_type],[object_id],[update_time],[likes],[comments] into #FbFeed
		from FbFeed as fee inner join #with_tags_data tags on fee.UID= tags.UID and fee.feedid= tags.feedid
			OUTER  APPLY fee.[from].nodes('from') TabWith(ColWith)
		
		--select * from #FbFeed

			SELECT DISTINCT c1.uid, c1.feedid, 
		STUFF(( SELECT  '; uid=' +c2.UID +' - '+ c2.name
                    FROM    FbLike c2
                    WHERE   c1.feedid = c2.feedid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS listLike into #FbLike
		FROM FbLike c1 inner join #FbFeed fee on c1.feedid= fee.feedid

		select fee.*,lik.listLike,comm.message as messagecomment,
		Tabfrom.Colfrom.value('(id[1])[1]', 'nvarchar(20)') as uid_comment,
		Tabfrom.Colfrom.value('(name[1])[1]', 'nvarchar(200)') as name_comment,
		comm.created_time as thoigian_comment
		from #FbFeed fee inner join #FbLike lik on fee.feedid=lik.feedid and fee.uid_main=lik.uid
						 inner join FbComments comm on lik.feedid=comm.feedid and lik.uid= comm.uid
						 OUTER  APPLY comm.[from].nodes('from') Tabfrom(Colfrom)


end





GO
/****** Object:  StoredProcedure [dbo].[spExportFeed_bk]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spExportFeed_bk]
	@uid varchar(30) = null
AS
BEGIN
DECLARE @NAMES NVARCHAR(max)
--select * from FbFeed

		/*ham này này chỉ lấy one (lưu code)*/
		--select ROW_NUMBER() OVER(ORDER BY name ASC) AS stt,UID ,	feedid,
		--TabWith.ColWith.value('(with_tags_data[1]/name)[1]', 'nvarchar(200)') as name --into #temp1
		--from FbFeed fr
		--CROSS  APPLY fr.with_tags.nodes('with_tags/data') TabWith(ColWith) 

		select ROW_NUMBER() OVER(ORDER BY name ASC) AS stt,UID ,	feedid,
		TabWith.ColWith.value('(name)[1]', 'nvarchar(200)') as name  into #temp1
		from FbFeed fr
			OUTER  APPLY fr.with_tags.nodes('with_tags/data/with_tags_data') TabWith(ColWith) 
		order by feedid

		--select * from #temp1
		--drop table #temp1
		SELECT DISTINCT c1.uid, c1.feedid, 
		STUFF(( SELECT  '; uid=' +c2.UID +' - '+ c2.name
                    FROM    #temp1 c2
                    WHERE   c1.feedid = c2.feedid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS listWith_Tags into #with_tags_data
		FROM #temp1 c1
		drop table #temp1

		--select * from #with_tags_data
		select fee.uid as uid_main, fee.feedid,
		TabWith.ColWith.value('(id[1])[1]', 'nvarchar(20)') as Uid_NguoiVietBai,
		TabWith.ColWith.value('(name[1])[1]', 'nvarchar(200)') as Name_NguoiVietBai,
		fee.message as NoiDungBaiViet, listWith_Tags as TagsWith,
		[picture],[link],[name],[description],[status_type],[object_id],[update_time],[likes],[comments] into #FbFeed
		from FbFeed as fee inner join #with_tags_data tags on fee.UID= tags.UID and fee.feedid= tags.feedid
			OUTER  APPLY fee.[from].nodes('from') TabWith(ColWith)
		
		--select * from #FbFeed

			SELECT DISTINCT c1.uid, c1.feedid, 
		STUFF(( SELECT  '; uid=' +c2.UID +' - '+ c2.name
                    FROM    FbLike c2
                    WHERE   c1.feedid = c2.feedid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS listLike into #FbLike
		FROM FbLike c1 inner join #FbFeed fee on c1.feedid= fee.feedid

		select fee.*,lik.listLike,comm.message as messagecomment,
		Tabfrom.Colfrom.value('(id[1])[1]', 'nvarchar(20)') as uid_comment,
		Tabfrom.Colfrom.value('(name[1])[1]', 'nvarchar(200)') as name_comment,
		comm.created_time as thoigian_comment
		from #FbFeed fee inner join #FbLike lik on fee.feedid=lik.feedid and fee.uid_main=lik.uid
						 inner join FbComments comm on lik.feedid=comm.feedid and lik.uid= comm.uid
						 OUTER  APPLY comm.[from].nodes('from') Tabfrom(Colfrom)


end





GO
/****** Object:  StoredProcedure [dbo].[spExportFollow]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spExportFollow]
	@uid varchar(30) = null,
	@locale varchar(8)=null,
	@gender varchar(10)=null,
	@databasename varchar(50),
	@path varchar(300)
AS
BEGIN

IF OBJECT_ID('dbo.exportFbTemp', 'U') IS NOT NULL 
	DROP TABLE dbo.exportFbTemp; 
	
	
		/*----------Education--------------*/
		SELECT DISTINCT c1.uid, c1.FollowUid,'"'+
		STUFF(( SELECT  '"type"' +' ' +'"'+ isnull(TabEducation.ColEducation.value('(type)[1]', 'nvarchar(100)') +'" ','""') +'"'
									      + isnull(TabEducation.ColEducation.value('(school/name)[1]', 'nvarchar(200)') +'" ','""')
                    FROM    FbFollow c2
						OUTER  APPLY c2.education.nodes('ArrayOfEducation/education') TabEducation(ColEducation)
                    WHERE   c1.FollowUid = c2.FollowUid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_Education into #education
		FROM FbFollow c1 where c1.education is not null
		/*------------------location------------------*/
		select ROW_NUMBER() OVER(ORDER BY name ASC) AS stt,UID ,	FollowUid,
		TabLoca.ColLoca.value('name[1]', 'nvarchar(100)') as diachi,
		dbo.GetInfoDiaChi(TabLoca.ColLoca.value('name[1]', 'nvarchar(100)'),'nuoc') as QuocGia,
		dbo.GetInfoDiaChi(TabLoca.ColLoca.value('name[1]', 'nvarchar(100)'),'tinh') as Tinh,
		dbo.GetInfoDiaChi(TabLoca.ColLoca.value('name[1]', 'nvarchar(100)'),'huyen') as Huyen into #location
		from FbFollow fr
			CROSS  APPLY fr.location.nodes('location') TabLoca(ColLoca) 
		where fr.location is not null

		/***********************favorite_athletes******************************/
		SELECT  c1.uid, c1.FollowUid,'"'+
		STUFF(( SELECT '"'+ Tabathletes.Colathletes.value('(name)[1]', 'nvarchar(200)') +'" '
                    FROM    FbFollow c2
						OUTER  APPLY c2.favorite_athletes.nodes('ArrayOfFavorite_athletes/favorite_athletes') Tabathletes(Colathletes)
                    WHERE   c1.FollowUid = c2.FollowUid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_Favorite_athletes into #favorite_athletes
		FROM FbFollow c1 where c1.favorite_athletes is not null
		/*************************favorite_teams***********************/
		SELECT  c1.uid, c1.FollowUid,'"'+
		STUFF(( SELECT '"'+ Tabathletes.Colathletes.value('(name)[1]', 'nvarchar(200)') +'" '
                    FROM    FbFollow c2
						OUTER  APPLY c2.favorite_teams.nodes('ArrayOfFavorite_teams/favorite_teams') Tabathletes(Colathletes)
                    WHERE   c1.FollowUid = c2.FollowUid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_Favorite_teams into #favorite_teams
		FROM FbFollow c1 where c1.favorite_teams is not null
		/********************************************************/

		SELECT  c1.uid, c1.FollowUid,'"'+
		STUFF(( SELECT '"'+ 
							+'start_date:' + isnull(Tabwork.Colwork.value('(start_date)[1]', 'nvarchar(20)'),'')  +'" '
							+ N'Làm Việc Tại:'+isnull(Tabwork.Colwork.value('(employer/name)[1]', 'nvarchar(200)'),'')  +'" '
                    
					FROM    FbFollow c2
						OUTER  APPLY c2.work.nodes('ArrayOfWork/work') Tabwork(Colwork)
                    WHERE   c1.FollowUid = c2.FollowUid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_Work into #work
		FROM FbFollow c1 where c1.work is not null
		/****************************************************/
		SELECT  c1.uid, c1.FollowUid,'"'+
		STUFF(( SELECT '"'+ isnull(Tabwork.Colwork.value('(name)[1]', 'nvarchar(200)'),'')  +'" '
					FROM    FbFollow c2
						OUTER  APPLY c2.work.nodes('ArrayOfSports/sports') Tabwork(Colwork)
                    WHERE   c1.FollowUid = c2.FollowUid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_Sports into #sports
		FROM FbFollow c1 where c1.sports is not null
		
		/*****************************************************/
			SELECT  c1.uid, c1.FollowUid,'"'+
		STUFF(( SELECT '"'	+ isnull(Tabdevices.Coldevices.value('(hardware)[1]', 'nvarchar(200)'),'')  +'" ' 
						+'"'	+ isnull(Tabdevices.Coldevices.value('(os)[1]', 'nvarchar(200)'),'')  +'" '
					FROM    FbFollow c2
						OUTER  APPLY c2.devices.nodes('ArrayOfDevices/devices') Tabdevices(Coldevices)
                    WHERE   c1.FollowUid = c2.FollowUid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_Devices into #devices
		FROM FbFollow c1 where c1.devices is not null

		select fr.UID as uid_quet, fr.FollowUid, first_name, last_name, name, last_name+' '+first_name as name_full,
				mobile_phone,birthday, isnull(dbo.GetYear(birthday),'') as birthday_year, 
				isnull(dbo.ConvertLanguage(fr.gender,'gender'),'') as gender,email,
				
				loc.diachi as Location, 
				loc.Huyen as Location_huyen,
				loc.Tinh as Location_tinh ,
				loc.QuocGia as Location_QuocGia, 
				locale as Locale_Ma,
				
								 TabHometown.ColHometown.value('name[1]', 'nvarchar(100)') as Hometown,
				dbo.GetInfoDiaChi(TabHometown.ColHometown.value('name[1]', 'nvarchar(100)'),'nuoc') as Hometown_QuocGia,
				dbo.GetInfoDiaChi(TabHometown.ColHometown.value('name[1]', 'nvarchar(100)'),'tinh') as Hometown_Tinh,
				dbo.GetInfoDiaChi(TabHometown.ColHometown.value('name[1]', 'nvarchar(100)'),'huyen') as Hometown_Huyen,

				install_type,installed,quotes, relationship_status, religion,website,political,de.List_Devices,
				ath.List_Favorite_athletes ,teams.List_Favorite_teams,w.List_Work,link as LinkFb,ed.List_Education,
				sp.List_Sports
			INTO exportFbTemp	
		from FbFollow fr left join #education ed on fr.uid=ed.uid and fr.FollowUid=ed.FollowUid
						 left join #location loc on fr.uid=loc.uid and fr.FollowUid=loc.FollowUid
						 left join #favorite_athletes ath on fr.uid=ath.uid and fr.FollowUid=ath.FollowUid
						 left join #favorite_teams teams on fr.uid=teams.uid and fr.FollowUid=teams.FollowUid
						 left join #work w on fr.uid=w.uid and fr.FollowUid=w.FollowUid
						 left join #sports sp on fr.uid=sp.uid and fr.FollowUid=sp.FollowUid
						 left join #devices de on fr.UID=de.UID and fr.FollowUid=de.FollowUid
						 CROSS  APPLY fr.hometown.nodes('Hometown') TabHometown(ColHometown) 
		where (fr.FollowUid =@uid or @uid is null) and
			  (fr.locale=@locale or @locale is null) and
			  (fr.gender= @gender or @gender is null)
			  
			  
	DECLARE @strCommand varchar(100);
	set @strCommand ='select  * from '+@databasename+ '.dbo.exportFbTemp order by FollowUid';

	DECLARE @sql varchar(8000);
	SELECT @sql = 'bcp "'+@strCommand+'" queryout "'+@path  + '" -w -t"\t" -T -S' + @@SERVERNAME 
	

	print @sql
	exec master..xp_cmdshell @sql;	
			
end









GO
/****** Object:  StoredProcedure [dbo].[spExportFriend]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spExportFriend]
	@uid varchar(30) = null,
	@locale varchar(8)=null,
	@gender varchar(10)=null,
	@databasename varchar(50),
	@path varchar(300)
AS
BEGIN

IF OBJECT_ID('dbo.exportFbTemp', 'U') IS NOT NULL 
	DROP TABLE dbo.exportFbTemp; 


		/*----------Education--------------*/
		SELECT DISTINCT c1.uid, c1.FriendUid,'"'+
		STUFF(( SELECT  '"type"' +' ' +'"'+ isnull(TabEducation.ColEducation.value('(type)[1]', 'nvarchar(100)') +'" ','""') +'"'
									      + isnull(TabEducation.ColEducation.value('(school/name)[1]', 'nvarchar(200)') +'" ','""')
                    FROM    FbFriend c2
						OUTER  APPLY c2.education.nodes('ArrayOfEducation/education') TabEducation(ColEducation)
                    WHERE   c1.FriendUid = c2.FriendUid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_Education into #education
		FROM FbFriend c1 where c1.education is not null
		/*------------------location------------------*/
		select ROW_NUMBER() OVER(ORDER BY name ASC) AS stt,UID ,	FriendUid,
		TabLoca.ColLoca.value('name[1]', 'nvarchar(100)') as diachi,
		dbo.GetInfoDiaChi(TabLoca.ColLoca.value('name[1]', 'nvarchar(100)'),'nuoc') as QuocGia,
		dbo.GetInfoDiaChi(TabLoca.ColLoca.value('name[1]', 'nvarchar(100)'),'tinh') as Tinh,
		dbo.GetInfoDiaChi(TabLoca.ColLoca.value('name[1]', 'nvarchar(100)'),'huyen') as Huyen into #location
		from FbFriend fr
			CROSS  APPLY fr.location.nodes('location') TabLoca(ColLoca) 
		where fr.location is not null

		/***********************favorite_athletes******************************/
		SELECT  c1.uid, c1.FriendUid,'"'+
		STUFF(( SELECT '"'+ Tabathletes.Colathletes.value('(name)[1]', 'nvarchar(200)') +'" '
                    FROM    FbFriend c2
						OUTER  APPLY c2.favorite_athletes.nodes('ArrayOfFavorite_athletes/favorite_athletes') Tabathletes(Colathletes)
                    WHERE   c1.FriendUid = c2.FriendUid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_Favorite_athletes into #favorite_athletes
		FROM FbFriend c1 where c1.favorite_athletes is not null
		/*************************favorite_teams***********************/
		SELECT  c1.uid, c1.FriendUid,'"'+
		STUFF(( SELECT '"'+ Tabathletes.Colathletes.value('(name)[1]', 'nvarchar(200)') +'" '
                    FROM    FbFriend c2
						OUTER  APPLY c2.favorite_teams.nodes('ArrayOfFavorite_teams/favorite_teams') Tabathletes(Colathletes)
                    WHERE   c1.FriendUid = c2.FriendUid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_Favorite_teams into #favorite_teams
		FROM FbFriend c1 where c1.favorite_teams is not null
		/********************************************************/

		SELECT  c1.uid, c1.FriendUid,'"'+
		STUFF(( SELECT '"'+ 
							+'start_date:' + isnull(Tabwork.Colwork.value('(start_date)[1]', 'nvarchar(20)'),'')  +'" '
							+ N'Làm Việc Tại:'+isnull(Tabwork.Colwork.value('(employer/name)[1]', 'nvarchar(200)'),'')  +'" '
                    
					FROM    FbFriend c2
						OUTER  APPLY c2.work.nodes('ArrayOfWork/work') Tabwork(Colwork)
                    WHERE   c1.FriendUid = c2.FriendUid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_Work into #work
		FROM FbFriend c1 where c1.work is not null
		/****************************************************/
		SELECT  c1.uid, c1.FriendUid,'"'+
		STUFF(( SELECT '"'+ isnull(Tabwork.Colwork.value('(name)[1]', 'nvarchar(200)'),'')  +'" '
					FROM    FbFriend c2
						OUTER  APPLY c2.work.nodes('ArrayOfSports/sports') Tabwork(Colwork)
                    WHERE   c1.FriendUid = c2.FriendUid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_Sports into #sports
		FROM FbFriend c1 where c1.sports is not null
		/***************************************************/
		SELECT  c1.uid, c1.FriendUid,'"'+
		STUFF(( SELECT '"'	+ isnull(Tabdevices.Coldevices.value('(hardware)[1]', 'nvarchar(200)'),'')  +'" ' 
						+'"'	+ isnull(Tabdevices.Coldevices.value('(os)[1]', 'nvarchar(200)'),'')  +'" '
					FROM    FbFriend c2
						OUTER  APPLY c2.devices.nodes('ArrayOfDevices/devices') Tabdevices(Coldevices)
                    WHERE   c1.FriendUid = c2.FriendUid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_Devices into #devices
		FROM FbFriend c1 where c1.devices is not null

	

		select fr.UID as uid_quet, fr.FriendUid, first_name, last_name, name, last_name+' '+first_name as name_full,
				mobile_phone,birthday, isnull(dbo.GetYear(birthday),'') as birthday_year, 
				isnull(dbo.ConvertLanguage(fr.gender,'gender'),'') as gender,email,
				
				loc.diachi as Location, 
				loc.Huyen as Location_huyen,
				loc.Tinh as Location_tinh ,
				loc.QuocGia as Location_QuocGia, 
				locale as Locale_Ma,
				
								 TabHometown.ColHometown.value('name[1]', 'nvarchar(100)') as Hometown,
				dbo.GetInfoDiaChi(TabHometown.ColHometown.value('name[1]', 'nvarchar(100)'),'nuoc') as Hometown_QuocGia,
				dbo.GetInfoDiaChi(TabHometown.ColHometown.value('name[1]', 'nvarchar(100)'),'tinh') as Hometown_Tinh,
				dbo.GetInfoDiaChi(TabHometown.ColHometown.value('name[1]', 'nvarchar(100)'),'huyen') as Hometown_Huyen,

				install_type,installed,quotes, relationship_status, religion,website,political,de.List_Devices,
				ath.List_Favorite_athletes ,teams.List_Favorite_teams,w.List_Work,link as LinkFb,ed.List_Education,
				sp.List_Sports
		into exportFbTemp
		from FbFriend fr left join #education ed on fr.uid=ed.uid and fr.FriendUid=ed.FriendUid
						 left join #location loc on fr.uid=loc.uid and fr.FriendUid=loc.FriendUid
						 left join #favorite_athletes ath on fr.uid=ath.uid and fr.FriendUid=ath.FriendUid
						 left join #favorite_teams teams on fr.uid=teams.uid and fr.FriendUid=teams.FriendUid
						 left join #work w on fr.uid=w.uid and fr.FriendUid=w.FriendUid
						 left join #sports sp on fr.uid=sp.uid and fr.FriendUid=sp.FriendUid
						 left join #devices de on fr.UID=de.UID and fr.FriendUid=de.FriendUid
						 CROSS  APPLY fr.hometown.nodes('Hometown') TabHometown(ColHometown) 
		where (fr.FriendUid =@uid or @uid is null or @uid='-1') and
			  (fr.locale=@locale or @locale is null or @locale='-1') and
			  (fr.gender= @gender or @gender is null or @gender='-1')


		
	DECLARE @strCommand varchar(100);
	set @strCommand ='select  * from '+@databasename+ '.dbo.exportFbTemp order by FollowUid';

	DECLARE @sql varchar(8000);
	SELECT @sql = 'bcp "'+@strCommand+'" queryout "'+@path  + '" -w -t"\t" -T -S' + @@SERVERNAME 
	

	print @sql
	exec master..xp_cmdshell @sql;	

end








GO
/****** Object:  StoredProcedure [dbo].[spExportLike]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spExportLike]
	@uid varchar(30) = null,
	@databasename varchar(50),
	@path varchar(300)
AS
BEGIN

	
	SELECT DISTINCT c1.uid, c1.feedid, +'"'+
		STUFF(( SELECT  '"' +c2.UID +':'+ c2.name +'" '
                    FROM    FbLike c2
                    WHERE   c1.feedid = c2.feedid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_Like into #List_Like
	FROM FbLike c1 inner join FbFeed fee on c1.feedid= fee.feedid


	SELECT DISTINCT c1.uid, c1.feedid,'"'+
		STUFF(( SELECT  '"'+ isnull(TabEducation.ColEducation.value('(id)[1]', 'nvarchar(100)') ,'') +' '
									      + isnull(TabEducation.ColEducation.value('(name)[1]', 'nvarchar(200)') +'" ','')
                    FROM    FbFeed c2
						OUTER  APPLY c2.with_tags.nodes('with_tags/data/with_tags_data') TabEducation(ColEducation)
                    WHERE   c1.feedid = c2.feedid and
							c1.UID= c2.UID
                          
                  FOR
                    XML PATH('')
                  ), 1, 1, '') AS List_with_tags into #with_tags
		FROM FbFeed c1 where c1.with_tags is not null



	IF OBJECT_ID('dbo.exportFbTemp', 'U') IS NOT NULL 
	DROP TABLE dbo.exportFbTemp; 

	select 
	fr.UID as UID_Chinh,
	fr.feedid as feedid,
	Tabfrom.Colfrom.value('id[1]', 'nvarchar(100)') as from_id,
	Tabfrom.Colfrom.value('name[1]', 'nvarchar(100)') as from_name,
	Tabfrom.Colfrom.value('is_verified[1]', 'nvarchar(100)') as from_xac_nhan,
	message,story,fr.type,fr.status_type,fr.description,li.List_Like,
	tags.List_with_tags,story_tags,fr.created_time,fr.update_time,is_hidden,is_expired,likes,comments 
	into exportFbTemp
	from FbFeed fr	left join #List_Like li on fr.uid=li.uid and fr.feedid=li.feedid
					left join #with_tags tags on fr.uid=tags.uid and fr.feedid=tags.feedid
					 CROSS  APPLY fr.[from].nodes('from') Tabfrom(Colfrom) 
	where fr.UID= @uid

	
	DECLARE @strCommand varchar(100);
	set @strCommand ='select * from '+@databasename+ '.dbo.exportFbTemp order by feedid';

	DECLARE @sql varchar(8000);
	SELECT @sql = 'bcp "'+@strCommand+'" queryout "'+@path  + '" -w -t"\t" -T -S' + @@SERVERNAME 

	print @sql
	exec master..xp_cmdshell @sql;


end





GO
/****** Object:  StoredProcedure [dbo].[spExportUID]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spExportUID]
	@uid varchar(30) = null
AS
BEGIN
	
	select uid as uid_of_main,
		   name as name_of_main,
	[age_ranges].value('(/age_range/min)[1]', 'nvarchar(2)') age_of_main,
	--TabEdu.ColEdu.value('id[1]', 'nvarchar(20)') as id,
    TabEdu.ColEdu.value('type[1]', 'nvarchar(200)') as type_educations_of_main,
	TabEdu.ColEdu.value('(school[1]/name)[1]', 'nvarchar(200)') as School_of_main,
	[location].value('(/location/name)[1]', 'nvarchar(100)') QueQuanof_main,
	mobile_phone, birthday, gender, locale, relationship_status, currency, email,
	TabWork.ColWork.value('start_date[1]', 'nvarchar(200)') as start_date_Congtac,
	TabWork.ColWork.value('(employer[1]/name)[1]', 'nvarchar(200)') as NoiCongTac into #FbUID
	from dbo.FbUID yt 
			CROSS APPLY yt.educations.nodes('ArrayOfEducation/education') TabEdu(ColEdu) 
			CROSS APPLY yt.work.nodes('ArrayOfWork/work') TabWork(ColWork) 

	select UID,
		[FriendUid] , first_name,last_name , name , mobile_phone ,birthday , email , gender 
	from FbFriend fr


--select * from FbUID

end





GO
/****** Object:  StoredProcedure [dbo].[spLoadToken]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLoadToken]
@isShowAll bit =null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET DATEFORMAT DMY
	

	DECLARE @fbLimitCallApi int;
	select top 1 @fbLimitCallApi= LimitCallApi from CauHinh

	update FbAccount set IsAct=1
	update FbAccount set IsAct=0 where (token is null or token ='')

	update FbAccount
	set IsAct =0
	where account in(select account
					 from FbLog
				     where Convert(date,create_date) = CONVERT(date, GETDATE())
					 GROUP BY account
					 HAVING COUNT(account) > @fbLimitCallApi)

	

	select a.*,dagoi=isnull((select count(*)
					 from FbLog
				     where create_date = CONVERT(date, GETDATE())
					 and FbLog.account= a.account
					 GROUP BY account
					 ),0),
			conlai=0,
			gioihan=@fbLimitCallApi 

	into #FbAccount from FbAccount a

	

	update #FbAccount
	set conlai = isnull(gioihan,0)-isnull(dagoi,0)

	select ROW_NUMBER() OVER (Order by createdate) AS stt,* 
	from #FbAccount
	where (@isShowAll is null) or IsAct = @isShowAll
	order by dagoi asc

	


	

end

GO
/****** Object:  StoredProcedure [dbo].[spLocTrungNhomUID]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--[spLocTrungNhomUID] null
CREATE PROCEDURE [dbo].[spLocTrungNhomUID]
@ParentId uniqueidentifier
AS
BEGIN
	/*dọn dep dữ liệu dm_hscty*/
	
	
	/*--------------don dep cac ky tự xuống dòng-----------------*/
	

	/*************************************************************************************************
	/*dọn dep hồ sơ công ty*/       
	*************************************************************************************************/
	;WITH cte AS
	(
		SELECT *,
	    ROW_NUMBER() OVER (PARTITION BY [UID] ORDER BY createdate DESC) AS rn
		FROM [dbo].[NhomUID]
		WHERE ParentId =@ParentId
	)
	SELECT * into #danhsachtrung
	FROM cte
	WHERE rn = 1
	
	delete from [dbo].[NhomUID] WHERE ParentId =@ParentId

	Insert into [dbo].[NhomUID](ParentId, Name, UID, URD, Note, IsActi, IsLoai, OrderID)
	select ParentId, Name, UID, URD, Note, IsActi, IsLoai, OrderID
	from #danhsachtrung
	
end




GO
/****** Object:  StoredProcedure [dbo].[spToken]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spToken]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET DATEFORMAT DMY
	

	DECLARE @fbLimitCallApi int;
	DECLARE @fbtoken NVARCHAR(4000);
	select top 1 @fbLimitCallApi= LimitCallApi from CauHinh

	update FbAccount set IsAct=1
	update FbAccount set IsAct=0 where (token is null or token ='')

	update FbAccount
	set IsAct =0
	where account in(select account
					 from FbLog
				     where Convert(date,create_date) = CONVERT(date, GETDATE())
					 GROUP BY account
					 HAVING COUNT(account) > @fbLimitCallApi)


	 --select @fbtoken = token from FbAccount where IsAct=1  order by createdate
     --select @fbtoken
	 select *,sl= (select count(*) from FbLog b where a.account =b.account and Convert(date,create_date) = CONVERT(date, GETDATE())) ,maxx =@fbLimitCallApi
	 from FbAccount a 
	 where IsAct=1  
	 order by  (select count(*) from FbLog b where a.account =b.account) asc

	


end

GO
/****** Object:  StoredProcedure [dbo].[spXuatFileNhanhPhoneEmail]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spXuatFileNhanhPhoneEmail] 
	@UID nvarchar(50) =null
AS
BEGIN
	;WITH cte AS(
	select	uid,
			isnull(message,'') +' '+ 
			isnull([from].value('(/from/mobile_phone)[1]', 'nvarchar(20)'),' ')  +' '+
			isnull([from].value('(/from/email)[1]', 'nvarchar(20)'),' ')
			as [message],'' as phone, '' as email from FbComments 
	union 
	select	uid,
					 isnull(message,'') +' '+ 
					 isnull([from].value('(/from/mobile_phone)[1]', 'nvarchar(20)'),'') +' '+
					 isnull([from].value('(/from/email)[1]', 'nvarchar(100)'),'') +' '+
					 isnull(story,'') +' '+ 
					 isnull(name,'') +' '+ 
					 isnull(description,'') as [message] , '' as phone, '' as email from FbFeed
	union 
	select			uid,
					isnull(mobile_phone,'')  + ' ' +
					isnull(email,'') as [message], '' as phone, '' as email from FbFriend
	union 
	select			uid,
					isnull(email,'')  + ' ' +
					isnull(description,'') as [message], '' as phone, '' as email from FbGUI
	union 
	select			uid,
					isnull(name,'')  + ' ' +
					isnull(about,'') as [message], '' as phone, '' as email from FbPage

	union 
	select			uid,
					isnull(mobile_phone,'')  + ' ' +
					isnull(email,'') as [message], '' as phone, '' as email from FbFollow
	)
	SELECT distinct RTRIM(LTRIM(message)) as message,phone,email  FROM cte
	WHERE (UID = @uid or @uid is null)

end






GO
/****** Object:  StoredProcedure [dbo].[spXuatFileNhanhUID]    Script Date: 5/19/2018 11:12:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spXuatFileNhanhUID]
	@uid varchar(30) = null,
	@databasename varchar(50),
	@path varchar(300)
AS
BEGIN
	IF OBJECT_ID('dbo.exportFbTemp', 'U') IS NOT NULL 
	DROP TABLE dbo.exportFbTemp; 

	;WITH cte AS(
	select uid,name from FbUID WHERE (UID = @uid or @uid is null)
	union 
	select uid,name from FbGUI WHERE (UID = @uid or @uid is null)
	union
	select uid,name from FbPage WHERE (UID = @uid or @uid is null)
	union
	select	[from].value('(/from/id)[1]', 'nvarchar(30)') UID,
			[from].value('(/from/name)[1]', 'nvarchar(200)') name
	from FbComments a  WHERE (a.uid = @uid or @uid is null)
	union
	select FollowUid,name from FbFollow WHERE (uid = @uid or @uid is null)
	union
	select likeid,name from FbLike WHERE (uid = @uid or @uid is null)
	union
	select FriendUid,name from FbFriend WHERE (uid = @uid or @uid is null)
	union
	select	[from].value('(/from/id)[1]', 'nvarchar(30)') UID,
			[from].value('(/from/name)[1]', 'nvarchar(200)') name
	from FbFeed a 
	WHERE (a.uid = @uid or @uid is null)
	union
	select  TabWith.ColWith.value('(id)[1]', 'varchar(20)') as uid  ,
			TabWith.ColWith.value('(name)[1]', 'nvarchar(200)') as name  
	from FbFeed fr
			OUTER  APPLY fr.with_tags.nodes('with_tags/data/with_tags_data') TabWith(ColWith) 
	where fr.with_tags is not null and (fr.uid = @uid or @uid is null)
	)
	SELECT distinct * into exportFbTemp  FROM cte
	--WHERE (UID = @uid or @uid is null)


	DECLARE @strCommand varchar(100);
	set @strCommand ='select  * from '+@databasename+ '.dbo.exportFbTemp order by name';

	DECLARE @sql varchar(8000);
	SELECT @sql = 'bcp "'+@strCommand+'" queryout "'+@path  + '" -w -t"\t" -T -S' + @@SERVERNAME 
	

	print @sql
	exec master..xp_cmdshell @sql;	

		
end






GO
USE [master]
GO
ALTER DATABASE [Facebook] SET  READ_WRITE 
GO
