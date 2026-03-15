CREATE TABLE `users` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `email` varchar(255) UNIQUE NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL
);

CREATE TABLE `clients` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `user_id` int UNIQUE NOT NULL
);

CREATE TABLE `products` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `description` text
);

CREATE TABLE `inventory` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `product_id` int UNIQUE NOT NULL,
  `units` int NOT NULL DEFAULT 0
);

CREATE TABLE `sales` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `client_id` int NOT NULL,
  `created_at` datetime NOT NULL
);

CREATE TABLE `sale_items` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `sale_id` int NOT NULL,
  `product_id` int NOT NULL,
  `units` int NOT NULL,
  `price` decimal(10,2) NOT NULL
);

ALTER TABLE `clients` ADD FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

ALTER TABLE `inventory` ADD FOREIGN KEY (`product_id`) REFERENCES `products` (`id`);

ALTER TABLE `sales` ADD FOREIGN KEY (`client_id`) REFERENCES `clients` (`id`);

ALTER TABLE `sale_items` ADD FOREIGN KEY (`sale_id`) REFERENCES `sales` (`id`);

ALTER TABLE `sale_items` ADD FOREIGN KEY (`product_id`) REFERENCES `products` (`id`);
