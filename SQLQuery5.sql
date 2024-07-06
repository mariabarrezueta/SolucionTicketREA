USE WebTicketREA;

CREATE TABLE Comments (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UserName NVARCHAR(MAX) NOT NULL,
    CommentText NVARCHAR(MAX) NOT NULL
);

INSERT INTO Comments (UserName, CommentText)
VALUES 
('Juan Pérez', '¡Excelente evento!'),
('María Gómez', 'Me encantó la organización.'),
('Carlos Sánchez', 'La música estuvo increíble.'),
('Laura Martínez', 'Fue una experiencia maravillosa.'),
('Pedro Rodríguez', 'Los organizadores hicieron un gran trabajo.');

SELECT * FROM Comments;
