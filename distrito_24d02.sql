-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 27-07-2023 a las 03:47:18
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
-- Estructura de tabla para la tabla `campaña`
--

CREATE TABLE `campaña` (
  `ID_Campaña` int(11) NOT NULL,
  `Nombre` varchar(255) DEFAULT NULL,
  `Lugar` varchar(255) DEFAULT NULL,
  `Fecha` varchar(10) DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `campaña`
--

INSERT INTO `campaña` (`ID_Campaña`, `Nombre`, `Lugar`, `Fecha`, `Estado`) VALUES
(1, 'Cruz o Rata', 'casa', '26-07-2023', 'Activo'),
(2, 'ISDSAD', 'Salinas', '23-12-2019', 'Activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `donante`
--

CREATE TABLE `donante` (
  `ID_Donante` int(11) NOT NULL,
  `Cedula` varchar(11) DEFAULT NULL,
  `Apellidos_Nombres` varchar(100) DEFAULT NULL,
  `Fecha_Nacimiento` varchar(10) DEFAULT NULL,
  `Direccion` varchar(200) DEFAULT NULL,
  `Telefono` varchar(20) DEFAULT NULL,
  `Correo_Electronico` varchar(100) DEFAULT NULL,
  `Tipo_Sangre` varchar(5) DEFAULT NULL,
  `Tiene_Tatuaje` varchar(2) DEFAULT NULL,
  `Fecha_Tatuaje` varchar(10) DEFAULT NULL,
  `Fecha_Donacion` datetime DEFAULT NULL,
  `ID_Campaña` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `donante`
--

INSERT INTO `donante` (`ID_Donante`, `Cedula`, `Apellidos_Nombres`, `Fecha_Nacimiento`, `Direccion`, `Telefono`, `Correo_Electronico`, `Tipo_Sangre`, `Tiene_Tatuaje`, `Fecha_Tatuaje`, `Fecha_Donacion`, `ID_Campaña`) VALUES
(1, '12345678910', 'Diana', '01-02-2001', 'Calle Falsa 123', '12345678', 'Correo@correo.com', 'O+', 'NO', NULL, '2023-07-26 19:20:29', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personal`
--

CREATE TABLE `personal` (
  `ID_Personal` int(11) NOT NULL,
  `Cedula` varchar(11) DEFAULT NULL,
  `Apellidos_Nombres` varchar(100) DEFAULT NULL,
  `Fecha_Nacimiento` varchar(10) DEFAULT NULL,
  `Direccion` varchar(200) DEFAULT NULL,
  `Telefono` varchar(20) DEFAULT NULL,
  `Correo_Electronico` varchar(100) DEFAULT NULL,
  `Usuario` varchar(50) DEFAULT NULL,
  `Clave` varchar(50) DEFAULT NULL,
  `ID_Campaña` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `personal`
--

INSERT INTO `personal` (`ID_Personal`, `Cedula`, `Apellidos_Nombres`, `Fecha_Nacimiento`, `Direccion`, `Telefono`, `Correo_Electronico`, `Usuario`, `Clave`, `ID_Campaña`) VALUES
(1, '2450128257', 'Melena Diana', '1999-02-25', 'Salinas', '0963610580', 'dian@sd.com', 'user', '1234', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `campaña`
--
ALTER TABLE `campaña`
  ADD PRIMARY KEY (`ID_Campaña`);

--
-- Indices de la tabla `donante`
--
ALTER TABLE `donante`
  ADD PRIMARY KEY (`ID_Donante`),
  ADD KEY `ID_Campaña` (`ID_Campaña`);

--
-- Indices de la tabla `personal`
--
ALTER TABLE `personal`
  ADD PRIMARY KEY (`ID_Personal`),
  ADD KEY `ID_Campaña` (`ID_Campaña`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `campaña`
--
ALTER TABLE `campaña`
  MODIFY `ID_Campaña` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `donante`
--
ALTER TABLE `donante`
  MODIFY `ID_Donante` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `personal`
--
ALTER TABLE `personal`
  MODIFY `ID_Personal` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `donante`
--
ALTER TABLE `donante`
  ADD CONSTRAINT `donante_ibfk_1` FOREIGN KEY (`ID_Campaña`) REFERENCES `campaña` (`ID_Campaña`);

--
-- Filtros para la tabla `personal`
--
ALTER TABLE `personal`
  ADD CONSTRAINT `personal_ibfk_1` FOREIGN KEY (`ID_Campaña`) REFERENCES `campaña` (`ID_Campaña`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
