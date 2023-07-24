-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 24-07-2023 a las 18:17:50
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `distrito_24d02`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `donante`
--

CREATE TABLE `donante` (
  `Cedula` varchar(11) NOT NULL,
  `Apellidos_Nombres` varchar(100) DEFAULT NULL,
  `Fecha_Nacimiento` date DEFAULT NULL,
  `Direccion` varchar(200) DEFAULT NULL,
  `Telefono` varchar(20) DEFAULT NULL,
  `Correo_Electronico` varchar(100) DEFAULT NULL,
  `Tipo_Sangre` varchar(5) DEFAULT NULL,
  `Tiene_Tatuaje` bit(1) DEFAULT NULL,
  `Fecha_Tatuaje` date DEFAULT NULL
) ;

--
-- Volcado de datos para la tabla `donante`
--

INSERT INTO `donante` (`Cedula`, `Apellidos_Nombres`, `Fecha_Nacimiento`, `Direccion`, `Telefono`, `Correo_Electronico`, `Tipo_Sangre`, `Tiene_Tatuaje`, `Fecha_Tatuaje`) VALUES
('0974284092', 'Gonzales Arnold', '2013-07-09', 'Salinas', '0987346623', 'arnold_32@gmail.com', 'O+', b'1', '2015-04-14');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personal`
--

CREATE TABLE `personal` (
  `Cedula` varchar(11) NOT NULL,
  `Apellidos_Nombres` varchar(100) DEFAULT NULL,
  `Fecha_Nacimiento` date DEFAULT NULL,
  `Direccion` varchar(200) DEFAULT NULL,
  `Telefono` varchar(20) DEFAULT NULL,
  `Correo_Electronico` varchar(100) DEFAULT NULL,
  `Usuario` varchar(50) DEFAULT NULL,
  `Clave` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `personal`
--

INSERT INTO `personal` (`Cedula`, `Apellidos_Nombres`, `Fecha_Nacimiento`, `Direccion`, `Telefono`, `Correo_Electronico`, `Usuario`, `Clave`) VALUES
('2450128257', 'Melena Diana', '2023-07-12', 'Santa Elena', '0963610580', 'diana.melena25@gmail.com', 'user', '1234');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `donante`
--
ALTER TABLE `donante`
  ADD PRIMARY KEY (`Cedula`);

--
-- Indices de la tabla `personal`
--
ALTER TABLE `personal`
  ADD PRIMARY KEY (`Cedula`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
