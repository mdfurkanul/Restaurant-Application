-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 20, 2015 at 10:03 PM
-- Server version: 5.6.20
-- PHP Version: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `ra`
--

-- --------------------------------------------------------

--
-- Table structure for table `favourite`
--

CREATE TABLE IF NOT EXISTS `favourite` (
`id` int(11) NOT NULL,
  `food_id` varchar(20) NOT NULL,
  `c_id` varchar(20) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `favourite`
--

INSERT INTO `favourite` (`id`, `food_id`, `c_id`) VALUES
(1, '5', 'mfi7391@gmail.com'),
(3, '15', 'mfi7391@gmail.com'),
(6, '7', 'mfi7391@gmail.com'),
(8, '13', 'mfi7391@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `food_order`
--

CREATE TABLE IF NOT EXISTS `food_order` (
`id` int(11) NOT NULL,
  `food_id` varchar(20) NOT NULL,
  `c_id` varchar(20) NOT NULL,
  `quantity` varchar(20) NOT NULL,
  `price` varchar(30) NOT NULL,
  `message` varchar(500) NOT NULL,
  `who` varchar(50) NOT NULL,
  `status` varchar(5) NOT NULL DEFAULT '3'
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=68 ;

--
-- Dumping data for table `food_order`
--

INSERT INTO `food_order` (`id`, `food_id`, `c_id`, `quantity`, `price`, `message`, `who`, `status`) VALUES
(35, '10', 'Guest', '4', '1000', '', '02:14:21 AMtable4', '2'),
(36, '13', 'mfi7391@gmail.com', '2', '700', '', '02:17:56 AMtable1', '2'),
(37, '11', 'Guest', '1', '100', '', '23:02:55 PMtable7', '2'),
(38, '15', 'mfi7391@gmail.com', '3', '330', '', '01:03:26 AMtable18', '2'),
(39, '12', 'mfi7391@gmail.com', '1', '210', '', '01:03:26 AMtable18', '2'),
(40, '15', 'mfi7391@gmail.com', '4', '440', '', '01:08:38 AMtable1', '2'),
(41, '13', 'mfi7391@gmail.com', '2', '700', '', '01:11:44 AMtable3', '2'),
(42, '10', 'mfi7391@gmail.com', '4', '1000', '', '01:11:44 AMtable3', '2'),
(43, '15', 'mfi7391@gmail.com', '3', '330', '', '01:25:30 AMtable5', '2'),
(44, '13', 'mfi7391@gmail.com', '1', '350', '', '01:25:30 AMtable5', '2'),
(45, '13', 'mfi7391@gmail.com', '1', '350', '', '01:28:30 AMtable6', '2'),
(46, '14', 'mfi7391@gmail.com', '1', '350', '', '01:28:30 AMtable6', '2'),
(47, '6', 'mfi7391@gmail.com', '1', '350', '', '01:28:30 AMtable6', '2'),
(48, '13', 'mfi7391@gmail.com', '1', '350', '', '01:28:30 AMtable6', '2'),
(49, '12', 'Guest', '1', '210', '', '01:35:20 AMtable16', '3'),
(50, '10', 'Guest', '5', '1250', '', '01:35:20 AMtable16', '3'),
(51, '14', 'Guest', '3', '3000', '', '01:36:42 AMtable14', '3'),
(52, '12', 'Guest', '3', '630', '', '01:36:42 AMtable14', '3'),
(53, '6', 'Guest', '3', '3000', '', '01:36:42 AMtable14', '3'),
(54, '14', 'Guest', '3', '3000', '', '01:41:16 AMtable7', '2'),
(55, '12', 'Guest', '1', '210', '', '01:41:16 AMtable7', '2'),
(56, '12', 'Guest', '1', '210', '', '01:41:16 AMtable7', '1'),
(57, '5', 'Guest', '1', '500', '', '01:43:59 AMtable15', '2'),
(58, '13', 'Guest', '1', '350', '', '01:43:59 AMtable15', '2'),
(59, '13', 'Guest', '1', '350', '', '01:43:59 AMtable15', '2'),
(60, '13', 'Guest', '3', '1050', '', '01:50:38 AMtable13', '2'),
(61, '12', 'Guest', '1', '210', '', '01:50:38 AMtable13', '2'),
(62, '11', 'Guest', '2', '200', '', '01:50:38 AMtable13', '0'),
(63, '13', 'mfi7391@gmail.com', '2', '700', '', '01:54:44 AMtable14', '2'),
(64, '15', 'mfi7391@gmail.com', '1', '110', '', '01:54:44 AMtable14', '2'),
(65, '12', 'mfi7391@gmail.com', '1', '210', '', '01:54:44 AMtable14', '0'),
(66, '5', 'Guest', '1', '500', '', '01:58:12 AMtable18', '0'),
(67, '5', 'Guest', '1', '500', '', '02:01:36 AMtable16', '0');

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE IF NOT EXISTS `menu` (
`Id` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Description` text NOT NULL,
  `Price` int(255) NOT NULL,
  `CookingTime` int(11) NOT NULL,
  `Image` varchar(100) NOT NULL DEFAULT 'Defualt.png',
  `catalog` int(11) NOT NULL,
  `totalorder` int(255) NOT NULL DEFAULT '0'
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

--
-- Dumping data for table `menu`
--

INSERT INTO `menu` (`Id`, `Name`, `Description`, `Price`, `CookingTime`, `Image`, `catalog`, `totalorder`) VALUES
(5, 'lemon chicken', 'lemon chicken is\r\n sour items.', 500, 10, 'lemon chicken.jpg', 3, 7),
(6, 'Oxtail', 'Oxtail is a arabian''s foods.', 1000, 10, 'oxtail.jpg', 10, 4),
(7, 'Stream rice', 'It''s a normal Rice.', 50, 2, 'steam-rice.jpg', 4, 1),
(8, 'Vegetables chow mein', 'Vegetables chow mein\r\nis a one kinds of vegetables foods.', 200, 5, 'vegetables chow mein.jpg', 5, 6),
(9, 'Vegetables Soup', 'Vegetables Soup is the \r\nmixer of Vegetables and Soup.', 150, 4, 'Vegetables-Soup.jpg', 1, 1),
(10, 'Vegetable lo mein', 'vegetable lo mein is one kinds of lo mein foods with vegetable ', 250, 6, 'vegetable lo mein.jpg', 6, 7),
(11, 'Chili chicken', 'Chili chicken is chicken with chili.', 100, 9, 'chilli chicken.jpg', 9, 5),
(12, 'Spring rolls', 'Spring rolls is a rolls.', 210, 12, 'spring rolls.jpg', 2, 8),
(13, 'Spicy beef', 'Spicy beef is a beef masala.', 350, 15, 'spicy_beef.jpg', 8, 13),
(14, 'Spicy squids', 'Spicy squids is a sea one\r\nkinds of food.', 1000, 13, 'spicy squids.jpg', 7, 4),
(15, 'Fried chicken', 'Fried chicken is a fried of chicken.', 110, 10, 'Fried chicken.jpeg', 12, 10),
(16, 'Ice Cream', 'Lemon', 20, 2, '20150820181757_20150820181721_History-of-Ice-Cream-1.jpg', 12, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tablebookingstatus`
--

CREATE TABLE IF NOT EXISTS `tablebookingstatus` (
  `tableNo` varchar(20) NOT NULL,
  `Status` varchar(2) NOT NULL DEFAULT '0',
  `userID` varchar(50) NOT NULL,
  `delay` varchar(20) NOT NULL DEFAULT '00:00:00'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tablebookingstatus`
--

INSERT INTO `tablebookingstatus` (`tableNo`, `Status`, `userID`, `delay`) VALUES
('table1', '0', 'None', '00:00:00'),
('table10', '0', 'None', '00:00:00'),
('table11', '0', 'None', '00:00:00'),
('table12', '0', 'None', '00:00:00'),
('table13', '1', '01:50:38 AMtable13', '00:00:00'),
('table14', '1', '01:54:44 AMtable14', '00:00:00'),
('table15', '1', '01:43:59 AMtable15', '00:00:00'),
('table16', '1', '02:01:36 AMtable16', '00:00:00'),
('table17', '0', 'None', '00:00:00'),
('table18', '1', '01:58:12 AMtable18', '00:00:00'),
('table2', '0', 'None', '00:00:00'),
('table3', '0', 'None', '00:00:00'),
('table4', '0', 'None', '00:00:00'),
('table5', '0', 'None', '00:00:00'),
('table6', '0', 'None', '00:00:00'),
('table7', '1', '01:41:16 AMtable7', '00:00:00'),
('table8', '0', 'None', '00:00:00'),
('table9', '0', 'None', '00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `userinfo`
--

CREATE TABLE IF NOT EXISTS `userinfo` (
  `Name` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Mobile` varchar(30) NOT NULL,
  `Pass` varchar(30) NOT NULL,
  `Type` varchar(20) NOT NULL,
  `Image` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `userinfo`
--

INSERT INTO `userinfo` (`Name`, `Email`, `Mobile`, `Pass`, `Type`, `Image`) VALUES
('furkan', '12303051@iubat.edu', '01824053343', '3', 'Chef', '20150820022426_Waiter-512.png'),
('Md Furkanul Islam', 'mfi7391@gmail.com', '01681666115', '12321', 'Member', '20150819210556_pp.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `waiting_quque`
--

CREATE TABLE IF NOT EXISTS `waiting_quque` (
  `id` varchar(50) NOT NULL,
  `status` varchar(5) NOT NULL DEFAULT '0',
  `delay` varchar(20) NOT NULL DEFAULT '00:00:00'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `waiting_quque`
--

INSERT INTO `waiting_quque` (`id`, `status`, `delay`) VALUES
('01:03:26 AMtable18', '0', '00:00:00'),
('01:08:38 AMtable1', '0', '00:00:00'),
('01:11:44 AMtable3', '0', '00:00:00'),
('01:25:30 AMtable5', '0', '00:00:00'),
('01:28:30 AMtable6', '0', '00:00:00'),
('01:35:20 AMtable16', '2', '00:00:00'),
('01:36:42 AMtable14', '0', '00:00:00'),
('01:41:16 AMtable7', '0', '00:00:00'),
('01:43:59 AMtable15', '2', '00:00:00'),
('01:50:38 AMtable13', '2', '00:00:00'),
('01:54:44 AMtable14', '2', '00:00:00'),
('01:58:12 AMtable18', '2', '00:08:26'),
('02:01:36 AMtable16', '2', '00:02:20'),
('02:14:21 AMtable4', '1', '00:01:51'),
('02:17:56 AMtable1', '1', '00:08:51'),
('23:02:55 PMtable7', '1', '00:06:05');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `favourite`
--
ALTER TABLE `favourite`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `food_order`
--
ALTER TABLE `food_order`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
 ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `tablebookingstatus`
--
ALTER TABLE `tablebookingstatus`
 ADD PRIMARY KEY (`tableNo`);

--
-- Indexes for table `userinfo`
--
ALTER TABLE `userinfo`
 ADD PRIMARY KEY (`Email`);

--
-- Indexes for table `waiting_quque`
--
ALTER TABLE `waiting_quque`
 ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `favourite`
--
ALTER TABLE `favourite`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `food_order`
--
ALTER TABLE `food_order`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=68;
--
-- AUTO_INCREMENT for table `menu`
--
ALTER TABLE `menu`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=17;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
