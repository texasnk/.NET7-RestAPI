CREATE TABLE IF NOT EXISTS `book` (  
  `id` bigint NOT NULL AUTO_INCREMENT,
  `book_name` varchar(50) NOT NULL,
  `genre` varchar(12) NOT NULL,
  `publisher` varchar(50) NOT NULL,

  PRIMARY KEY (`id`)
)