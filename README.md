[![Open in Visual Studio Code](https://classroom.github.com/assets/open-in-vscode-718a45dd9cf7e7f842a935f5ebbe5719a5e09af4491e668f4dbf3b35d5cca122.svg)](https://classroom.github.com/online_ide?assignment_repo_id=12002161&assignment_repo_type=AssignmentRepo)
# 01-03-01-WarriorProject

![image](https://github.com/2023-2024-CSARP-OOP-WPF/01-03-02-warriorproject-b0totdav/assets/74899241/486f0540-95bd-4ed2-b6fc-c7e099c5f70e)

![image](https://github.com/2023-2024-CSARP-OOP-WPF/01-03-02-warriorproject-b0totdav/assets/74899241/9c1ea390-6962-4c5d-97cf-c19071f52b11)


A fejlesztő csapat munkája után elkészült két osztály UML diagramja. Ön azt a feladatot kapta, hogy fejlessze ki az osztályokat!


A Position osztályba az adattagok private elérhetőségük legyenek! Ekkor a feladat megoldása, csak akkor lehetséges, ha a Position osztályt még két metódussal továbbfejleszti! A feladata, hogy jöjjön rá, hogyan kell ezt megoldani!


Minden kiírást a ToConsole metódusokban valósítson meg!


![alt text](https://github.com/csarp-dotnet-core-oop-task/01-03-02-WarriorProject/blob/main/Warrior.png)    

Munkája ellenőrzéseként használja a következő kódot:   
```
Position position = new Position(2,-1);
position.ToConsole();
Warrior warrior = new Warrior("Peter the Iron Man", position);
warrior.ToConsole();
warrior.MoveHorizontal(3);
warrior.MoveVertical(-2);
warrior.ToConsole();
```

A kód kimenete a következő kell legyen:    
(2,-1)    
Peter the Iron Man, position (2,-1)    
Peter the Iron Man, position (5,-3)    
