# Lab6
1) Разработать базовый класс GameObject 

- для неподвижных объектов

(можно другое название)

поля (м/б и проперти) координаты, текстура  

методы Отрисовка Draw(), Физика Update()



2) Класс - для подвижных объектов (есть скорость)

применяем базовые принципы ООП



3) Класс - управляемый с клавиатуры объект

KeyboardState ks = Keyboard.GetState();

if (ks.IsKeyDown(Keys.Left))

{ }

Варианты архитектуры: 

В самом классе игровой объект - клавиатуру; 

Отдельный класс на всю игру для клавы;

Класс-контроллер, который подключается к игровым объектам.

Свой вариант.



4) Продемонстрировать в проекте работу всех объектов.

4.1 Несколько неподвижных (с разными текстурами)

4.2. Несколько подвижных (с разными текстурами) и по разному движением

4.3. Один или два управляемый с клавиатуры.

