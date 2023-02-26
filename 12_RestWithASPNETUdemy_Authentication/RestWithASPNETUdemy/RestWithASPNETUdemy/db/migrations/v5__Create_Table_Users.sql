CREATE TABLE IF NOT EXISTS `users` (  
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `user_name` VARCHAR(50) NOT NULL DEFAULT '0',
  `password` VARCHAR(50) NOT NULL DEFAULT '0',
  `full_name` varchar(120) NOT NULL,
  `refresh_token` varchar(500) NULL DEFAULT '0',
  `refresh_token_expiry_time` DATETIME NULL DEFAULT NULL,

  PRIMARY KEY (`id`),
  UNIQUE `user_name` (`user_name`)
)
ENGINE=InnoDB DEFAULT CHARSET=latin1;