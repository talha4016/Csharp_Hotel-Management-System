use hotel_database;
CREATE TABLE rooms (
    id INT AUTO_INCREMENT PRIMARY KEY,
    room_id VARCHAR(255),
    type VARCHAR(255),
    room_name VARCHAR(255),
    price FLOAT,
    image_path VARCHAR(255),
    status VARCHAR(255),
    date_register DATE,
    date_update DATE,
    date_delete DATE
);
SELECT * FROM rooms;
SELECT * FROM users;
CREATE TABLE customer (
    id INT AUTO_INCREMENT PRIMARY KEY,
    book_id VARCHAR(255) NULL,
    full_name VARCHAR(255) NULL,
    email VARCHAR(255) NULL,
    contact VARCHAR(255) NULL,
    gender VARCHAR(50) NULL,
    address VARCHAR(500) NULL,
    price DECIMAL(10,2) NULL,
    status_payment VARCHAR(100) NULL,
    status VARCHAR(100) NULL,
    date_from DATE NULL,
    date_to DATE NULL,
    date_book DATE NULL
);


SELECT * FROM customer;
