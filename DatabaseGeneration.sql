use MusicPlayer
USE MusicPlayer

create table MUSIC
(
	music_id char(4), -- id mv
	music_name nvarchar(100), -- ten bai hat
	music_author nvarchar(100), -- ten tac gia
	singer_name nvarchar(100), -- ten ca si
	music_country varchar(40), -- quoc gia
	music_category nvarchar(40), -- the loai
	music_time nvarchar(20), -- thoi luong
	music_release nvarchar(20), -- nam phat hanh
	music_freq int, -- luot xem
	music_lyric nvarchar(4000), -- lyric
	music_love_status int, -- trang thai yeu thich
	music_stars int, -- danh gia
)

create table HISTORY_MUSIC_LIST (
	history_music_id char(4), -- id history
	history_music_time datetime, -- id time
)

insert into HISTORY_MUSIC_LIST values('mv01', '2022-12-16 12:40:22')
insert into HISTORY_MUSIC_LIST values('mv02', '2022-12-14 11:40:22')
insert into HISTORY_MUSIC_LIST values('mv03', '2022-12-15 11:40:22')

select * from HISTORY_MUSIC_LIST


SELECT [history_music_id], [music_name], [singer_name], [history_music_time] FROM HISTORY_MUSIC_LIST inner join MUSIC on history_music_id = music_id order by history_music_time desc

create table PLAYLIST (
	playlist_id char(4),
	playlist_name nvarchar(100),
	playlist_time datetime,
	playlist_logo nvarchar(1000),
	constraint PK_PLAYLIST primary key (playlist_id),
)

create table PLAYLIST_DETAIL (
	playlist_id char(4),
	music_id char(4),
	music_playlist_time datetime,
	constraint PK_PLAYLIST_DETAIL primary key (playlist_id, music_id)
)

insert into PLAYLIST values('pl01', 'PLAYLIST 01', '2022-12-14 11:59:22', N'playlist')
insert into PLAYLIST values('pl02', 'PLAYLIST 02', '2022-12-13 11:19:22', N'playlist')

insert into PLAYLIST values('pl03', 'PLAYLIST 03', '2022-12-14 11:10:22', N'C:\Users\Asus\OneDrive\Hình ảnh\Saved Pictures\1b6509c72cdd8e32c17ae36bc6fea2d4.jpg')
insert into PLAYLIST values('pl04', 'PLAYLIST 04', '2022-11-11 11:20:22', N'playlist')
insert into PLAYLIST values('pl05', 'PLAYLIST 05', '2022-10-04 11:30:22', N'C:\Users\Asus\OneDrive\Hình ảnh\Saved Pictures\137672719_1178777115872652_3195677987593704588_n.jpg')

insert into PLAYLIST_DETAIL values('pl01', 'mv01', '2022-12-14 11:40:22')
insert into PLAYLIST_DETAIL values('pl01', 'mv02', '2022-12-15 11:40:22')

Select * from Playlist_Detail
Select * from Playlist

Truncate table playlist_detail
Truncate table playlist

Drop table playlist
drop table PLAYLIST_DETAIL

-- Convert languague
CREATE FUNCTION [dbo].[LanguageComprehension](@inputVar NVARCHAR(MAX) )
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
    RETURN @inputVar
END
go
