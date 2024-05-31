-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3308
-- Généré le : mer. 29 mai 2024 à 15:13
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(8, '2025-05-10 09:25:29', '2023-05-20 04:08:48', 4),
(5, '2023-07-21 09:55:33', '2024-02-20 23:58:57', 4),
(4, '2024-07-20 06:45:40', '2024-11-10 13:10:44', 3),
(4, '2024-08-08 14:26:19', '2023-09-19 02:16:53', 2),
(4, '2025-03-05 18:12:03', '2024-06-27 00:08:27', 2),
(2, '2025-01-15 10:18:05', '2023-10-21 06:30:17', 3),
(10, '2024-09-26 02:21:15', '2024-04-12 13:25:57', 3),
(1, '2023-06-19 07:59:42', '2025-01-16 22:50:19', 3),
(10, '2024-06-01 20:10:48', '2024-07-16 05:54:44', 2),
(9, '2024-08-01 20:07:55', '2024-12-22 05:08:39', 4),
(6, '2025-05-05 16:34:35', '2023-08-07 06:27:12', 2),
(9, '2024-12-23 08:44:11', '2024-06-28 07:18:47', 1),
(3, '2023-10-29 07:58:29', '2024-08-08 23:52:11', 3),
(10, '2023-08-18 00:11:13', '2024-01-21 01:10:43', 2),
(5, '2025-04-20 14:33:40', '2024-01-09 00:33:38', 1),
(4, '2025-04-17 13:59:17', '2024-07-03 11:19:30', 2),
(7, '2024-03-13 11:36:15', '2024-05-09 02:41:09', 2),
(3, '2023-11-25 04:34:40', '2025-04-01 17:45:08', 3),
(6, '2024-11-29 13:34:25', '2023-07-31 07:47:12', 3);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Hil', 'Hogan', '02 23 22 65 88', 'velit.egestas@google.couk', 1),
(2, 'Elijah', 'Tyson', '04 48 28 58 27', 'ac.ipsum.phasellus@hotmail.com', 3),
(3, 'Seth', 'Huber', '08 80 23 78 14', 'nam.nulla.magna@google.com', 1),
(4, 'Gary', 'Reeves', '08 76 63 61 82', 'eros.non.enim@yahoo.ca', 3),
(5, 'Althea', 'Olsen', '03 93 46 71 53', 'ullamcorper.duis.cursus@yahoo.net', 2),
(6, 'Vincent', 'Graves', '05 71 51 78 54', 'mauris.sapien@hotmail.org', 2),
(7, 'Sage', 'Weaver', '01 82 41 76 50', 'semper@aol.org', 2),
(8, 'Diana', 'Hewitt', '07 05 81 67 22', 'nostra.per.inceptos@google.net', 3),
(9, 'Adria', 'Mcconnell', '07 45 86 79 76', 'cursus.vestibulum@aol.edu', 1),
(10, 'Kuame', 'Savage', '08 69 34 52 28', 'integer.vitae@icloud.couk', 3);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('smith', 'd249717bb6e3782ad9521a3e6fbf938373431e5ff1ed5b3668b6e056743fb60d');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

CREATE USER 'gerant'@'%' IDENTIFIED BY 'gerantDeLaBDD';

GRANT USAGE ON *.* TO 'gerant'@'%';

GRANT ALL PRIVILEGES ON `mediatek86`.* TO 'gerant'@'%';

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
