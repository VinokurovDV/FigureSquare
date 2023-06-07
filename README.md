# FigureSquare
Вычисляем площадь фигуры по значения длины ее сторон (в случае круга-по радиусу).
Чтобы упростить процесс добавления новых фигур, реализован метод CalculateSquare, который на вход принимает то количество входных параметров, которое соответствует количеству сторон многоугольника.
Для добавления новой фигуры надо добавить новый метод CalculateSquare с нужными параметрами.

Задача2:
Имеем 2 таблицы: Products и ProductCategories, связанные между собой полем Id.
Запрос на отображение всех продуктов, даже не имеющих категории выглядит так:
Select ProductName  from Products,
CategoriesName from ProductCategories
left join ProductCategories as pc where Products.id=pc.id
