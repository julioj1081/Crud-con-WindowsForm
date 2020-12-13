-- --------------------------------------------------------
-- Host:                         localhost\MSSQLSERVER01
-- Versión del servidor:         Microsoft SQL Server 2019 (RTM-GDR) (KB4517790) - 15.0.2070.41
-- SO del servidor:              Windows 10 Pro 10.0 <X64> (Build 19042: )
-- HeidiSQL Versión:             11.1.0.6116
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES  */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Volcando datos para la tabla DBProductos.Productos: -1 rows
/*!40000 ALTER TABLE "Productos" DISABLE KEYS */;
REPLACE INTO "Productos" ("id", "Nombre", "Descripcion", "Marca", "Precio", "Stock") VALUES
	(1, 'Coca', 'bebida', 'Cocacola', 13, 50),
	(2, 'Sabritas', 'Fritura', 'Sabritas', 11, 42),
	(3, 'OREO', 'Galletas', '6.51', 6.51, 45),
	(6, 'Abujero', 'des', 'des', 75.4, 45),
	(7, 'pocicion', 'trancqui', 'marca', 4.578, 1);
/*!40000 ALTER TABLE "Productos" ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
