/*
Navicat SQL Server Data Transfer

Source Server         : MSSQL
Source Server Version : 105000
Source Host           : .\SQLEXPRESS:1433
Source Database       : Coffe_Shop
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 105000
File Encoding         : 65001

Date: 2019-04-20 20:33:41
*/


-- ----------------------------
-- Table structure for [dbo].[bought_type]
-- ----------------------------
DROP TABLE [dbo].[bought_type]
GO
CREATE TABLE [dbo].[bought_type] (
[bought_type_id] int NOT NULL IDENTITY(1,1) ,
[bought_name] varchar(55) NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[bought_type]', RESEED, 5)
GO

-- ----------------------------
-- Records of bought_type
-- ----------------------------
SET IDENTITY_INSERT [dbo].[bought_type] ON
GO
INSERT INTO [dbo].[bought_type] ([bought_type_id], [bought_name]) VALUES (N'1', N'رواتب');
GO
INSERT INTO [dbo].[bought_type] ([bought_type_id], [bought_name]) VALUES (N'2', N'كهرباء');
GO
INSERT INTO [dbo].[bought_type] ([bought_type_id], [bought_name]) VALUES (N'3', N'مياة');
GO
SET IDENTITY_INSERT [dbo].[bought_type] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[boughts]
-- ----------------------------
DROP TABLE [dbo].[boughts]
GO
CREATE TABLE [dbo].[boughts] (
[id_boughts] int NOT NULL IDENTITY(1,1) ,
[boughts_date] date NOT NULL ,
[price_total] float(53) NOT NULL ,
[boughts_type_id] int NOT NULL ,
[boughts_details] varchar(255) NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[boughts]', RESEED, 10)
GO

-- ----------------------------
-- Records of boughts
-- ----------------------------
SET IDENTITY_INSERT [dbo].[boughts] ON
GO
INSERT INTO [dbo].[boughts] ([id_boughts], [boughts_date], [price_total], [boughts_type_id], [boughts_details]) VALUES (N'9', N'2017-02-07', N'1800', N'1', N'مرتبات');
GO
SET IDENTITY_INSERT [dbo].[boughts] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[category]
-- ----------------------------
DROP TABLE [dbo].[category]
GO
CREATE TABLE [dbo].[category] (
[category_id] int NOT NULL IDENTITY(1,1) ,
[category_name] varchar(55) NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[category]', RESEED, 4)
GO

-- ----------------------------
-- Records of category
-- ----------------------------
SET IDENTITY_INSERT [dbo].[category] ON
GO
INSERT INTO [dbo].[category] ([category_id], [category_name]) VALUES (N'1', N'مشروبات ساخنة');
GO
INSERT INTO [dbo].[category] ([category_id], [category_name]) VALUES (N'2', N'مشروبات مثلجة');
GO
SET IDENTITY_INSERT [dbo].[category] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[locker]
-- ----------------------------
DROP TABLE [dbo].[locker]
GO
CREATE TABLE [dbo].[locker] (
[locker_id] int NOT NULL IDENTITY(1,1) ,
[locker_money] float(53) NOT NULL 
)


GO

-- ----------------------------
-- Records of locker
-- ----------------------------
SET IDENTITY_INSERT [dbo].[locker] ON
GO
INSERT INTO [dbo].[locker] ([locker_id], [locker_money]) VALUES (N'1', N'186');
GO
SET IDENTITY_INSERT [dbo].[locker] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[login_check]
-- ----------------------------
DROP TABLE [dbo].[login_check]
GO
CREATE TABLE [dbo].[login_check] (
[logincheck_id] int NOT NULL IDENTITY(1,1) ,
[logincheck_username] varchar(55) NOT NULL ,
[logincheck_password] varchar(55) NOT NULL ,
[logincheck_type] tinyint NOT NULL ,
[logincheck_name] varchar(55) NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[login_check]', RESEED, 2)
GO

-- ----------------------------
-- Records of login_check
-- ----------------------------
SET IDENTITY_INSERT [dbo].[login_check] ON
GO
INSERT INTO [dbo].[login_check] ([logincheck_id], [logincheck_username], [logincheck_password], [logincheck_type], [logincheck_name]) VALUES (N'1', N'mina', N'F3KwlTTM2mZXYDBNDNSMNw==', N'1', N'mina makram');
GO
INSERT INTO [dbo].[login_check] ([logincheck_id], [logincheck_username], [logincheck_password], [logincheck_type], [logincheck_name]) VALUES (N'2', N'Mena', N'20zRif9SMqx5p+3RkgHLMg==', N'1', N'مينا');
GO
SET IDENTITY_INSERT [dbo].[login_check] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[order_details]
-- ----------------------------
DROP TABLE [dbo].[order_details]
GO
CREATE TABLE [dbo].[order_details] (
[order_details_id] int NOT NULL IDENTITY(1,1) ,
[order_id] int NOT NULL ,
[subcategory_id] int NOT NULL ,
[subcategory_count] int NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[order_details]', RESEED, 124)
GO

-- ----------------------------
-- Records of order_details
-- ----------------------------
SET IDENTITY_INSERT [dbo].[order_details] ON
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'88', N'43', N'1', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'89', N'43', N'4', N'1');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'90', N'44', N'4', N'3');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'91', N'44', N'5', N'1');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'92', N'45', N'2', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'93', N'45', N'6', N'1');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'94', N'46', N'6', N'1');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'95', N'46', N'1', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'96', N'46', N'4', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'97', N'47', N'1', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'98', N'47', N'4', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'99', N'47', N'5', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'100', N'47', N'2', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'101', N'47', N'6', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'102', N'48', N'2', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'103', N'48', N'6', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'104', N'49', N'2', N'1');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'105', N'49', N'6', N'1');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'106', N'50', N'1', N'1');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'107', N'50', N'4', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'108', N'50', N'5', N'1');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'109', N'51', N'1', N'1');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'110', N'51', N'4', N'1');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'111', N'51', N'5', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'112', N'52', N'1', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'113', N'52', N'4', N'3');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'114', N'52', N'5', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'122', N'55', N'1', N'1');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'123', N'55', N'5', N'2');
GO
INSERT INTO [dbo].[order_details] ([order_details_id], [order_id], [subcategory_id], [subcategory_count]) VALUES (N'124', N'55', N'4', N'1');
GO
SET IDENTITY_INSERT [dbo].[order_details] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[orders]
-- ----------------------------
DROP TABLE [dbo].[orders]
GO
CREATE TABLE [dbo].[orders] (
[order_id] int NOT NULL IDENTITY(1,1) ,
[table_id] int NOT NULL ,
[order_date] datetime NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[orders]', RESEED, 55)
GO

-- ----------------------------
-- Records of orders
-- ----------------------------
SET IDENTITY_INSERT [dbo].[orders] ON
GO
INSERT INTO [dbo].[orders] ([order_id], [table_id], [order_date]) VALUES (N'43', N'1', N'2017-02-07 00:00:00.000');
GO
INSERT INTO [dbo].[orders] ([order_id], [table_id], [order_date]) VALUES (N'44', N'2', N'2017-02-07 00:00:00.000');
GO
INSERT INTO [dbo].[orders] ([order_id], [table_id], [order_date]) VALUES (N'45', N'3', N'2017-02-07 00:00:00.000');
GO
INSERT INTO [dbo].[orders] ([order_id], [table_id], [order_date]) VALUES (N'46', N'1', N'2019-03-28 00:00:00.000');
GO
INSERT INTO [dbo].[orders] ([order_id], [table_id], [order_date]) VALUES (N'47', N'2', N'2019-03-28 00:00:00.000');
GO
INSERT INTO [dbo].[orders] ([order_id], [table_id], [order_date]) VALUES (N'48', N'4', N'2019-03-28 00:00:00.000');
GO
INSERT INTO [dbo].[orders] ([order_id], [table_id], [order_date]) VALUES (N'49', N'5', N'2019-03-28 00:00:00.000');
GO
INSERT INTO [dbo].[orders] ([order_id], [table_id], [order_date]) VALUES (N'50', N'3', N'2019-03-28 00:00:00.000');
GO
INSERT INTO [dbo].[orders] ([order_id], [table_id], [order_date]) VALUES (N'51', N'1', N'2019-03-28 00:00:00.000');
GO
INSERT INTO [dbo].[orders] ([order_id], [table_id], [order_date]) VALUES (N'52', N'2', N'2019-03-29 00:00:00.000');
GO
INSERT INTO [dbo].[orders] ([order_id], [table_id], [order_date]) VALUES (N'55', N'1', N'2019-04-07 00:00:00.000');
GO
SET IDENTITY_INSERT [dbo].[orders] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[sheft_Day_details]
-- ----------------------------
DROP TABLE [dbo].[sheft_Day_details]
GO
CREATE TABLE [dbo].[sheft_Day_details] (
[sheft_day_id] int NOT NULL IDENTITY(1,1) ,
[total_sell] float(53) NOT NULL ,
[date] date NOT NULL ,
[total_boughts] float(53) NOT NULL ,
[sheft_day_finish] tinyint NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[sheft_Day_details]', RESEED, 4)
GO

-- ----------------------------
-- Records of sheft_Day_details
-- ----------------------------
SET IDENTITY_INSERT [dbo].[sheft_Day_details] ON
GO
INSERT INTO [dbo].[sheft_Day_details] ([sheft_day_id], [total_sell], [date], [total_boughts], [sheft_day_finish]) VALUES (N'1', N'160', N'2017-02-06', N'1800', N'1');
GO
INSERT INTO [dbo].[sheft_Day_details] ([sheft_day_id], [total_sell], [date], [total_boughts], [sheft_day_finish]) VALUES (N'4', N'26', N'2019-03-30', N'0', N'0');
GO
SET IDENTITY_INSERT [dbo].[sheft_Day_details] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[subcategory]
-- ----------------------------
DROP TABLE [dbo].[subcategory]
GO
CREATE TABLE [dbo].[subcategory] (
[subcategory_id] int NOT NULL IDENTITY(1,1) ,
[subcategory_name] varchar(55) NOT NULL ,
[subcategory_price] float(53) NOT NULL ,
[category_id] int NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[subcategory]', RESEED, 6)
GO

-- ----------------------------
-- Records of subcategory
-- ----------------------------
SET IDENTITY_INSERT [dbo].[subcategory] ON
GO
INSERT INTO [dbo].[subcategory] ([subcategory_id], [subcategory_name], [subcategory_price], [category_id]) VALUES (N'1', N'قهوة', N'5', N'1');
GO
INSERT INTO [dbo].[subcategory] ([subcategory_id], [subcategory_name], [subcategory_price], [category_id]) VALUES (N'2', N'Ice Cream', N'7', N'2');
GO
INSERT INTO [dbo].[subcategory] ([subcategory_id], [subcategory_name], [subcategory_price], [category_id]) VALUES (N'4', N'شاي', N'5', N'1');
GO
INSERT INTO [dbo].[subcategory] ([subcategory_id], [subcategory_name], [subcategory_price], [category_id]) VALUES (N'5', N'سحلب', N'8', N'1');
GO
INSERT INTO [dbo].[subcategory] ([subcategory_id], [subcategory_name], [subcategory_price], [category_id]) VALUES (N'6', N'عصير مانجو', N'10', N'2');
GO
SET IDENTITY_INSERT [dbo].[subcategory] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[table_sheft]
-- ----------------------------
DROP TABLE [dbo].[table_sheft]
GO
CREATE TABLE [dbo].[table_sheft] (
[table_sheft_id] int NOT NULL IDENTITY(1,1) ,
[order_id] int NOT NULL ,
[table_sheft_money] float(53) NOT NULL ,
[table_date] date NOT NULL ,
[table_start_time] time(7) NOT NULL ,
[table_end_time] time(7) NOT NULL ,
[table_finish] tinyint NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[table_sheft]', RESEED, 41)
GO

-- ----------------------------
-- Records of table_sheft
-- ----------------------------
SET IDENTITY_INSERT [dbo].[table_sheft] ON
GO
INSERT INTO [dbo].[table_sheft] ([table_sheft_id], [order_id], [table_sheft_money], [table_date], [table_start_time], [table_end_time], [table_finish]) VALUES (N'32', N'46', N'30', N'2019-03-28', 0x31313A34343A34352E30303030303030, 0x31313A34343A34352E30303030303030, N'1');
GO
INSERT INTO [dbo].[table_sheft] ([table_sheft_id], [order_id], [table_sheft_money], [table_date], [table_start_time], [table_end_time], [table_finish]) VALUES (N'33', N'47', N'70', N'2019-03-28', 0x31323A31323A33382E30303030303030, 0x31323A31323A33382E30303030303030, N'1');
GO
INSERT INTO [dbo].[table_sheft] ([table_sheft_id], [order_id], [table_sheft_money], [table_date], [table_start_time], [table_end_time], [table_finish]) VALUES (N'34', N'48', N'34', N'2019-03-28', 0x31353A30373A33382E30303030303030, 0x31353A30373A33382E30303030303030, N'1');
GO
INSERT INTO [dbo].[table_sheft] ([table_sheft_id], [order_id], [table_sheft_money], [table_date], [table_start_time], [table_end_time], [table_finish]) VALUES (N'35', N'49', N'17', N'2019-03-28', 0x31353A31323A33372E30303030303030, 0x31353A31323A33372E30303030303030, N'1');
GO
INSERT INTO [dbo].[table_sheft] ([table_sheft_id], [order_id], [table_sheft_money], [table_date], [table_start_time], [table_end_time], [table_finish]) VALUES (N'36', N'50', N'20', N'2019-03-28', 0x31373A33363A31372E30303030303030, 0x31373A33363A31372E30303030303030, N'1');
GO
INSERT INTO [dbo].[table_sheft] ([table_sheft_id], [order_id], [table_sheft_money], [table_date], [table_start_time], [table_end_time], [table_finish]) VALUES (N'37', N'51', N'21', N'2019-03-28', 0x31373A33373A35382E30303030303030, 0x31373A33373A35382E30303030303030, N'1');
GO
INSERT INTO [dbo].[table_sheft] ([table_sheft_id], [order_id], [table_sheft_money], [table_date], [table_start_time], [table_end_time], [table_finish]) VALUES (N'38', N'52', N'40', N'2019-03-29', 0x30303A34373A31312E30303030303030, 0x30303A34373A31312E30303030303030, N'1');
GO
INSERT INTO [dbo].[table_sheft] ([table_sheft_id], [order_id], [table_sheft_money], [table_date], [table_start_time], [table_end_time], [table_finish]) VALUES (N'41', N'55', N'26', N'2019-04-07', 0x31313A30353A33352E30303030303030, 0x31313A30353A33352E30303030303030, N'0');
GO
SET IDENTITY_INSERT [dbo].[table_sheft] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[tables]
-- ----------------------------
DROP TABLE [dbo].[tables]
GO
CREATE TABLE [dbo].[tables] (
[table_id] int NOT NULL IDENTITY(1,1) ,
[table_name] varchar(55) NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[tables]', RESEED, 15)
GO

-- ----------------------------
-- Records of tables
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tables] ON
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'1', N'طرابيزة واحد');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'2', N'طربيزة اثنين');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'3', N'طربيزة ثلاثة');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'4', N'طربيزة اربعة');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'5', N'طربية خمسة');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'6', N'طربيزة ستة');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'7', N'طربيزة سبعة');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'8', N'طربيزة ثمانية');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'9', N'طربيزة تسعة');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'10', N'طربيزة عشرة');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'11', N'طربيزة احد عشر');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'12', N'طربيزة اثناعشر');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'13', N'طربيرة ثالث عشر');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'14', N'طربيزة اربعة عشر');
GO
INSERT INTO [dbo].[tables] ([table_id], [table_name]) VALUES (N'15', N'طربيزة خمسة عشر');
GO
SET IDENTITY_INSERT [dbo].[tables] OFF
GO

-- ----------------------------
-- Indexes structure for table bought_type
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[bought_type]
-- ----------------------------
ALTER TABLE [dbo].[bought_type] ADD PRIMARY KEY ([bought_type_id])
GO

-- ----------------------------
-- Indexes structure for table boughts
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[boughts]
-- ----------------------------
ALTER TABLE [dbo].[boughts] ADD PRIMARY KEY ([id_boughts])
GO

-- ----------------------------
-- Indexes structure for table category
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[category]
-- ----------------------------
ALTER TABLE [dbo].[category] ADD PRIMARY KEY ([category_id])
GO

-- ----------------------------
-- Indexes structure for table locker
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[locker]
-- ----------------------------
ALTER TABLE [dbo].[locker] ADD PRIMARY KEY ([locker_id])
GO

-- ----------------------------
-- Indexes structure for table login_check
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[login_check]
-- ----------------------------
ALTER TABLE [dbo].[login_check] ADD PRIMARY KEY ([logincheck_id])
GO

-- ----------------------------
-- Indexes structure for table order_details
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[order_details]
-- ----------------------------
ALTER TABLE [dbo].[order_details] ADD PRIMARY KEY ([order_details_id])
GO

-- ----------------------------
-- Indexes structure for table orders
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[orders]
-- ----------------------------
ALTER TABLE [dbo].[orders] ADD PRIMARY KEY ([order_id])
GO

-- ----------------------------
-- Indexes structure for table sheft_Day_details
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[sheft_Day_details]
-- ----------------------------
ALTER TABLE [dbo].[sheft_Day_details] ADD PRIMARY KEY ([sheft_day_id])
GO

-- ----------------------------
-- Indexes structure for table subcategory
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[subcategory]
-- ----------------------------
ALTER TABLE [dbo].[subcategory] ADD PRIMARY KEY ([subcategory_id])
GO

-- ----------------------------
-- Indexes structure for table table_sheft
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[table_sheft]
-- ----------------------------
ALTER TABLE [dbo].[table_sheft] ADD PRIMARY KEY ([table_sheft_id])
GO

-- ----------------------------
-- Indexes structure for table tables
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[tables]
-- ----------------------------
ALTER TABLE [dbo].[tables] ADD PRIMARY KEY ([table_id])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[boughts]
-- ----------------------------
ALTER TABLE [dbo].[boughts] ADD FOREIGN KEY ([boughts_type_id]) REFERENCES [dbo].[bought_type] ([bought_type_id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[order_details]
-- ----------------------------
ALTER TABLE [dbo].[order_details] ADD FOREIGN KEY ([order_id]) REFERENCES [dbo].[orders] ([order_id]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[order_details] ADD FOREIGN KEY ([subcategory_id]) REFERENCES [dbo].[subcategory] ([subcategory_id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[orders]
-- ----------------------------
ALTER TABLE [dbo].[orders] ADD FOREIGN KEY ([table_id]) REFERENCES [dbo].[tables] ([table_id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[subcategory]
-- ----------------------------
ALTER TABLE [dbo].[subcategory] ADD FOREIGN KEY ([category_id]) REFERENCES [dbo].[category] ([category_id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[table_sheft]
-- ----------------------------
ALTER TABLE [dbo].[table_sheft] ADD FOREIGN KEY ([order_id]) REFERENCES [dbo].[orders] ([order_id]) ON DELETE CASCADE ON UPDATE CASCADE
GO
