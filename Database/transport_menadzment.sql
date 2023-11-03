-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 16, 2023 at 04:46 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `transport_menadzment`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `rezervacija_po_turi` (IN `tempTuraID` INT(11))   BEGIN
SELECT 
	rezervacija.RezervacijaID,
    putnik.Ime AS "Ime",
    putnik.Prezime AS "Prezime",
    putnik.telefon AS "Broj telefona",
    rezervacija.Cena AS "Cena karte",
    rezervacija.Povratna AS "Povratna karta",
    tura.VremeUkrcavanja AS "Vreme ukrcavanja",
    lokacija.Grad AS "Destinacija"
FROM
	rezervacija,
    tura,
    putnik,
    lokacija
WHERE 
	rezervacija.PutnikID = putnik.PutnikID
    AND
    rezervacija.TuraID = tura.TuraID
    AND
    tura.ZavrsnaLokacijaID = lokacija.LokacijaID
    AND tura.TuraID =tempTuraID;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `vozac_vozilo_po_turi` (IN `tempTuraID` INT(11))   BEGIN
SELECT 
	tura.TuraID,
    tura.VremePolaska AS "Vreme polaska",
    lokacija.Grad AS "Startna lokacija",
    vozac.Ime AS "Ime vozaca",
    vozac.Telefon AS "Broj telefona",
    vozac.Kategorija,
    vozilo.Brend AS "Brend vozila",
    vozilo.Tip AS "Tip vozila",
    vozilo.Boja AS "Boja vozila",
    vozilo.BrojSedista AS "Broj sedista"
FROM
	tura,
    vozac,
    vozilo,
    lokacija
WHERE 
	tura.VozacID = vozac.VozacID
    AND
    tura.VoziloID = vozilo.VoziloID
    AND
    tura.StartnaLokacijaID = lokacija.LokacijaID
    AND tura.TuraID =tempTuraID;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `korisnici`
--

CREATE TABLE `korisnici` (
  `korisnik_id` int(11) NOT NULL,
  `korisnik` varchar(50) NOT NULL,
  `lozinka` varchar(50) NOT NULL,
  `nivo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `korisnici`
--

INSERT INTO `korisnici` (`korisnik_id`, `korisnik`, `lozinka`, `nivo`) VALUES
(1, 'admin', 'admin', 'Admin'),
(2, 'tarik', '123', 'Korisnik');

-- --------------------------------------------------------

--
-- Table structure for table `lokacija`
--

CREATE TABLE `lokacija` (
  `LokacijaID` int(11) NOT NULL,
  `Grad` varchar(255) NOT NULL,
  `Naziv` varchar(255) NOT NULL,
  `Adresa` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `lokacija`
--

INSERT INTO `lokacija` (`LokacijaID`, `Grad`, `Naziv`, `Adresa`) VALUES
(1, 'Novi Pazar', 'Pumpa', 'Sadovic Pumpa'),
(2, 'Beograd', 'Aerodrom', 'Nikola Tesla'),
(3, 'Nis', 'Aerodrom', 'Konstantin Veliki'),
(5, 'Kraljevo', 'Autobuska stanica sn', 'Kraljevo Autobuska Stanica');

-- --------------------------------------------------------

--
-- Table structure for table `putnik`
--

CREATE TABLE `putnik` (
  `PutnikID` int(11) NOT NULL,
  `Ime` varchar(255) NOT NULL,
  `Prezime` varchar(255) NOT NULL,
  `Adresa` varchar(255) NOT NULL,
  `telefon` varchar(255) NOT NULL,
  `Godine` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `putnik`
--

INSERT INTO `putnik` (`PutnikID`, `Ime`, `Prezime`, `Adresa`, `telefon`, `Godine`) VALUES
(1, 'Ahmed', 'Abdulović', 'Ul. Kralja Petra 1', '+381631234567', 25),
(2, 'Aisha', 'Hassanović', 'Ul. Vuka Karadžića 2', '+381641234567', 32),
(3, 'Yusuf', 'Ibrahimović', 'Ul. Cara Dušana 3', '+381651234567', 40),
(4, 'Fatima', 'Kadirović', 'Ul. Nikole Tesle 4', '+381661234567', 19),
(5, 'Ali', 'Mahmudović', 'Ul. Cara Lazara 5', '+381671234567', 28),
(6, 'Amina', 'Salihović', 'Ul. Vojvode Stepe 6', '+381681234567', 36),
(7, 'Muhammad', 'Sulaimanović', 'Ul. Đorđa Stanojevića 7', '+381691234567', 22),
(8, 'Zahra', 'Alić', 'Ul. Kralja Milutina 8', '+381601234567', 31),
(9, 'Mustafa', 'Hamzaović', 'Ul. Despota Stefana 9', '+381611234567', 45),
(10, 'Mariam', 'Yusufović', 'Ul. Nemanjina 10', '+381621234567', 27),
(11, 'Omar', 'Ismailović', 'Ul. Cara Dušana 11', '+381631234567', 38),
(12, 'Khadija', 'Fatihović', 'Ul. Vuka Karadžića 12', '+381641234567', 29),
(13, 'Hassan', 'Ahmedović', 'Ul. Nikole Tesle 13', '+381651234567', 24),
(14, 'Aisha', 'Osmanović', 'Ul. Cara Lazara 14', '+381661234567', 35),
(15, 'Yasin', 'Abbasović', 'Ul. Vojvode Stepe 15', '+381671234567', 43),
(16, 'Sara', 'Zubairović', 'Ul. Đorđa Stanojevića 16', '+381691234567', 26),
(17, 'Ahmad', 'Ismailović', 'Ul. Kralja Petra 17', '+381601234567', 37),
(18, 'Amina', 'Azizović', 'Ul. Kralja Milutina 18', '+381611234567', 30),
(19, 'Nur', 'Yunusović', 'Ul. Despota Stefana 19', '+381621234567', 42),
(20, 'Hussein', 'Alić', 'Ul. Nemanjina 20', '+381631234567', 23);

-- --------------------------------------------------------

--
-- Table structure for table `rezervacija`
--

CREATE TABLE `rezervacija` (
  `RezervacijaID` int(11) NOT NULL,
  `Cena` varchar(255) NOT NULL,
  `KreiranaAt` datetime NOT NULL DEFAULT current_timestamp(),
  `Povratna` enum('Da','Ne') NOT NULL DEFAULT 'Ne',
  `PutnikID` int(11) NOT NULL,
  `TuraID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rezervacija`
--

INSERT INTO `rezervacija` (`RezervacijaID`, `Cena`, `KreiranaAt`, `Povratna`, `PutnikID`, `TuraID`) VALUES
(1, '30', '2023-06-14 00:49:58', 'Ne', 1, 1),
(2, '30', '2023-06-14 00:49:58', 'Ne', 2, 1),
(3, '30', '2023-06-14 00:49:58', 'Da', 3, 1),
(4, '25', '2023-06-14 00:49:58', 'Da', 4, 1),
(5, '25', '2023-06-14 00:49:58', 'Ne', 5, 1),
(6, '25', '2023-06-14 00:49:58', 'Da', 6, 2),
(7, '30', '2023-06-14 00:49:58', 'Da', 7, 2),
(8, '30', '2023-06-14 00:49:58', 'Da', 8, 2),
(9, '25', '2023-06-14 00:49:58', 'Da', 9, 2),
(10, '25', '2023-06-14 00:49:58', 'Ne', 10, 2),
(11, '30', '2023-06-14 00:49:58', 'Ne', 11, 3),
(12, '25', '2023-06-14 00:49:58', 'Da', 12, 3),
(13, '30', '2023-06-14 00:49:58', 'Ne', 13, 3),
(14, '25', '2023-06-14 00:49:58', 'Da', 14, 3),
(15, '30', '2023-06-14 00:49:58', 'Da', 15, 3),
(16, '30', '2023-06-14 00:49:58', 'Da', 16, 4),
(17, '30', '2023-06-14 00:49:58', 'Da', 17, 4),
(18, '30', '2023-06-14 00:49:58', 'Ne', 18, 4),
(19, '30', '2023-06-14 00:49:58', 'Ne', 19, 4),
(20, '30', '2023-06-14 00:49:58', 'Ne', 20, 4);

-- --------------------------------------------------------

--
-- Table structure for table `tura`
--

CREATE TABLE `tura` (
  `TuraID` int(11) NOT NULL,
  `DatumPolaska` date NOT NULL,
  `VremeUkrcavanja` time NOT NULL,
  `VremePolaska` time NOT NULL,
  `DatumStizanja` date NOT NULL,
  `VremeStizanja` time NOT NULL,
  `VoziloID` int(11) NOT NULL,
  `VozacID` int(11) NOT NULL,
  `StartnaLokacijaID` int(11) NOT NULL,
  `ZavrsnaLokacijaID` int(11) NOT NULL,
  `Status` enum('Cekanje','Aktuelna','Zavrsena') NOT NULL DEFAULT 'Cekanje'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tura`
--

INSERT INTO `tura` (`TuraID`, `DatumPolaska`, `VremeUkrcavanja`, `VremePolaska`, `DatumStizanja`, `VremeStizanja`, `VoziloID`, `VozacID`, `StartnaLokacijaID`, `ZavrsnaLokacijaID`, `Status`) VALUES
(1, '2023-06-20', '12:30:00', '13:00:00', '2023-06-20', '19:00:00', 1, 1, 1, 2, 'Zavrsena'),
(2, '2023-06-21', '16:30:00', '17:00:00', '2023-06-20', '21:00:00', 2, 2, 1, 3, 'Aktuelna'),
(3, '2023-06-22', '14:30:00', '15:00:00', '2023-06-20', '19:00:00', 3, 3, 2, 1, 'Cekanje'),
(4, '2023-06-22', '01:30:00', '02:00:00', '2023-06-20', '06:00:00', 4, 4, 2, 1, 'Cekanje');

-- --------------------------------------------------------

--
-- Stand-in structure for view `ture`
-- (See below for the actual view)
--
CREATE TABLE `ture` (
`TuraID` int(11)
,`Datum polaska` date
,`Vreme ukrcavanja` time
,`Vreme polaska` time
,`Datum stizanja` date
,`Vreme stizanja` time
,`Startna lokacija` varchar(255)
,`Zavrsna lokacija` varchar(255)
,`Ime vozaca` varchar(255)
,`Tip vozila` varchar(255)
,`Status` enum('Cekanje','Aktuelna','Zavrsena')
);

-- --------------------------------------------------------

--
-- Table structure for table `vozac`
--

CREATE TABLE `vozac` (
  `VozacID` int(11) NOT NULL,
  `Ime` varchar(255) NOT NULL,
  `Godine` varchar(255) NOT NULL,
  `Telefon` varchar(255) NOT NULL,
  `Kategorija` char(1) NOT NULL,
  `ZaposljenAt` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `vozac`
--

INSERT INTO `vozac` (`VozacID`, `Ime`, `Godine`, `Telefon`, `Kategorija`, `ZaposljenAt`) VALUES
(1, 'Siljo', '35', '4245245', 'B', '2023-02-24'),
(2, 'Ahmed', '32', '454545', 'B', '2023-03-24'),
(3, 'Medo', '33', '25440', 'D', '2023-06-24'),
(4, 'Mirsad', '29', '042552', 'B', '2023-06-21'),
(5, 'Tarik', '24', '4024204', 'B', '2023-06-20'),
(6, 'Irfan', '34', '40242', 'D', '2023-06-18'),
(7, 'Idriz', '32', '24024', 'D', '2023-06-17'),
(8, 'Sefko', '30', '204204', 'B', '2023-06-16'),
(10, 'Edis', '35', '423435435', 'B', '2017-06-26'),
(11, 'Emir', '34', '544004', 'B', '2016-06-26'),
(12, 'Beno', '31', '0635523552', 'B', '2023-06-15');

-- --------------------------------------------------------

--
-- Table structure for table `vozilo`
--

CREATE TABLE `vozilo` (
  `VoziloID` int(11) NOT NULL,
  `Brend` varchar(255) NOT NULL,
  `Tip` varchar(255) NOT NULL,
  `Boja` varchar(255) NOT NULL,
  `BrojSedista` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `vozilo`
--

INSERT INTO `vozilo` (`VoziloID`, `Brend`, `Tip`, `Boja`, `BrojSedista`) VALUES
(1, 'Mercedes', 'Minibus', 'Bordo', 20),
(2, 'Mercedes', 'Minibus', 'Bela', 16),
(3, 'Mercedes', 'Kombi', 'Plava', 9),
(4, 'Mercedes', 'Kombi', 'Siva', 9),
(5, 'Volkswagen', 'Mini-van', 'Crna', 6),
(6, 'Ford', 'Mini-van', 'Siva', 6),
(7, 'Volkswagen', 'Kombi', 'Bela', 9),
(8, 'Mercedes', 'Kombi', 'Bordo', 9),
(10, 'Mercedes', 'Kombi', 'Bela', 9);

-- --------------------------------------------------------

--
-- Structure for view `ture`
--
DROP TABLE IF EXISTS `ture`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `ture`  AS SELECT `t`.`TuraID` AS `TuraID`, `t`.`DatumPolaska` AS `Datum polaska`, `t`.`VremeUkrcavanja` AS `Vreme ukrcavanja`, `t`.`VremePolaska` AS `Vreme polaska`, `t`.`DatumStizanja` AS `Datum stizanja`, `t`.`VremeStizanja` AS `Vreme stizanja`, `l1`.`Grad` AS `Startna lokacija`, `l2`.`Grad` AS `Zavrsna lokacija`, `v`.`Ime` AS `Ime vozaca`, `vo`.`Tip` AS `Tip vozila`, `t`.`Status` AS `Status` FROM ((((`tura` `t` join `lokacija` `l1` on(`t`.`StartnaLokacijaID` = `l1`.`LokacijaID`)) join `lokacija` `l2` on(`t`.`ZavrsnaLokacijaID` = `l2`.`LokacijaID`)) join `vozac` `v` on(`v`.`VozacID` = `t`.`VozacID`)) join `vozilo` `vo` on(`vo`.`VoziloID` = `t`.`VoziloID`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `korisnici`
--
ALTER TABLE `korisnici`
  ADD PRIMARY KEY (`korisnik_id`),
  ADD UNIQUE KEY `korisnik_UNIQUE` (`korisnik`);

--
-- Indexes for table `lokacija`
--
ALTER TABLE `lokacija`
  ADD PRIMARY KEY (`LokacijaID`);

--
-- Indexes for table `putnik`
--
ALTER TABLE `putnik`
  ADD PRIMARY KEY (`PutnikID`);

--
-- Indexes for table `rezervacija`
--
ALTER TABLE `rezervacija`
  ADD PRIMARY KEY (`RezervacijaID`),
  ADD KEY `fk_rezervacija_putnikID_idx` (`PutnikID`),
  ADD KEY `fk_rezervacija_turaID_idx` (`TuraID`);

--
-- Indexes for table `tura`
--
ALTER TABLE `tura`
  ADD PRIMARY KEY (`TuraID`),
  ADD KEY `fk_tura_voziloID_idx` (`VoziloID`),
  ADD KEY `fk_tura_vozacID_idx` (`VozacID`),
  ADD KEY `fk_tura_startnalokacijaID_idx` (`StartnaLokacijaID`),
  ADD KEY `fk_tura_zavrsnalokacijaID_idx` (`ZavrsnaLokacijaID`);

--
-- Indexes for table `vozac`
--
ALTER TABLE `vozac`
  ADD PRIMARY KEY (`VozacID`);

--
-- Indexes for table `vozilo`
--
ALTER TABLE `vozilo`
  ADD PRIMARY KEY (`VoziloID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `korisnici`
--
ALTER TABLE `korisnici`
  MODIFY `korisnik_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `lokacija`
--
ALTER TABLE `lokacija`
  MODIFY `LokacijaID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `putnik`
--
ALTER TABLE `putnik`
  MODIFY `PutnikID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `rezervacija`
--
ALTER TABLE `rezervacija`
  MODIFY `RezervacijaID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `tura`
--
ALTER TABLE `tura`
  MODIFY `TuraID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `vozac`
--
ALTER TABLE `vozac`
  MODIFY `VozacID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `vozilo`
--
ALTER TABLE `vozilo`
  MODIFY `VoziloID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `rezervacija`
--
ALTER TABLE `rezervacija`
  ADD CONSTRAINT `fk_rezervacija_putnikID` FOREIGN KEY (`PutnikID`) REFERENCES `putnik` (`PutnikID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_rezervacija_turaID` FOREIGN KEY (`TuraID`) REFERENCES `tura` (`TuraID`) ON UPDATE CASCADE;

--
-- Constraints for table `tura`
--
ALTER TABLE `tura`
  ADD CONSTRAINT `fk_tura_startnalokacijaID` FOREIGN KEY (`StartnaLokacijaID`) REFERENCES `lokacija` (`LokacijaID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tura_vozacID` FOREIGN KEY (`VozacID`) REFERENCES `vozac` (`VozacID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tura_voziloID` FOREIGN KEY (`VoziloID`) REFERENCES `vozilo` (`VoziloID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tura_zavrsnalokacijaID` FOREIGN KEY (`ZavrsnaLokacijaID`) REFERENCES `lokacija` (`LokacijaID`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
