-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 09 Jun 2022 pada 16.28
-- Versi server: 10.4.17-MariaDB
-- Versi PHP: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `projectpv`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `mobil`
--

CREATE TABLE `mobil` (
  `KodeMobil` int(30) NOT NULL,
  `MerekMobil` varchar(30) NOT NULL,
  `NamaMobil` varchar(50) NOT NULL,
  `Tahun` int(20) NOT NULL,
  `Harga` int(30) NOT NULL,
  `NoPolisi` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `mobil`
--

INSERT INTO `mobil` (`KodeMobil`, `MerekMobil`, `NamaMobil`, `Tahun`, `Harga`, `NoPolisi`) VALUES
(1002122, 'BMW', 'BMW Seri 3', 2014, 222000000, 'B 1109 PV'),
(1109191, 'SUV', 'Honda HRV', 2018, 412000000, 'BK 123 PV'),
(1109192, 'SUV', 'Honda CRV', 2020, 678000000, 'B 1189 AP'),
(1109193, 'SUV', 'Toyota Fortuner', 2022, 1119000000, 'B 1 BI'),
(1121099, 'MPV', 'Toyota Avanza', 2017, 220000000, 'B 1999 JK'),
(1210911, 'Sedan', 'Honda Civic', 2021, 899000000, 'BA 1211 OP');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `mobil`
--
ALTER TABLE `mobil`
  ADD PRIMARY KEY (`KodeMobil`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
