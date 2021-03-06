USE [banka]
GO
/****** Object:  Table [dbo].[Banka]    Script Date: 23.4.2019 23:00:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banka](
	[M_No] [int] NULL,
	[SubeKodu] [int] NULL,
	[IslemNo] [int] NULL,
	[Tarih] [datetimeoffset](7) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hareketler]    Script Date: 23.4.2019 23:00:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hareketler](
	[M_No] [int] NULL,
	[IslemAdi] [nvarchar](100) NULL,
	[Tutar] [nvarchar](100) NULL,
	[Tarih] [datetimeoffset](7) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Islemler]    Script Date: 23.4.2019 23:00:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Islemler](
	[IslemNo] [int] IDENTITY(1,1) NOT NULL,
	[IslemAdi] [nvarchar](300) NULL,
 CONSTRAINT [PK_Islemler] PRIMARY KEY CLUSTERED 
(
	[IslemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 23.4.2019 23:00:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[M_No] [int] IDENTITY(1,1) NOT NULL,
	[Tc] [bigint] NULL,
	[AdSoyad] [nvarchar](250) NULL,
	[DogumTarihi] [date] NULL,
	[DogumYeri] [nvarchar](120) NULL,
	[Cinsiyet] [nvarchar](50) NULL,
	[Adres] [nvarchar](500) NULL,
	[Tel] [bigint] NULL,
	[Eposta] [nvarchar](50) NULL,
	[Sifre] [int] NULL,
	[Bakiye] [int] NULL,
 CONSTRAINT [PK_Musteriler] PRIMARY KEY CLUSTERED 
(
	[M_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Subeler]    Script Date: 23.4.2019 23:00:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subeler](
	[SubeKodu] [int] IDENTITY(1,1) NOT NULL,
	[SubeAdi] [nvarchar](200) NULL,
 CONSTRAINT [PK_Subeler] PRIMARY KEY CLUSTERED 
(
	[SubeKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Banka] ([M_No], [SubeKodu], [IslemNo], [Tarih]) VALUES (1, 1, 2, CAST(0x070000000000453F0B0000 AS DateTimeOffset))
INSERT [dbo].[Banka] ([M_No], [SubeKodu], [IslemNo], [Tarih]) VALUES (1, 1, 2, CAST(0x0700000000003E9D0A0000 AS DateTimeOffset))
INSERT [dbo].[Banka] ([M_No], [SubeKodu], [IslemNo], [Tarih]) VALUES (1, 1, 2, CAST(0x0700000000004C3F0B0000 AS DateTimeOffset))
INSERT [dbo].[Banka] ([M_No], [SubeKodu], [IslemNo], [Tarih]) VALUES (1, 1, 2, CAST(0x0700000000004C3F0B0000 AS DateTimeOffset))
INSERT [dbo].[Banka] ([M_No], [SubeKodu], [IslemNo], [Tarih]) VALUES (2, 1, 2, CAST(0x07805BEF4E90933F0B0000 AS DateTimeOffset))
INSERT [dbo].[Banka] ([M_No], [SubeKodu], [IslemNo], [Tarih]) VALUES (1, 1, 2, CAST(0x07C0B4976290933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Çekme', N'10', CAST(0x0740C85135B6933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Çekme', N'20', CAST(0x07906D3250B6933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Çekme', N'50', CAST(0x0730096352B6933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Çekme', N'100', CAST(0x071033C054B6933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Çekme', N'300', CAST(0x07A08E8C56B6933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Çekme', N'5', CAST(0x075022AA59B6933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Yatırma', N' 50', CAST(0x071043B6EEB6933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Yatırma', N'100', CAST(0x07D0BBE4F0B6933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Yatırma', N'300', CAST(0x07D00AB7F2B6933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Yatırma', N'  600', CAST(0x07B07EDEF4B6933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Yatırma', N'1000', CAST(0x0770C0ADF6B6933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Yatırma', N'5', CAST(0x0730B56EF9B6933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Transferi', N'10', CAST(0x0700DB7D49B7933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Şifre Yenileme', NULL, CAST(0x07008096B3B7933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (2, N'Para Çekme', N'300', CAST(0x07E09288C4B7933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (2, N'Para Çekme', N'100', CAST(0x07206406C7B7933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (2, N'Para Yatırma', N' 50', CAST(0x07B01FBDC9B7933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Şifre Yenileme', NULL, CAST(0x074083FB13B9933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Transferi', N'100', CAST(0x07D0C7B759BF933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Transferi', N'100', CAST(0x07B09CD16CBF933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Yatırma', N'299000', CAST(0x0780AFA3DFBF933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Transferi', N'100000', CAST(0x071094FCF3BF933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Çekme', N'1000', CAST(0x075071DBA7BF933F0B0000 AS DateTimeOffset))
INSERT [dbo].[hareketler] ([M_No], [IslemAdi], [Tutar], [Tarih]) VALUES (1, N'Para Çekme', N'1306', CAST(0x07B0FDEAB5BF933F0B0000 AS DateTimeOffset))
SET IDENTITY_INSERT [dbo].[Islemler] ON 

INSERT [dbo].[Islemler] ([IslemNo], [IslemAdi]) VALUES (1, N'Para Çekme')
INSERT [dbo].[Islemler] ([IslemNo], [IslemAdi]) VALUES (2, N'Para Yatırma')
INSERT [dbo].[Islemler] ([IslemNo], [IslemAdi]) VALUES (3, N'Para Transferi')
INSERT [dbo].[Islemler] ([IslemNo], [IslemAdi]) VALUES (4, N'Şifre Yenileme')
SET IDENTITY_INSERT [dbo].[Islemler] OFF
SET IDENTITY_INSERT [dbo].[Musteriler] ON 

INSERT [dbo].[Musteriler] ([M_No], [Tc], [AdSoyad], [DogumTarihi], [DogumYeri], [Cinsiyet], [Adres], [Tel], [Eposta], [Sifre], [Bakiye]) VALUES (1, 38017410420, N'Esma Coşkun', CAST(0x2A230B00 AS Date), N'Kadiköy', N'Kadın', N'Ümraniye', 5073853264, N'coskun-nur@hotmail.com', 2, 199079)
INSERT [dbo].[Musteriler] ([M_No], [Tc], [AdSoyad], [DogumTarihi], [DogumYeri], [Cinsiyet], [Adres], [Tel], [Eposta], [Sifre], [Bakiye]) VALUES (2, 38017410430, N'Gizem Yener', CAST(0x17230B00 AS Date), N'Üsküdar', N'Kadın', N'Üsküdar', 5073853262, N'gizem@hotmail.com', 1, 100200)
INSERT [dbo].[Musteriler] ([M_No], [Tc], [AdSoyad], [DogumTarihi], [DogumYeri], [Cinsiyet], [Adres], [Tel], [Eposta], [Sifre], [Bakiye]) VALUES (3, 11737295430, N'Nur Coşkun', CAST(0x38240B00 AS Date), N'Kadiköy', N'Kadın', N'Kadiköy', 5073801745, N'nur@hotmail.com', 1234, 420)
SET IDENTITY_INSERT [dbo].[Musteriler] OFF
SET IDENTITY_INSERT [dbo].[Subeler] ON 

INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (1, N'Adalar')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (2, N'Arnavutköy')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (3, N'Ataşehir')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (4, N'Avcılar')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (5, N'Bağcılar')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (6, N'Bahçelievler')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (7, N'Bakırköy')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (8, N'Başakşehir')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (9, N'Bayrampaşa')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (10, N'Beşiktaş')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (11, N'Beykoz')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (12, N'Beylikdüzü')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (13, N'Beyoğlu')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (14, N'Büyükçekmece')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (15, N'Çatalca')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (16, N'Çekmeköy')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (17, N'Esenler')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (18, N'Esenyurt')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (19, N'Eyüp')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (20, N'Fatih')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (21, N'Gaziosmanpaşa')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (22, N'Güngören')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (23, N'Kadiköy')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (24, N'Kağıthane')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (25, N'Kartal')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (26, N'Küçükçekmece')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (27, N'Maltepe')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (28, N'Pendik')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (29, N'Sancaktepe')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (30, N'Sarıyer')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (31, N'Silivri')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (32, N'Sultanbeyli')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (33, N'Sultangazi')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (34, N'Şile')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (35, N'Şişli')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (36, N'Tuzla')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (37, N'Ümraniye')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (38, N'Üsküdar')
INSERT [dbo].[Subeler] ([SubeKodu], [SubeAdi]) VALUES (39, N'Zeytinburnu')
SET IDENTITY_INSERT [dbo].[Subeler] OFF
ALTER TABLE [dbo].[Banka]  WITH CHECK ADD  CONSTRAINT [FK_Banka_Islemler] FOREIGN KEY([IslemNo])
REFERENCES [dbo].[Islemler] ([IslemNo])
GO
ALTER TABLE [dbo].[Banka] CHECK CONSTRAINT [FK_Banka_Islemler]
GO
ALTER TABLE [dbo].[Banka]  WITH CHECK ADD  CONSTRAINT [FK_Banka_Musteriler] FOREIGN KEY([M_No])
REFERENCES [dbo].[Musteriler] ([M_No])
GO
ALTER TABLE [dbo].[Banka] CHECK CONSTRAINT [FK_Banka_Musteriler]
GO
ALTER TABLE [dbo].[Banka]  WITH CHECK ADD  CONSTRAINT [FK_Banka_Subeler] FOREIGN KEY([SubeKodu])
REFERENCES [dbo].[Subeler] ([SubeKodu])
GO
ALTER TABLE [dbo].[Banka] CHECK CONSTRAINT [FK_Banka_Subeler]
GO
