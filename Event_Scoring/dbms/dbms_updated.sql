CREATE DATABASE  IF NOT EXISTS `event_scoring` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `event_scoring`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win64 (x86_64)
--
-- Host: localhost    Database: event_scoring
-- ------------------------------------------------------
-- Server version	5.6.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_contestant`
--

DROP TABLE IF EXISTS `tbl_contestant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_contestant` (
  `contestant_id` bigint(255) NOT NULL AUTO_INCREMENT,
  `contestant_number` varchar(45) DEFAULT NULL,
  `contestant_fullname` varchar(255) DEFAULT NULL,
  `contestant_address` varchar(255) DEFAULT NULL,
  `contestant_talent` varchar(255) NOT NULL,
  `contestant_photopath` varchar(2555) DEFAULT NULL,
  `contestant_statusview` varchar(255) NOT NULL,
  PRIMARY KEY (`contestant_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_contestant`
--

LOCK TABLES `tbl_contestant` WRITE;
/*!40000 ALTER TABLE `tbl_contestant` DISABLE KEYS */;
INSERT INTO `tbl_contestant` VALUES (8,'1','123','23','3','C:\\\\Users\\\\Claveria\\\\Saved Games\\\\Pictures\\\\FB_IMG_1482474865324.jpg','C:\\Users\\Claveria\\Documents\\Visual Studio 2012\\Projects\\Event_Scoring\\Event_Scoring\\bin\\Debug\\exis.png'),(9,'2','333333','3','123','C:\\\\Users\\\\Claveria\\\\Saved Games\\\\Pictures\\\\FB_IMG_1482474865324.jpg','C:\\Users\\Claveria\\Documents\\Visual Studio 2012\\Projects\\Event_Scoring\\Event_Scoring\\bin\\Debug\\exis.png'),(10,'3','33333323','3','123','C:\\\\Users\\\\Claveria\\\\Saved Games\\\\Pictures\\\\FB_IMG_1482474865324.jpg','C:\\Users\\Claveria\\Documents\\Visual Studio 2012\\Projects\\Event_Scoring\\Event_Scoring\\bin\\Debug\\exis.png');
/*!40000 ALTER TABLE `tbl_contestant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_criteria`
--

DROP TABLE IF EXISTS `tbl_criteria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_criteria` (
  `criteria_id` bigint(255) NOT NULL AUTO_INCREMENT,
  `criteria_name` varchar(255) DEFAULT NULL,
  `criteria_percentage` double DEFAULT NULL,
  PRIMARY KEY (`criteria_id`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_criteria`
--

LOCK TABLES `tbl_criteria` WRITE;
/*!40000 ALTER TABLE `tbl_criteria` DISABLE KEYS */;
INSERT INTO `tbl_criteria` VALUES (18,'Originality',40),(19,'Custome',10),(30,'hello',20),(31,'213123213123123',1),(33,'hello',20),(34,'213123213123123',1),(35,'sASqas',8);
/*!40000 ALTER TABLE `tbl_criteria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_judge`
--

DROP TABLE IF EXISTS `tbl_judge`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_judge` (
  `judge_id` bigint(255) NOT NULL AUTO_INCREMENT,
  `judge_fullname` varchar(255) DEFAULT NULL,
  `last_update` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`judge_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_judge`
--

LOCK TABLES `tbl_judge` WRITE;
/*!40000 ALTER TABLE `tbl_judge` DISABLE KEYS */;
INSERT INTO `tbl_judge` VALUES (1,'nikko','2017-01-18 15:36:54'),(2,'zamora','2017-01-18 15:36:54'),(3,'claveria','2017-01-18 15:36:54'),(4,'claveira1','2017-01-18 15:36:54'),(5,'d','2017-01-18 15:36:54'),(6,'dheopogi','2017-01-18 15:36:54');
/*!40000 ALTER TABLE `tbl_judge` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_logs`
--

DROP TABLE IF EXISTS `tbl_logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_logs` (
  `logs_id` bigint(255) NOT NULL AUTO_INCREMENT,
  `users_id` bigint(255) NOT NULL,
  `logs_actionname` varchar(255) DEFAULT NULL,
  `logs_remarks` varchar(255) DEFAULT NULL,
  `logs_dateupdated` timestamp(6) NULL DEFAULT NULL,
  PRIMARY KEY (`logs_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_logs`
--

LOCK TABLES `tbl_logs` WRITE;
/*!40000 ALTER TABLE `tbl_logs` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_scoring`
--

DROP TABLE IF EXISTS `tbl_scoring`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_scoring` (
  `scoring_id` bigint(255) NOT NULL AUTO_INCREMENT,
  `judge_id` bigint(255) DEFAULT NULL,
  `contestant_id` bigint(255) DEFAULT NULL,
  `criteria_id` bigint(255) DEFAULT NULL,
  `scoring_score` double DEFAULT NULL,
  `scoring_criteriaavg` double DEFAULT NULL,
  PRIMARY KEY (`scoring_id`)
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_scoring`
--

LOCK TABLES `tbl_scoring` WRITE;
/*!40000 ALTER TABLE `tbl_scoring` DISABLE KEYS */;
INSERT INTO `tbl_scoring` VALUES (1,1,4,18,90,36),(2,1,4,21,90,27),(3,1,4,19,90,9),(4,1,4,23,90,4.5),(5,1,4,24,90,4.5),(6,1,4,25,90,4.5),(7,1,4,27,90,2.7),(8,1,4,28,90,1.8),(9,1,2,18,89,35.6),(10,1,2,21,89,26.7),(11,1,2,19,89,8.9),(12,1,2,23,89,4.45),(13,1,2,24,89,4.45),(14,1,2,25,89,4.45),(15,1,2,27,89,2.67),(16,1,2,28,89,1.78),(17,1,3,18,79,31.6),(18,1,3,21,79,23.7),(19,1,3,19,79,7.9),(20,1,3,23,79,3.95),(21,1,3,24,79,3.95),(22,1,3,25,79,3.95),(23,1,3,27,79,2.37),(24,1,3,28,7,0.21),(25,2,1,18,99,39.6),(26,2,1,21,99,29.7),(27,2,1,19,9,2.7),(28,2,1,23,99,9.9),(29,2,1,24,99,4.95),(30,2,1,25,99,4.95),(31,2,1,27,99,4.95),(32,2,1,28,99,2.97),(33,2,5,18,90,36),(34,2,5,21,89,26.7),(35,2,5,19,79,7.9),(36,2,5,23,90,4.5),(37,2,5,24,97,4.85),(38,2,5,25,90,4.5),(39,2,5,27,79,2.37),(40,2,5,28,98,1.96),(41,0,1,18,30,12),(42,0,1,21,2,0.6),(43,0,1,30,0,0),(44,0,1,19,12,2.4),(45,0,1,18,30,12),(46,0,1,21,23,6.9),(47,0,1,30,22,4.4),(48,0,1,19,2,0.4),(49,0,1,18,33,13.2),(50,0,1,32,3,1.2),(51,0,1,30,33,13.2),(52,0,1,19,0,0),(53,0,1,31,3,0.03),(54,0,1,18,0,0),(55,0,1,32,30,8.7),(56,0,1,30,0,0),(57,0,1,19,330,8.7),(58,0,1,31,30,0);
/*!40000 ALTER TABLE `tbl_scoring` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_users`
--

DROP TABLE IF EXISTS `tbl_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_users` (
  `users_id` bigint(255) NOT NULL AUTO_INCREMENT,
  `users_username` varchar(255) DEFAULT NULL,
  `users_password` varchar(50) DEFAULT NULL,
  `judge_id` bigint(255) DEFAULT NULL,
  `users_type` varchar(45) NOT NULL,
  PRIMARY KEY (`users_id`,`users_type`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_users`
--

LOCK TABLES `tbl_users` WRITE;
/*!40000 ALTER TABLE `tbl_users` DISABLE KEYS */;
INSERT INTO `tbl_users` VALUES (0,'dheo','claveria',0,'Admin'),(1,'nikko','nikko',1,'Judge'),(2,'d','d',2,'Judge'),(3,'dheopogi','dheopogi',3,'Judge');
/*!40000 ALTER TABLE `tbl_users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'event_scoring'
--
/*!50003 DROP PROCEDURE IF EXISTS `CreateContestant` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateContestant`(	
																contestant_number VARCHAR (255),
                                                                contestant_fullname VARCHAR (255),
																contestant_address VARCHAR(255),
																contestant_talent VARCHAR(255),
																contestant_photopath VARCHAR(2555),
                                                                contestant_statusview VARCHAR(255)
															  )
BEGIN
INSERT INTO tbl_contestant(contestant_number, contestant_fullname, contestant_address, contestant_talent,contestant_photopath, contestant_statusview  )
VALUES(contestant_number, contestant_fullname, contestant_address, contestant_talent,contestant_photopath, contestant_statusview);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CreateJudge` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateJudge`(
                                                                judgefullname VARCHAR (255),
                                                                judgeid VARCHAR (255),
                                                                usertype VARCHAR (255)
													 	)
BEGIN

INSERT INTO `event_scoring`.`tbl_judge`(`judge_fullname`)
VALUES(judgefullname);

/*SELECT judge_id FROM `event_scoring`.`tbl_judge` ORDER BY last_update DESC LIMIT 1;

INSERT INTO `event_scoring`.`tbl_users` (`users_username`, `users_password` ,`judgeid`, `users_type`)
 VALUES (judgefullname,judgefullname,judgeid, usertype );
*/
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SaveCriteria` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SaveCriteria`(criteria_name VARCHAR(255), criteria_percentage DOUBLE)
BEGIN

INSERT INTO tbl_criteria(criteria_name, criteria_percentage)
VALUES(criteria_name, criteria_percentage);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-07  3:32:49
