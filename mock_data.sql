INSERT INTO Pizzas (Name, Description, Price, Images)
VALUES ('Маргарита', 'Классическая пицца с сыром', 1500, '["https://example.com/pizzas/margarita.png"]');

INSERT INTO Drinks (Name, Description, Price)
VALUES ('Морс клюква', 'Освежающий напиток', 500);

INSERT INTO Customers (Name, Phone, Email, Address)
VALUES ('Иван Иванов', '+77010000000', 'ivan@example.com', 'Алматы, ул. Абая 10');

INSERT INTO Orders (Date, Status, Total, Combo, CustomerId, PizzaId, DrinkId, Description)
VALUES ('2026-06-13 18:30:00', 'Created', 2000, 1, 1, 1, 1, 'Заказ: Маргарита + морс клюква');

INSERT INTO Payments (Date, Amount, Method, Status, OrderId)
VALUES ('2026-06-13 18:35:00', 2000, 'Kaspi QR', 'Success', 1);
