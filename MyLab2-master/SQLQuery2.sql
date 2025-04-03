USE [PerfumeShopDB]  -- Заменили PerfumeDB на PerfumeStoreDB
-- Создание таблицы "Бренды"
CREATE TABLE Brands (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);

-- Создание таблицы "Парфюмы"
CREATE TABLE Perfumes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    BrandId INT NOT NULL,
    Season NVARCHAR(50),
    Description NVARCHAR(MAX),
    FOREIGN KEY (BrandId) REFERENCES Brands(Id) ON DELETE CASCADE
);

-- Создание таблицы "Ноты"
CREATE TABLE Notes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Type NVARCHAR(50) NOT NULL -- Верхние, Средние, Базовые
);

-- Создание таблицы связи парфюмов и нот
CREATE TABLE PerfumeNotes (
    PerfumeId INT NOT NULL,
    NoteId INT NOT NULL,
    NoteType NVARCHAR(50) NOT NULL, -- Дублирование типа для быстрого доступа
    PRIMARY KEY (PerfumeId, NoteId),
    FOREIGN KEY (PerfumeId) REFERENCES Perfumes(Id) ON DELETE CASCADE,
    FOREIGN KEY (NoteId) REFERENCES Notes(Id) ON DELETE CASCADE
);

-- Создание таблицы "Сезоны"
CREATE TABLE Seasons (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL
);

-- Добавление тестовых данных
INSERT INTO Brands (Name) VALUES 
('Chanel'),
('Dior'),
('Guerlain'),
('Creed');

INSERT INTO Seasons (Name) VALUES 
('Весна'),
('Лето'),
('Осень'),
('Зима'),
('Универсальный');

INSERT INTO Perfumes (Name, BrandId, Season, Description) VALUES 
('Chanel No 5', 1, 'Универсальный', 'Классический женский аромат'),
('Sauvage', 2, 'Лето', 'Свежий мужской аромат'),
('Shalimar', 3, 'Зима', 'Ориентальный женский парфюм'),
('Aventus', 4, 'Универсальный', 'Премиальный мужской парфюм');

INSERT INTO Notes (Name, Type) VALUES 
('Бергамот', 'Верхние'),
('Жасмин', 'Средние'),
('Ваниль', 'Базовые'),
('Амбра', 'Базовые'),
('Роза', 'Средние'),
('Цитрон', 'Верхние');

INSERT INTO PerfumeNotes (PerfumeId, NoteId, NoteType) VALUES 
(1, 1, 'Верхние'),
(1, 2, 'Средние'),
(1, 3, 'Базовые'),
(2, 1, 'Верхние'),
(2, 5, 'Средние'),
(3, 2, 'Средние'),
(3, 4, 'Базовые'),
(4, 6, 'Верхние'),
(4, 5, 'Средные'),
(4, 4, 'Базовые');

-- Примеры запросов
SELECT * FROM Brands;
SELECT * FROM Perfumes WHERE BrandId = 1;
SELECT n.Name, n.Type FROM Notes n
JOIN PerfumeNotes pn ON n.Id = pn.NoteId
WHERE pn.PerfumeId = 1;

-- Удаление парфюма
DELETE FROM Perfumes WHERE Id = 1;

-- Обновление информации о бренде
UPDATE Brands SET Name = 'Chanel Paris' WHERE Id = 1;