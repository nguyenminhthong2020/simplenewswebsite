use db_news
go

create table dbo.Member(
 Mem_UName nvarchar(50) not null primary key,
 Mem_Pas varchar(500) null,
 Mem_Role int null, 
 Mem_Status int null
);

create table dbo.Category(
 Cat_ID int not null primary key,
 Cat_Name nvarchar(50) null,
 Cat_Mem nvarchar(50) null,
 Cat_Pre datetime null,
 Cat_Edit datetime null ,
 Cat_Status int null,
 foreign key (Cat_Mem) references dbo.Member(Mem_UName) on delete cascade on update cascade
);

create table dbo.Post(
 Pos_ID int not null primary key,
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


insert into dbo.Category(Cat_ID, Cat_Name, Cat_Mem, Cat_Pre, Cat_Edit, Cat_Status) values(1, 'Sport', 'admin', null, null, 1)
insert into dbo.Category(Cat_ID, Cat_Name, Cat_Mem, Cat_Pre, Cat_Edit, Cat_Status) values(2, 'Science', 'admin', null, null, 1)
insert into dbo.Category(Cat_ID, Cat_Name, Cat_Mem, Cat_Pre, Cat_Edit, Cat_Status) values(3, 'Education', 'admin', null, null, 1)
insert into dbo.Category(Cat_ID, Cat_Name, Cat_Mem, Cat_Pre, Cat_Edit, Cat_Status) values(4, 'Business', 'admin', null, null, 1)


insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(1, N'CLB Hà Nội hết thủ môn đá V-League', 'https://i1-thethao.vnecdn.net/2022/02/28/a0-jpeg-7544-1646047145.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=0c2SEFMS9RACMAJAKNepVQ', N'Trận đấu giữa Hà Nội và Viettel ở vòng 2 V-League 2022 gần như chắc chắn bị hoãn do đội bóng của bầu Hiển không còn thủ môn đủ điều kiện thi đấu', N'Chia sẻ với VnExpress hôm nay, Giám đốc Điều hành CLB Hà Nội Nguyễn Quốc Tuấn xác nhận CLB Hà Nội có 11 cầu thủ nhiễm Covid-19, trong đó có bốn thủ môn. Bùi Tấn Trường xét nghiệm dương tính hôm 26/2, một ngày sau tới lượt Nguyễn Văn Công và hôm nay là bộ đôi trẻ Nguyễn Bá Minh Hiếu và Quan Văn Chuẩn', 'admin', 1, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(2, N'Khởi đầu khó lường của V-League 2022', 'https://i1-thethao.vnecdn.net/2022/02/28/83a5d7431bdfd7818ece-jpeg-1646-2301-3666-1646034119.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=S6DHjrmx4eKmcrlxRGGeAQ', N'Ba trong tám bàn diễn ra ở phút bù giờ khi vòng 1 không chứng kiến niềm vui của bất kỳ đội chủ nhà nào, tại V-League 2022 khởi tranh cuối tuần qua', N'Những gì diễn ra là điển hình cho yếu tố ngoại cảnh sẽ đóng vai trò khá lớn tại mùa giải năm nay, hoặc chí ít là ba vòng đấu sắp đến trước khi giải sẽ tạm nghỉ đến tháng 7','admin', 1, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(3, N'CLB Hà Nội hết thủ môn đá V-League', 'https://i1-thethao.vnecdn.net/2022/02/28/a0-jpeg-7544-1646047145.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=0c2SEFMS9RACMAJAKNepVQ', N'Trận đấu giữa Hà Nội và Viettel ở vòng 2 V-League 2022 gần như chắc chắn bị hoãn do đội bóng của bầu Hiển không còn thủ môn đủ điều kiện thi đấu', N'Chia sẻ với VnExpress hôm nay, Giám đốc Điều hành CLB Hà Nội Nguyễn Quốc Tuấn xác nhận CLB Hà Nội có 11 cầu thủ nhiễm Covid-19, trong đó có bốn thủ môn. Bùi Tấn Trường xét nghiệm dương tính hôm 26/2, một ngày sau tới lượt Nguyễn Văn Công và hôm nay là bộ đôi trẻ Nguyễn Bá Minh Hiếu và Quan Văn Chuẩn', 'admin', 1, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(4, N'Khởi đầu khó lường của V-League 2022', 'https://i1-thethao.vnecdn.net/2022/02/28/83a5d7431bdfd7818ece-jpeg-1646-2301-3666-1646034119.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=S6DHjrmx4eKmcrlxRGGeAQ', N'Ba trong tám bàn diễn ra ở phút bù giờ khi vòng 1 không chứng kiến niềm vui của bất kỳ đội chủ nhà nào, tại V-League 2022 khởi tranh cuối tuần qua', N'Những gì diễn ra là điển hình cho yếu tố ngoại cảnh sẽ đóng vai trò khá lớn tại mùa giải năm nay, hoặc chí ít là ba vòng đấu sắp đến trước khi giải sẽ tạm nghỉ đến tháng 7','admin', 1, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(5, N'Ảnh chụp ''bông hoa'' trên sao Hỏa', 'https://i1-vnexpress.vnecdn.net/2022/02/27/Hoa-sao-Hoa-9729-1645942704.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=PcWSPBKUNvfTsOdOpDNRmA', N'Robot Curiosity (NASA) chụp ảnh cận cảnh những khối khoáng chất với hình dạng độc đáo trên sao Hỏa, trong đó có khối trông giống hoa', null, 'admin', 2, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(6, N'Ảnh chụp ''bông hoa'' trên sao Hỏa', 'https://i1-vnexpress.vnecdn.net/2022/02/27/Hoa-sao-Hoa-9729-1645942704.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=PcWSPBKUNvfTsOdOpDNRmA', N'Robot Curiosity (NASA) chụp ảnh cận cảnh những khối khoáng chất với hình dạng độc đáo trên sao Hỏa, trong đó có khối trông giống hoa', null, 'admin', 2, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(7, N'Các chương trình tú tài của Australia', 'https://i1-vnexpress.vnecdn.net/2022/02/25/EMackenzie-profile-photo-7971-1645775816.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=0EppNS8Qmw-1KS-uL8ja6Q', N'Tại Australia, mỗi tiểu bang có chương trình tú tài riêng, như SACE, VCE, HSC, tuy nhiên tất cả đều tuân thủ nghiêm ngặt yêu cầu của khung chương trình quốc gia', null, 'admin', 3, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(8, N'Xuất khẩu hoa năm ngoái thu về 61 triệu USD', 'https://i1-kinhdoanh.vnecdn.net/2022/02/28/hoa-hong-1644570666-1644570682-2011-2454-1646039219.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=P8ctxcaPA6LUC9IVrBRLQg', N'Năm qua, xuất khẩu hoa hồng của Việt Nam tăng trưởng 3 con số, còn hoa lan và cúc tạo được vị thế tại nhiều thị trường, góp phần mang về 61,8 triệu USD', N'Thống kê của Tổng cục Hải quan cho thấy, xuất khẩu hoa của Việt Nam năm 2021 đạt 61,8 triệu USD, tăng 27% so với 2020. Trong đó, hoa hồng có mức tăng trưởng mạnh nhất trên 100%. Tiếp đến là hoa ly, cúc, lan hồ điệp tăng trưởng 16-52%.', 'admin', 4, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(9, N'CLB Hà Nội hết thủ môn đá V-League', 'https://i1-thethao.vnecdn.net/2022/02/28/a0-jpeg-7544-1646047145.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=0c2SEFMS9RACMAJAKNepVQ', N'Trận đấu giữa Hà Nội và Viettel ở vòng 2 V-League 2022 gần như chắc chắn bị hoãn do đội bóng của bầu Hiển không còn thủ môn đủ điều kiện thi đấu', N'Chia sẻ với VnExpress hôm nay, Giám đốc Điều hành CLB Hà Nội Nguyễn Quốc Tuấn xác nhận CLB Hà Nội có 11 cầu thủ nhiễm Covid-19, trong đó có bốn thủ môn. Bùi Tấn Trường xét nghiệm dương tính hôm 26/2, một ngày sau tới lượt Nguyễn Văn Công và hôm nay là bộ đôi trẻ Nguyễn Bá Minh Hiếu và Quan Văn Chuẩn', 'admin', 1, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(10, N'Khởi đầu khó lường của V-League 2022', 'https://i1-thethao.vnecdn.net/2022/02/28/83a5d7431bdfd7818ece-jpeg-1646-2301-3666-1646034119.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=S6DHjrmx4eKmcrlxRGGeAQ', N'Ba trong tám bàn diễn ra ở phút bù giờ khi vòng 1 không chứng kiến niềm vui của bất kỳ đội chủ nhà nào, tại V-League 2022 khởi tranh cuối tuần qua', N'Những gì diễn ra là điển hình cho yếu tố ngoại cảnh sẽ đóng vai trò khá lớn tại mùa giải năm nay, hoặc chí ít là ba vòng đấu sắp đến trước khi giải sẽ tạm nghỉ đến tháng 7','admin', 1, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(11, N'CLB Hà Nội hết thủ môn đá V-League', 'https://i1-thethao.vnecdn.net/2022/02/28/a0-jpeg-7544-1646047145.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=0c2SEFMS9RACMAJAKNepVQ', N'Trận đấu giữa Hà Nội và Viettel ở vòng 2 V-League 2022 gần như chắc chắn bị hoãn do đội bóng của bầu Hiển không còn thủ môn đủ điều kiện thi đấu', N'Chia sẻ với VnExpress hôm nay, Giám đốc Điều hành CLB Hà Nội Nguyễn Quốc Tuấn xác nhận CLB Hà Nội có 11 cầu thủ nhiễm Covid-19, trong đó có bốn thủ môn. Bùi Tấn Trường xét nghiệm dương tính hôm 26/2, một ngày sau tới lượt Nguyễn Văn Công và hôm nay là bộ đôi trẻ Nguyễn Bá Minh Hiếu và Quan Văn Chuẩn', 'admin', 1, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(12, N'Khởi đầu khó lường của V-League 2022', 'https://i1-thethao.vnecdn.net/2022/02/28/83a5d7431bdfd7818ece-jpeg-1646-2301-3666-1646034119.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=S6DHjrmx4eKmcrlxRGGeAQ', N'Ba trong tám bàn diễn ra ở phút bù giờ khi vòng 1 không chứng kiến niềm vui của bất kỳ đội chủ nhà nào, tại V-League 2022 khởi tranh cuối tuần qua', N'Những gì diễn ra là điển hình cho yếu tố ngoại cảnh sẽ đóng vai trò khá lớn tại mùa giải năm nay, hoặc chí ít là ba vòng đấu sắp đến trước khi giải sẽ tạm nghỉ đến tháng 7','admin', 1, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(13, N'Ảnh chụp ''bông hoa'' trên sao Hỏa', 'https://i1-vnexpress.vnecdn.net/2022/02/27/Hoa-sao-Hoa-9729-1645942704.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=PcWSPBKUNvfTsOdOpDNRmA', N'Robot Curiosity (NASA) chụp ảnh cận cảnh những khối khoáng chất với hình dạng độc đáo trên sao Hỏa, trong đó có khối trông giống hoa', null, 'admin', 2, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(14, N'Ảnh chụp ''bông hoa'' trên sao Hỏa', 'https://i1-vnexpress.vnecdn.net/2022/02/27/Hoa-sao-Hoa-9729-1645942704.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=PcWSPBKUNvfTsOdOpDNRmA', N'Robot Curiosity (NASA) chụp ảnh cận cảnh những khối khoáng chất với hình dạng độc đáo trên sao Hỏa, trong đó có khối trông giống hoa', null, 'admin', 2, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(15, N'Các chương trình tú tài của Australia', 'https://i1-vnexpress.vnecdn.net/2022/02/25/EMackenzie-profile-photo-7971-1645775816.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=0EppNS8Qmw-1KS-uL8ja6Q', N'Tại Australia, mỗi tiểu bang có chương trình tú tài riêng, như SACE, VCE, HSC, tuy nhiên tất cả đều tuân thủ nghiêm ngặt yêu cầu của khung chương trình quốc gia', null, 'admin', 3, null, null, null)
insert into dbo.Post(Pos_ID, Pos_Title, Pos_Img, Pos_Brief, Pos_Content, Pos_Mem, Pos_Cat, Pos_Cre, Pos_Edit, Pos_Status) values(16, N'Xuất khẩu hoa năm ngoái thu về 61 triệu USD', 'https://i1-kinhdoanh.vnecdn.net/2022/02/28/hoa-hong-1644570666-1644570682-2011-2454-1646039219.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=P8ctxcaPA6LUC9IVrBRLQg', N'Năm qua, xuất khẩu hoa hồng của Việt Nam tăng trưởng 3 con số, còn hoa lan và cúc tạo được vị thế tại nhiều thị trường, góp phần mang về 61,8 triệu USD', N'Thống kê của Tổng cục Hải quan cho thấy, xuất khẩu hoa của Việt Nam năm 2021 đạt 61,8 triệu USD, tăng 27% so với 2020. Trong đó, hoa hồng có mức tăng trưởng mạnh nhất trên 100%. Tiếp đến là hoa ly, cúc, lan hồ điệp tăng trưởng 16-52%.', 'admin', 4, null, null, null)