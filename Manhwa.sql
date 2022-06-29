CREATE DATABASE FullComic
GO

USE FullComic
GO

CREATE TABLE Manhwa
(
	Id INT IDENTITY (1,1) PRIMARY KEY,
	UrlImageManhwa NCHAR(300) NOT NULL,
	Name NVARCHAR(300) NOT NULL,
	Description NVARCHAR(max),
	Create_date DATETIME DEFAULT GETDATE(),
	Views INT NOT NULL DEFAULT 0,
	Likes INT NOT NULL DEFAULT 0
)
GO

CREATE TABLE Chapter
(
	Id INT IDENTITY (1,1) PRIMARY KEY,
	IdManhwa INT NOT NULL,
	Name NVARCHAR(300) NOT NULL,
	Create_date DATETIME DEFAULT GETDATE(),
	HightLightChapter INT NOT NULL DEFAULT 0,
	Views INT NOT NULL DEFAULT 0

	CONSTRAINT FK_IdManhwa_Chapter_TO_Id_Manhwa FOREIGN KEY (IdManhwa) REFERENCES dbo.Manhwa(Id),
)
GO

CREATE TABLE UrlImageManhwa
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	IdChapter INT NOT NULL,
	UrlImage VARCHAR(7800) NOT NULL

	CONSTRAINT FK_IdChapter_UrlImageManhwa_TO_Id_Chapter FOREIGN KEY (IdChapter) REFERENCES dbo.Chapter(Id),
)
GO

SELECT * FROM Manhwa

INSERT INTO Manhwa VALUES
('http://st.imageinstant.net/data/comics/234/dai-tuong-vo-hinh.jpg', N'Change Wife Raw', N'Hay', GETDATE(), 0, 0),
('http://st.imageinstant.net/data/comics/131/dai-vuong-tha-mang.jpg', N'Thirst Raw', N'Hay', GETDATE(), 0, 0),
('http://st.imageinstant.net/data/comics/159/anh-sang-cuoi-con-duong.jpg', N'Secret Campus Raw', N'Siêu phẩm', GETDATE(), 0, 0),
('http://st.imageinstant.net/data/comics/234/dai-tuong-vo-hinh.jpg', N'Change Wife Vietnamese', N'Hay', GETDATE(), 0, 0);



SELECT * FROM Manhwa

SELECT * FROM Chapter

SELECT * FROM UrlImageManhwa 

UPDATE Manhwa SET Name = N'Ta Học Ma Pháp Tại Dị Giới' WHERE Id = 22

SELECT Count(NCHAR)

DELETE Chapter
DELETE UrlImageManhwa 

INSERT INTO Manhwa VALUES
('http://st.imageinstant.net/data/comics/234/dai-tuong-vo-hinh.jpg', N'Change Wife Raw',null, N'Hay', GETDATE(), 0, 0),
('http://st.imageinstant.net/data/comics/131/dai-vuong-tha-mang.jpg', N'Thirst Raw', null ,N'Hay', GETDATE(), 0, 0),
('http://st.imageinstant.net/data/comics/159/anh-sang-cuoi-con-duong.jpg', N'Secret Campus Raw', null, N'Siêu phẩm', GETDATE(), 0, 0),
('http://st.nettruyengo.com/data/comics/129/manh-su-tai-thuong.jpg', N'Change Wife Vietnamese', null, N'Hay', GETDATE(), 0, 0),
('https://truyenvn.vip/wp-content/uploads/2019/11/chi-ton-dong-thuat-su-tuyet-the-dai-tieu-thu_1574228353.jpg', N'Craving', null, N'Siêu phẩm', GETDATE(), 0, 0),
('https://truyenvn.vip/wp-content/uploads/2021/12/ta-khong-muon-lam-de-nhat.jpg', N'Inside The Story', null, N'Hay', GETDATE(), 0, 0);