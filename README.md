2048

Описание классов:
-Класс Cell содержит в себе функции, которые выполняет сама ячейка
-Класс GameBoard содержит в себе двумерный массив объектов класса Cell и функции по работе с ними
-Класс MainForm содержит функции по отображению элементов GameBoard на элементы формы
-Классы Right, Left, Up, Down, реализующие интерфейс ISides содержат значения и функции для движение в соответствующую сторону. Этим я делаю метод Move класса GameBoard универсальным для движения в любую сторону, посылая как параметр класс реализующий интерфейс ISides.