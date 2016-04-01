SELECT b.Id, b.Title, b.Author, g.Name AS 'Genre'
FROM Books b
INNER JOIN Genres g ON g.Id = b.GenreId

SELECT DISTINCT Genre
FROM Books
--WHERE Genre = 'Fantasy'

INSERT INTO Books (Title, Genre, Author)
VALUES ('Jurassic Park', 'Crichton', 'SciFi')

UPDATE Books
SET Title = 'Hitchiker''s Guide to the Galaxy',
    Author = 'Adams',
    Genre = 'SciFi'
WHERE Id = 5

UPDATE Books
SET GenreId = g.Id
FROM Genres g
WHERE g.Name = Genre