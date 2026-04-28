CREATE DATABASE EAT_EASY;
USE EAT_EASY;

CREATE TABLE receta (
    id_receta INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    pasos TEXT NOT NULL,
    tiempo INT NOT NULL
);

CREATE TABLE ingrediente (
    id_ingrediente INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    precio DECIMAL(10,2) NOT NULL
);

CREATE TABLE receta_ingrediente (
    id_receta INT,
    id_ingrediente INT,
    cantidad DECIMAL(10,2) NOT NULL,
    PRIMARY KEY (id_receta, id_ingrediente),
    FOREIGN KEY (id_receta) REFERENCES receta(id_receta),
    FOREIGN KEY (id_ingrediente) REFERENCES ingrediente(id_ingrediente)
);

CREATE TABLE menu_semanal (
    id_menu INT AUTO_INCREMENT PRIMARY KEY,
    fecha_creacion DATE
);

CREATE TABLE menu_receta (
    id_menu INT,
    id_receta INT,
    dia_semana VARCHAR(20),
    PRIMARY KEY (id_menu, dia_semana),
    FOREIGN KEY (id_menu) REFERENCES menu_semanal(id_menu),
    FOREIGN KEY (id_receta) REFERENCES receta(id_receta)
);