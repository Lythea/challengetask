
CREATE DATABASE IF NOT EXISTS my_database;

USE my_database;
CREATE TABLE employees (
    id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    email VARCHAR(100),
    hire_date DATE
);

INSERT INTO
    employees (
        first_name,
        last_name,
        email,
        hire_date
    )
VALUES (
        'John',
        'Doe',
        'john.doe@example.com',
        '2023-01-15'
    );

    SELECT * FROM employees WHERE hire_date > '2020-01-01';

    UPDATE employees SET email = 'new.email@example.com' WHERE id = 1;

    DELETE FROM employees WHERE last_name = 'Smith';