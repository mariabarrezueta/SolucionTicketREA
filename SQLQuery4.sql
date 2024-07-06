USE WebTicketREA;

INSERT INTO Users (UserName, UserEmail, UserPhone)
VALUES 
('Juan Pérez', 'juan.perez@example.com', '1234567890'),
('María Gómez', 'maria.gomez@example.com', '0987654321'),
('Carlos Sánchez', 'carlos.sanchez@example.com', '1112223333');

INSERT INTO Ticket (HolderName, IdentityNumber, TicketQuantity, TicketCategory, TotalAmountPaid)
VALUES 
('Juan Pérez', '1234567890', 2, 'VIP', 200.00),
('María Gómez', '0987654321', 3, 'Regular', 150.00),
('Carlos Sánchez', '1112223333', 1, 'VIP', 100.00);


INSERT INTO DetailEvents (EventName, EventImage, EventDate, EventLocation, EventDescription)
VALUES 
('Concierto de Rock', 'rock.jpg', '2024-08-01', 'Teatro Nacional', 'Disfruta de una noche de rock con las mejores bandas.'),
('Festival de Jazz', 'jazz.png', '2024-09-15', 'Parque Central', 'Un festival con los mejores exponentes del jazz mundial.'),
('Conferencia de Tecnología', 'tech.jpg', '2024-10-10', 'Centro de Convenciones', 'Explora las últimas tendencias en tecnología.'),
('Exposición de Arte', 'art.jpg', '2024-11-05', 'Museo de Arte Moderno', 'Una exposición con obras de artistas contemporáneos.');

SELECT * FROM Users;
SELECT * FROM Ticket;
SELECT * FROM DetailEvents;