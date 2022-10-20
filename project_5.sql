-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 20, 2022 at 11:09 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `project_5`
--

-- --------------------------------------------------------

--
-- Table structure for table `basket`
--

CREATE TABLE `basket` (
  `id` int(11) NOT NULL,
  `name` text COLLATE utf8_unicode_ci NOT NULL,
  `buy` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `สถานะ` int(11) NOT NULL,
  `คำสั่งซื้อจาก` text COLLATE utf8_unicode_ci NOT NULL,
  `ราคา` int(11) NOT NULL,
  `จำนวน` int(11) NOT NULL,
  `เวลา` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `basket`
--

INSERT INTO `basket` (`id`, `name`, `buy`, `สถานะ`, `คำสั่งซื้อจาก`, `ราคา`, `จำนวน`, `เวลา`) VALUES
(6, 'มิจิ', 'ds', 1, 'siwadon', 20, 1, '12/7/2565'),
(7, 'siwadon', 'กินข้าว', 1, 'siwadon', 20, 1, '12/7/2565'),
(8, 'siwadon', 'กินไก่', 1, 'siwadon', 12, 1, '12/7/2565'),
(9, 'siwadon', 'กินหมู', 1, 'siwadon', 112, 1, '12/7/2565'),
(10, 'siwadon', 'อินดิกา', 1, 'ระบบ', 5500, 1, '13/7/2565'),
(11, 'siwadon', 'อินดิกา', 1, 'ระบบ', 5500, 5, '16/7/2565'),
(12, 'siwadon', 'ซาติวา', 1, 'ระบบ', 6000, 1, '16/7/2565'),
(13, 'siwadon', 'ก้านเขียว', 1, 'ระบบ', 500, 1, '16/7/2565'),
(14, 'siwadon', 'ก้านเขียว', 1, 'ระบบ', 500, 15, '16/7/2565'),
(15, 'siwadon', 'อินดิกา', 1, 'ระบบ', 5500, 1, '16/7/2565'),
(16, 'siwadon', 'รูเดอราลิส', 1, 'ระบบ', 4000, 1, '16/7/2565'),
(17, 'siwadon', 'ก้านแดง', 1, 'ระบบ', 400, 1, '16/7/2565'),
(18, 's', 'ก้านแดง', 1, 'ระบบ', 555555, 1, '16/7/2565'),
(19, 'w', 'ก้านแดงหางกั้น', 1, 'ระบบ', 450, 1, '16/7/2565'),
(20, 'e', 'รูเดอราลิส', 1, 'ระบบ', 4000, 1, '16/7/2565'),
(21, 'siwadon', 'รูเดอราลิส', 1, 'ระบบ', 4000, 1, '16/7/2565'),
(22, 'siwadon', 'รูเดอราลิส', 1, 'ระบบ', 4000, 1, '16/7/2565'),
(23, 'siwadon', 'อินดิกา', 1, 'ระบบ', 11000, 2, '16/7/2565'),
(24, 'siwadon', 'อินดิกา', 1, 'ระบบ', 5500, 1, '16/7/2565'),
(25, 'siwadon', 'อินดิกา', 1, 'ระบบ', 11000, 2, '16/7/2565'),
(26, 'มิจิ', 'กินเหล้า', 1, 'siwadon', 222, 1, '17/7/2565'),
(27, 'มิจิ', 'นางฟ้า', 1, 'มิจิ', 100000, 1, '17/7/2565'),
(28, 'มิจิ', 'อินดิกา', 1, 'ระบบ', 5500, 1, '17/7/2565'),
(29, 'มิจิ', 'ซาติวา', 1, 'ระบบ', 6000, 1, '17/7/2565'),
(30, 'siwadon', 'กินเบียร์', 1, 'siwadon', 222, 1, '21/7/2565'),
(31, 'siwadon', 'กินเหล้า', 1, 'siwadon', 222, 1, '21/7/2565'),
(32, 'siwadon', 'นางฟ้า', 1, 'มิจิ', 100000, 1, '21/7/2565'),
(33, 'siwadon', 'ds', 1, 'siwadon', 20, 1, '21/7/2565'),
(34, 'siwadon', 'ต้มไก่', 1, 'siw', 100, 1, '21/7/2565'),
(35, 'siwadon', 'ใบหม่อน', 1, 'nongmon', 200000, 1, '21/7/2565'),
(36, 'siwadon', 'อินดิกา', 1, 'ระบบ', 5500, 1, '20/10/2565'),
(37, 'siwadon', 'อินดิกา', 1, 'ระบบ', 5500, 1, '20/10/2565'),
(38, 'siwadon', 'ก้านแดงหางกั้น', 1, 'ระบบ', 1800, 4, '20/10/2565'),
(39, 'siwadon', 'ไก่ทอด', 0, 'มิจิ', 13, 1, '20/10/2565');

-- --------------------------------------------------------

--
-- Table structure for table `store`
--

CREATE TABLE `store` (
  `name` text COLLATE utf8_unicode_ci NOT NULL,
  `Products` text COLLATE utf8_unicode_ci NOT NULL,
  `content` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `price` int(11) NOT NULL,
  `type` text COLLATE utf8_unicode_ci NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `store`
--

INSERT INTO `store` (`name`, `Products`, `content`, `price`, `type`, `id`) VALUES
('nongmon', 'ใบหม่อน', 'ใบหม่อนตาฮักเว่อเเบบเว่อๆๆๆ เเบบมากๆๆๆๆๆๆๆ', 200000, 'อินดิกา', 16),
('มิจิ', 'นางฟ้า', 'ชงกับเหล้าขาว\nกับน้ำแดง \nยาแก้ไอกับน้ำมะนาว\nรับรองได้ขึ้นสวรรค์', 100000, 'รูเดอราลิส', 17),
('่jaruwit', 'ใบสดปั่นสมูทตี้', 'กินคู่กับเหล้าขาว', 200, 'ก้านแดงหางกั้น', 19),
('mtbb9397', 'คนกินตายคนขายรอด', 'ซาติวาผสมยาแก้ไอตราน้ำดำ\nซาติวาผสมยาบ้า\nซาติวาผสมน้ำผึ้ง', 10000, 'ซาติวา ', 22),
('siwadon', 'กินข้าว', 'กินรวมกับข้าว', 20, 'ซาติวา ', 23),
('siwadon', 'กินเหล้า', 'ๆๆๆๆๆๆๆๆๆๆๆๆๆๆๆๆๆๆๆๆๆๆ', 222, 'รูเดอราลิส', 24),
('siwadon', 'กินเบียร์', 'wwwwwww', 222, 'รูเดอราลิส', 25),
('siwadon', 'กินไก่', 'กกกกกกกกกกกกกกกกกกกก', 12, 'ซาติวา ', 26),
('siwadon', 'กินหมู', 'eeweweweweweweweweeeeeee', 112, 'ซาติวา ', 27),
('siwadon', 'กินข้าวววววว', 'qqqqqqqqq', 222, 'ซาติวา ', 28),
('siw', 'ต้มไก่', 'ใส่ต้มไก่บ้าน แล้วกินกับกาแฟ จะอร่อยมากไม่รู้เป็นไร\nต้องกินกับเพื่อนครับ\nแต่ต้องมีน้ำเปล่าด้วยนะครับ\nใส่ลาบไก่ก็อร่อยทำให้หวานๆหน่อย กินแล้วเมายาว ขอบคุณครับ\n', 100, 'อินดิกา', 32),
('siwadon', 'ยยยย', 'กกกกกกก', 1234, 'ซาติวา ', 34),
('มิจิ', 'ไก่ทอด', 'เป็นของดีเมื่องเลย', 13, 'ก้านแดง', 35);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `phonenumber` text COLLATE utf8_unicode_ci NOT NULL,
  `appress` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `email` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `name`, `password`, `phonenumber`, `appress`, `email`) VALUES
(1, 'siwadon', '0944200422', '0944200422', 'หอ7', 'siwadon@gmail.com'),
(2, 'le001', '0944200422', '0944200422', 'dom7 kku 2040', 'siwadon.h@kkumail.com'),
(3, 'kkk', '0944200422', '0944200422', 'dom7777777', 'siwadon@kkumail.com'),
(4, 'kusumi', '1234', '0610359860', 'dommmm', 'kusumi@gmail.com'),
(5, 'nongmon', '5555', '0927359933', '555', 'baimon@gmail.com'),
(6, 'มิจิ', '123', '0656671132', 'BKK', 'thana@gmail.com'),
(7, 'callmefiftyfive', 'ffive1235', '0616315367', 'lungmor kku', 'rachata@gmail.com'),
(8, 'jaruwit ', 'toy007915', '0886826814', 'หอ', 'jaruwit.m@kkumail.com'),
(9, 'mali', 'ๅ/-ภถ', '0993456780', 'ธนารมย์เพลส', 'maliwanjanta@gmail.com'),
(10, 'maliwan', '12345', '0993456780', 'ธนารมย์เพลส', 'maliwanjanta@gmail.com'),
(11, 'Maliwan', '00000', '0934181862', 'ธนารทมย์', 'Maiwan@gmail.com'),
(12, 'mtbb9397', '19931997', '0849321940', 'GOT 7 Forever', 'mtbblove@gmail.com'),
(13, 'siw', '0944200422', '0944200422', 'หอ7', 'siwado@gmail.com'),
(14, 'siwadonn', '0944200422', '0944200422', 'dorm7', 'siwadon00@gmail.com'),
(15, 's', '0944200422', '0944200422', 's', 'Email');

-- --------------------------------------------------------

--
-- Table structure for table `weed`
--

CREATE TABLE `weed` (
  `id` int(11) NOT NULL,
  `name` text COLLATE utf8_unicode_ci NOT NULL,
  `price` int(11) NOT NULL,
  `จำนวน` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `weed`
--

INSERT INTO `weed` (`id`, `name`, `price`, `จำนวน`) VALUES
(1, 'ซาติวา', 6000, 98),
(2, 'อินดิกา', 5500, 368),
(3, 'รูเดอราลิส', 4000, 100),
(4, 'ก้านเขียว', 500, 64),
(5, 'ก้านแดงหางกั้น', 450, 796),
(6, 'ก้านแดง', 400, 108);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `basket`
--
ALTER TABLE `basket`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `store`
--
ALTER TABLE `store`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `weed`
--
ALTER TABLE `weed`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `basket`
--
ALTER TABLE `basket`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `store`
--
ALTER TABLE `store`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `weed`
--
ALTER TABLE `weed`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
