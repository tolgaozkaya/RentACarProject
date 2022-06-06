-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.29 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.0.0.6468
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for rentacar
CREATE DATABASE IF NOT EXISTS `rentacar` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `rentacar`;

-- Dumping structure for table rentacar.araba
CREATE TABLE IF NOT EXISTS `araba` (
  `id` int NOT NULL AUTO_INCREMENT,
  `plaka` varchar(50) DEFAULT NULL,
  `marka` varchar(50) DEFAULT NULL,
  `seri` varchar(50) DEFAULT NULL,
  `yil` varchar(50) DEFAULT NULL,
  `renk` varchar(50) DEFAULT NULL,
  `km` varchar(50) DEFAULT NULL,
  `yakit` varchar(50) DEFAULT NULL,
  `kiraucreti` int DEFAULT NULL,
  `resim` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `durumu` varchar(50) DEFAULT NULL,
  `tarih` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table rentacar.araba: ~7 rows (approximately)
INSERT INTO `araba` (`id`, `plaka`, `marka`, `seri`, `yil`, `renk`, `km`, `yakit`, `kiraucreti`, `resim`, `durumu`, `tarih`) VALUES
	(1, '06 HA 4567', 'Opel', 'Corsa', '2015', 'Kırmızı', '95.000', 'Benzin', 150, '\\\\Mac\\Home\\Downloads\\2020-opel-corsa-111.jpg', 'BOŞTA', '6/3/2022 7:14:57 AM'),
	(2, '06 TT 5438', 'Mercedes', 'E Serisi', '2019', 'Siyah', '100.000', 'Benzin', 250, '\\\\Mac\\Home\\Downloads\\2021-mercedes-e-serisi-111.jpg', 'BOŞTA', '6/3/2022 7:16:14 AM'),
	(3, '06 TL 6790', 'Honda', 'Jazz', '2015', 'Gri', '45.000', 'Benzin', 180, '\\\\Mac\\Home\\Downloads\\honda-jazz-2021-111.jpg', 'BOŞTA', '6/3/2022 7:18:01 AM'),
	(4, '06 TR 6783', 'BMW', 'M4', '2020', 'Mavi', '10.000', 'Benzin', 350, '\\\\Mac\\Home\\Downloads\\2012-bmw-m-serisi-sedan-111.jpg', 'BOŞTA', '6/3/2022 7:20:15 AM'),
	(5, '06 AR 3838', 'Mercedes', 'G Serisi', '2019', 'Beyaz', '20.000', 'Benzin', 400, '\\\\Mac\\Home\\Downloads\\2020-mercedes-glc-111.jpg', 'DOLU', '6/3/2022 7:25:52 AM'),
	(6, '06 AS 8697', 'Volkswagen', 'Golf', '2018', 'Sarı', '300.000', 'Benzin', 300, '\\\\Mac\\Home\\Downloads\\2021-vw-golf-111.jpg', 'BOŞTA', '6/3/2022 7:27:49 AM'),
	(7, '06 CZN 8595', 'BMW', 'M5', '2020', 'Siyah', '20.000', 'Benzin', 450, '\\\\Mac\\Home\\Downloads\\maxresdefault.jpg', 'BOŞTA', '6/3/2022 7:29:20 AM');

-- Dumping structure for table rentacar.musteri
CREATE TABLE IF NOT EXISTS `musteri` (
  `id` int NOT NULL AUTO_INCREMENT,
  `tc` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `adsoyad` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `telefon` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `adres` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `email` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Dumping data for table rentacar.musteri: ~5 rows (approximately)
INSERT INTO `musteri` (`id`, `tc`, `adsoyad`, `telefon`, `adres`, `email`) VALUES
	(1, '48544492134', 'Tolga Özkaya', '05070898785', 'Ankara, Bahçelievler.', 'tolga@gmail.com'),
	(2, '56709438768', 'Mustafa Çakır', '05074678908', 'Hatay, İskenderun', 'mustafa@gmail.com'),
	(3, '47594809489', 'Kubilay Malçok', '05347566878', 'Ankara, Gazi Mahellesi ', 'kubi@gmail.com'),
	(4, '45683992776', 'Esref Ali Atasoy', '05469908785', 'Kırşehir, Merkez', 'esref@gmail.com'),
	(5, '28947924789', 'Furkan Uzun', '05678484899', 'Hatay, Dörtyol', 'furkan@gmail.com');

-- Dumping structure for table rentacar.satis
CREATE TABLE IF NOT EXISTS `satis` (
  `tc` varchar(50) DEFAULT NULL,
  `adsoyad` varchar(50) DEFAULT NULL,
  `plaka` varchar(50) DEFAULT NULL,
  `marka` varchar(50) DEFAULT NULL,
  `seri` varchar(50) DEFAULT NULL,
  `yil` varchar(50) DEFAULT NULL,
  `renk` varchar(50) DEFAULT NULL,
  `gun` int DEFAULT NULL,
  `fiyat` int DEFAULT NULL,
  `tutar` int DEFAULT NULL,
  `tarih1` varchar(50) DEFAULT NULL,
  `tarih2` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table rentacar.satis: ~3 rows (approximately)
INSERT INTO `satis` (`tc`, `adsoyad`, `plaka`, `marka`, `seri`, `yil`, `renk`, `gun`, `fiyat`, `tutar`, `tarih1`, `tarih2`) VALUES
	('48544492134', 'Tolga Özkaya', '06 HA 4566', 'Mercedes', 'C Serisi', '2018', 'Siyah', 1, 225, 225, '6/2/2022', '6/3/2022 2:47:38 AM'),
	('48544492134', 'Tolga Özkaya', '06 HA 4526', 'Honda', 'Civic', '2017', 'Siyah', 1, 280, 280, '6/2/2022', '6/3/2022 3:23:58 AM'),
	('48544492134', 'Tolga Özkaya', '06 HA 4545', 'BMW', 'M4', '2017', 'Siyah', 1, 280, 280, '6/2/2022', '6/3/2022 3:40:11 AM');

-- Dumping structure for table rentacar.sozlesme
CREATE TABLE IF NOT EXISTS `sozlesme` (
  `tc` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `adsoyad` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `telefon` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `ehliyetno` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `e_tarih` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `e_yer` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `plaka` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `marka` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `seri` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `yil` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `renk` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `kirasekli` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `kiraucreti` int DEFAULT NULL,
  `gun` int DEFAULT NULL,
  `tutar` int DEFAULT NULL,
  `ctarih` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `dtarih` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table rentacar.sozlesme: ~1 rows (approximately)
INSERT INTO `sozlesme` (`tc`, `adsoyad`, `telefon`, `ehliyetno`, `e_tarih`, `e_yer`, `plaka`, `marka`, `seri`, `yil`, `renk`, `kirasekli`, `kiraucreti`, `gun`, `tutar`, `ctarih`, `dtarih`) VALUES
	('48544492134', 'Tolga Özkaya', '05070898785', '232323', '26.04.2018', 'Ankara', '06 AR 3838', 'Mercedes', 'G Serisi', '2019', 'Beyaz', 'Haftalık(%20 indirim)', 320, 21, 6720, '6/3/2022', '6/24/2022');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
