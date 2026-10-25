using System;

namespace GameOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создаём игровые объекты:");
            Archer archer = new Archer();
            Fort fort = new Fort();
            MobileHouse telezhka = new MobileHouse();
            Console.WriteLine();
            Console.WriteLine("Информация об объектах:");
            Console.WriteLine($"Archer {archer.getId()} {archer.getX()},{archer.getY()}");
            Console.WriteLine($"Fort {fort.getId()} {fort.getX()},{fort.getY()}");
            Console.WriteLine($"MobileHouse {telezhka.getId()} {telezhka.getX()},{telezhka.getY()}");
            Console.WriteLine();
            Console.WriteLine("Проверяем состояние объектов:");
            Console.WriteLine(archer.isAlive());
            Console.WriteLine(archer.getHp());
            Console.WriteLine(fort.isBuilt());
            Console.WriteLine(telezhka.isBuilt());
            Console.WriteLine();
            Console.WriteLine("Проверяем перемещение Archer, старая позиция" + " " + archer.getX() + " " + archer.getY());
            archer.move(5, 10);
            Console.WriteLine("Новая позиция Archer: " + archer.getX() + " " + archer.getY());
            Console.WriteLine();
            Console.WriteLine("Проверяем атаку Fort:");
            Console.WriteLine(fort.getHp + " проходит атака ");
            fort.receiveDamage(1);
            Console.Write(fort.getHp);
            Console.WriteLine();
            Console.WriteLine("HP Archer до атаки: " + archer.getHp());
            fort.attack(archer);
            Console.WriteLine("HP Archer после атаки: " + archer.getHp());
            Console.WriteLine();
            Console.WriteLine("Проверяем полиморфизм:");
            Archer target = new Archer();
            Attacker a1 = archer;
            Attacker a2 = fort;
            a1.attack(target);
            a2.attack(target);
            Console.WriteLine("HP цели после двух атак: " + target.getHp());
            Console.WriteLine("Fin");
            //Console.WriteLine(fort.destroy())
        }
    }
}