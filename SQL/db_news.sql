use db_news
go

ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = OFF 
GO

create table dbo.Member(
 Mem_UName nvarchar(50) not null primary key,
 Mem_Pas varchar(500) null,
 Mem_Role int null, 
 Mem_Status int null
);

create table dbo.Category(
 Cat_ID int not null primary key IDENTITY(1,1),
 Cat_Name nvarchar(50) null,
 Cat_Mem nvarchar(50) null,
 Cat_Cre datetime null,
 Cat_Edit datetime null ,
 Cat_Status int null,
 foreign key (Cat_Mem) references dbo.Member(Mem_UName) on delete cascade on update cascade
);

create table dbo.Post(
 Pos_ID int not null primary key IDENTITY(1,1),
 Pos_Title nvarchar(250) null,
 Pos_Img nvarchar(500) null,
 Pos_Brief nvarchar(500) null,
 Pos_Content ntext null,
 Pos_Mem nvarchar(50) null,
 Pos_Cat int null,
 Pos_Cre datetime null ,
 Pos_Edit datetime null,
 Pos_Status int null,
 foreign key (Pos_Cat) references dbo.Category(Cat_ID) on delete cascade on update cascade,
 foreign key (Pos_Mem) references dbo.Member(Mem_UName) 

);


insert into dbo.Member(Mem_UName, Mem_Pas, Mem_Role, Mem_Status) values('admin', '87d9bb400c0634691f0e3baaf1e2fd0d', 1, 1)


insert into dbo.Category(Cat_Name, Cat_Mem, Cat_Cre, Cat_Edit, Cat_Status) values('Sport', 'admin', null, null, 1)
insert into dbo.Category(Cat_Name, Cat_Mem, Cat_Cre, Cat_Edit, Cat_Status) values('Science', 'admin', null, null, 1)
insert into dbo.Category(Cat_Name, Cat_Mem, Cat_Cre, Cat_Edit, Cat_Status) values('Education', 'admin', null, null, 1)
insert into dbo.Category(Cat_Name, Cat_Mem, Cat_Cre, Cat_Edit, Cat_Status) values('Business', 'admin', null, null, 1)
insert into dbo.Category(Cat_Name, Cat_Mem, Cat_Cre, Cat_Edit, Cat_Status) values('Travel', 'admin', null, null, 0)
insert into dbo.Category(Cat_Name, Cat_Mem, Cat_Cre, Cat_Edit, Cat_Status) values('Life', 'admin', null, null, 0)


insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'CLB Hà Nội hết thủ môn đá V-League', 'https://i1-thethao.vnecdn.net/2022/02/28/a0-jpeg-7544-1646047145.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=0c2SEFMS9RACMAJAKNepVQ', N'Trận đấu giữa Hà Nội và Viettel ở vòng 2 V-League 2022 gần như chắc chắn bị hoãn do đội bóng của bầu Hiển không còn thủ môn đủ điều kiện thi đấu', N'Chia sẻ với VnExpress hôm nay, Giám đốc Điều hành CLB Hà Nội Nguyễn Quốc Tuấn xác nhận CLB Hà Nội có 11 cầu thủ nhiễm Covid-19, trong đó có bốn thủ môn. Bùi Tấn Trường xét nghiệm dương tính hôm 26/2, một ngày sau tới lượt Nguyễn Văn Công và hôm nay là bộ đôi trẻ Nguyễn Bá Minh Hiếu và Quan Văn Chuẩn', 'admin', 1, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'Khởi đầu khó lường của V-League 2022', 'https://i1-thethao.vnecdn.net/2022/02/28/83a5d7431bdfd7818ece-jpeg-1646-2301-3666-1646034119.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=S6DHjrmx4eKmcrlxRGGeAQ', N'Ba trong tám bàn diễn ra ở phút bù giờ khi vòng 1 không chứng kiến niềm vui của bất kỳ đội chủ nhà nào, tại V-League 2022 khởi tranh cuối tuần qua', N'Những gì diễn ra là điển hình cho yếu tố ngoại cảnh sẽ đóng vai trò khá lớn tại mùa giải năm nay, hoặc chí ít là ba vòng đấu sắp đến trước khi giải sẽ tạm nghỉ đến tháng 7','admin', 1, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'CLB Hà Nội hết thủ môn đá V-League', 'https://i1-thethao.vnecdn.net/2022/02/28/a0-jpeg-7544-1646047145.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=0c2SEFMS9RACMAJAKNepVQ', N'Trận đấu giữa Hà Nội và Viettel ở vòng 2 V-League 2022 gần như chắc chắn bị hoãn do đội bóng của bầu Hiển không còn thủ môn đủ điều kiện thi đấu', N'Chia sẻ với VnExpress hôm nay, Giám đốc Điều hành CLB Hà Nội Nguyễn Quốc Tuấn xác nhận CLB Hà Nội có 11 cầu thủ nhiễm Covid-19, trong đó có bốn thủ môn. Bùi Tấn Trường xét nghiệm dương tính hôm 26/2, một ngày sau tới lượt Nguyễn Văn Công và hôm nay là bộ đôi trẻ Nguyễn Bá Minh Hiếu và Quan Văn Chuẩn', 'admin', 1, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'Khởi đầu khó lường của V-League 2022', 'https://i1-thethao.vnecdn.net/2022/02/28/83a5d7431bdfd7818ece-jpeg-1646-2301-3666-1646034119.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=S6DHjrmx4eKmcrlxRGGeAQ', N'Ba trong tám bàn diễn ra ở phút bù giờ khi vòng 1 không chứng kiến niềm vui của bất kỳ đội chủ nhà nào, tại V-League 2022 khởi tranh cuối tuần qua', N'Những gì diễn ra là điển hình cho yếu tố ngoại cảnh sẽ đóng vai trò khá lớn tại mùa giải năm nay, hoặc chí ít là ba vòng đấu sắp đến trước khi giải sẽ tạm nghỉ đến tháng 7','admin', 1, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'Ảnh chụp ''bông hoa'' trên sao Hỏa', 'https://i1-vnexpress.vnecdn.net/2022/02/27/Hoa-sao-Hoa-9729-1645942704.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=PcWSPBKUNvfTsOdOpDNRmA', N'Robot Curiosity (NASA) chụp ảnh cận cảnh những khối khoáng chất với hình dạng độc đáo trên sao Hỏa, trong đó có khối trông giống hoa', null, 'admin', 2, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'Ảnh chụp ''bông hoa'' trên sao Hỏa', 'https://i1-vnexpress.vnecdn.net/2022/02/27/Hoa-sao-Hoa-9729-1645942704.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=PcWSPBKUNvfTsOdOpDNRmA', N'Robot Curiosity (NASA) chụp ảnh cận cảnh những khối khoáng chất với hình dạng độc đáo trên sao Hỏa, trong đó có khối trông giống hoa', null, 'admin', 2, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'Các chương trình tú tài của Australia', 'https://i1-vnexpress.vnecdn.net/2022/02/25/EMackenzie-profile-photo-7971-1645775816.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=0EppNS8Qmw-1KS-uL8ja6Q', N'Tại Australia, mỗi tiểu bang có chương trình tú tài riêng, như SACE, VCE, HSC, tuy nhiên tất cả đều tuân thủ nghiêm ngặt yêu cầu của khung chương trình quốc gia', null, 'admin', 3, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'Xuất khẩu hoa năm ngoái thu về 61 triệu USD', 'https://i1-kinhdoanh.vnecdn.net/2022/02/28/hoa-hong-1644570666-1644570682-2011-2454-1646039219.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=P8ctxcaPA6LUC9IVrBRLQg', N'Năm qua, xuất khẩu hoa hồng của Việt Nam tăng trưởng 3 con số, còn hoa lan và cúc tạo được vị thế tại nhiều thị trường, góp phần mang về 61,8 triệu USD', N'Thống kê của Tổng cục Hải quan cho thấy, xuất khẩu hoa của Việt Nam năm 2021 đạt 61,8 triệu USD, tăng 27% so với 2020. Trong đó, hoa hồng có mức tăng trưởng mạnh nhất trên 100%. Tiếp đến là hoa ly, cúc, lan hồ điệp tăng trưởng 16-52%.', 'admin', 4, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'CLB Hà Nội hết thủ môn đá V-League', 'https://i1-thethao.vnecdn.net/2022/02/28/a0-jpeg-7544-1646047145.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=0c2SEFMS9RACMAJAKNepVQ', N'Trận đấu giữa Hà Nội và Viettel ở vòng 2 V-League 2022 gần như chắc chắn bị hoãn do đội bóng của bầu Hiển không còn thủ môn đủ điều kiện thi đấu', N'Chia sẻ với VnExpress hôm nay, Giám đốc Điều hành CLB Hà Nội Nguyễn Quốc Tuấn xác nhận CLB Hà Nội có 11 cầu thủ nhiễm Covid-19, trong đó có bốn thủ môn. Bùi Tấn Trường xét nghiệm dương tính hôm 26/2, một ngày sau tới lượt Nguyễn Văn Công và hôm nay là bộ đôi trẻ Nguyễn Bá Minh Hiếu và Quan Văn Chuẩn', 'admin', 1, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'Khởi đầu khó lường của V-League 2022', 'https://i1-thethao.vnecdn.net/2022/02/28/83a5d7431bdfd7818ece-jpeg-1646-2301-3666-1646034119.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=S6DHjrmx4eKmcrlxRGGeAQ', N'Ba trong tám bàn diễn ra ở phút bù giờ khi vòng 1 không chứng kiến niềm vui của bất kỳ đội chủ nhà nào, tại V-League 2022 khởi tranh cuối tuần qua', N'Những gì diễn ra là điển hình cho yếu tố ngoại cảnh sẽ đóng vai trò khá lớn tại mùa giải năm nay, hoặc chí ít là ba vòng đấu sắp đến trước khi giải sẽ tạm nghỉ đến tháng 7','admin', 1, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'CLB Hà Nội hết thủ môn đá V-League', 'https://i1-thethao.vnecdn.net/2022/02/28/a0-jpeg-7544-1646047145.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=0c2SEFMS9RACMAJAKNepVQ', N'Trận đấu giữa Hà Nội và Viettel ở vòng 2 V-League 2022 gần như chắc chắn bị hoãn do đội bóng của bầu Hiển không còn thủ môn đủ điều kiện thi đấu', N'Chia sẻ với VnExpress hôm nay, Giám đốc Điều hành CLB Hà Nội Nguyễn Quốc Tuấn xác nhận CLB Hà Nội có 11 cầu thủ nhiễm Covid-19, trong đó có bốn thủ môn. Bùi Tấn Trường xét nghiệm dương tính hôm 26/2, một ngày sau tới lượt Nguyễn Văn Công và hôm nay là bộ đôi trẻ Nguyễn Bá Minh Hiếu và Quan Văn Chuẩn', 'admin', 1, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'Khởi đầu khó lường của V-League 2022', 'https://i1-thethao.vnecdn.net/2022/02/28/83a5d7431bdfd7818ece-jpeg-1646-2301-3666-1646034119.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=S6DHjrmx4eKmcrlxRGGeAQ', N'Ba trong tám bàn diễn ra ở phút bù giờ khi vòng 1 không chứng kiến niềm vui của bất kỳ đội chủ nhà nào, tại V-League 2022 khởi tranh cuối tuần qua', N'Những gì diễn ra là điển hình cho yếu tố ngoại cảnh sẽ đóng vai trò khá lớn tại mùa giải năm nay, hoặc chí ít là ba vòng đấu sắp đến trước khi giải sẽ tạm nghỉ đến tháng 7','admin', 1, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'Ảnh chụp ''bông hoa'' trên sao Hỏa', 'https://i1-vnexpress.vnecdn.net/2022/02/27/Hoa-sao-Hoa-9729-1645942704.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=PcWSPBKUNvfTsOdOpDNRmA', N'Robot Curiosity (NASA) chụp ảnh cận cảnh những khối khoáng chất với hình dạng độc đáo trên sao Hỏa, trong đó có khối trông giống hoa', null, 'admin', 2, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'Ảnh chụp ''bông hoa'' trên sao Hỏa', 'https://i1-vnexpress.vnecdn.net/2022/02/27/Hoa-sao-Hoa-9729-1645942704.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=PcWSPBKUNvfTsOdOpDNRmA', N'Robot Curiosity (NASA) chụp ảnh cận cảnh những khối khoáng chất với hình dạng độc đáo trên sao Hỏa, trong đó có khối trông giống hoa', null, 'admin', 2, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'Các chương trình tú tài của Australia', 'https://i1-vnexpress.vnecdn.net/2022/02/25/EMackenzie-profile-photo-7971-1645775816.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=0EppNS8Qmw-1KS-uL8ja6Q', N'Tại Australia, mỗi tiểu bang có chương trình tú tài riêng, như SACE, VCE, HSC, tuy nhiên tất cả đều tuân thủ nghiêm ngặt yêu cầu của khung chương trình quốc gia', null, 'admin', 3, null, null, null)
insert into dbo.Post(Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(N'Xuất khẩu hoa năm ngoái thu về 61 triệu USD', 'https://i1-kinhdoanh.vnecdn.net/2022/02/28/hoa-hong-1644570666-1644570682-2011-2454-1646039219.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=P8ctxcaPA6LUC9IVrBRLQg', N'Năm qua, xuất khẩu hoa hồng của Việt Nam tăng trưởng 3 con số, còn hoa lan và cúc tạo được vị thế tại nhiều thị trường, góp phần mang về 61,8 triệu USD', N'Thống kê của Tổng cục Hải quan cho thấy, xuất khẩu hoa của Việt Nam năm 2021 đạt 61,8 triệu USD, tăng 27% so với 2020. Trong đó, hoa hồng có mức tăng trưởng mạnh nhất trên 100%. Tiếp đến là hoa ly, cúc, lan hồ điệp tăng trưởng 16-52%.', 'admin', 4, null, null, null)


UPDATE dbo.Post SET Pos_Cre = '2022-02-02 10:11' WHERE Pos_ID = 1;
UPDATE dbo.Post SET Pos_Cre = '2022-02-02 12:11' WHERE Pos_ID = 2;
UPDATE dbo.Post SET Pos_Cre = '2022-02-02 21:00' WHERE Pos_ID = 3;
UPDATE dbo.Post SET Pos_Cre = '2022-02-03 03:45' WHERE Pos_ID = 4;
UPDATE dbo.Post SET Pos_Cre = '2022-02-03 10:18' WHERE Pos_ID = 5;
UPDATE dbo.Post SET Pos_Cre = '2022-02-04 10:11' WHERE Pos_ID = 6;
UPDATE dbo.Post SET Pos_Cre = '2022-02-04 10:12' WHERE Pos_ID = 7;
UPDATE dbo.Post SET Pos_Cre = '2022-02-05 10:11' WHERE Pos_ID = 8;
UPDATE dbo.Post SET Pos_Cre = '2022-02-05 14:11' WHERE Pos_ID = 9;
UPDATE dbo.Post SET Pos_Cre = '2022-02-06 05:11' WHERE Pos_ID = 10;
UPDATE dbo.Post SET Pos_Cre = '2022-02-06 09:11' WHERE Pos_ID = 11;
UPDATE dbo.Post SET Pos_Cre = '2022-02-06 10:11' WHERE Pos_ID = 12;
UPDATE dbo.Post SET Pos_Cre = '2022-02-06 13:11' WHERE Pos_ID = 13;
UPDATE dbo.Post SET Pos_Cre = '2022-02-07 10:46' WHERE Pos_ID = 14;
UPDATE dbo.Post SET Pos_Cre = '2022-02-07 10:57' WHERE Pos_ID = 15;
UPDATE dbo.Post SET Pos_Cre = '2022-02-20 12:01' WHERE Pos_ID = 16;


update dbo.Member set Mem_Pas = '2C29246B3DB18768BBA5B92BC89431B1' where Mem_UName = 'admin'