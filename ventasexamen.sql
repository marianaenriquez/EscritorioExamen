
CREATE DATABASE IF NOT EXISTS `ventasexamen` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;
USE `ventasexamen`;


CREATE TABLE IF NOT EXISTS `productos` (
  `IDProductos` int(11) NOT NULL,
  `Titulo` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `Descripcion` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `PrecioUnitario` decimal(7,2) NOT NULL,
  `Existencias` int(11) NOT NULL,
  PRIMARY KEY (`IDProductos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;


INSERT INTO `productos` (`IDProductos`, `Titulo`, `Descripcion`, `PrecioUnitario`, `Existencias`) VALUES
	(1, 'Maestro Limpio 1L', 'Limpiador multiusos.', 18.00, 1000),
	(2, 'Cloralex 1L', 'Cloro para limpieza general.', 14.50, 500),
	(3, 'Cloralex Pastillas 10 Unidades', 'Cloro en pastillas para desinfección de inodoro.', 120.80, 90),
	(4, 'Pinol 1L.', 'Limpiador Multiusos.', 21.50, 425),
	(5, 'Siempre Limpio 300 Bolsas.', 'Bolsas para basura biodegradables.', 150.80, 125),
	(6, 'El Reluciente. 2 Kilos.', 'Jabon para lavado de trastes.', 16.70, 225),
	(7, 'El suavecito. Paquete 4 rollos.', 'Papel Higienico.', 60.00, 673),
	(8, 'Cesto Papelero. Capacidad de 1L cubico', 'Cesto papelero.', 70.00, 23),
	(9, 'Toallitas Resplandor. Paquete 70 toallitas.', 'Toallitas desinfectantes.', 113.00, 825);

CREATE TABLE IF NOT EXISTS `ventas` (
  `IDVentas` int(11) NOT NULL AUTO_INCREMENT,
  `IDProductos` int(11) DEFAULT NULL,
  `CantidadVendida` int(11) DEFAULT NULL,
  `Fecha` datetime NOT NULL,
  PRIMARY KEY (`IDVentas`),
  KEY `FKIDProductos` (`IDProductos`),
  CONSTRAINT `FKIDProductos` FOREIGN KEY (`IDProductos`) REFERENCES `productos` (`IDProductos`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;


INSERT INTO `ventas` (`IDVentas`, `IDProductos`, `CantidadVendida`, `Fecha`) VALUES
	(1, 2, 5, '2017-08-01 11:25:57'),
	(2, 3, 500, '2017-08-01 11:25:57'),
	(3, 4, 78, '2017-08-01 11:25:57'),
	(4, 2, 250, '2017-08-01 11:25:57'),
	(5, 8, 700, '2017-08-01 11:25:57'),
	(6, 5, 96, '2017-08-01 11:25:57'),
	(7, 1, 500, '2017-08-01 11:25:57'),
	(8, 4, 763, '2017-08-01 11:25:57'),
	(9, 4, 298, '2017-08-01 11:25:57'),
	(10, 9, 550, '2017-08-01 11:25:57');

