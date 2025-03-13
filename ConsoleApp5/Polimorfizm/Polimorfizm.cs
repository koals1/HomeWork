//using System;
////Task 1
//class Device
//{
//    public string Name { get; set; }
//    public string Characteristics { get; set; }

//    public Device(string name, string characteristics)
//    {
//        Name = name;
//        Characteristics = characteristics;
//    }

//    public virtual void Sound()
//    {
//        Console.WriteLine("Звук устройства.");
//    }

//    public void Show()
//    {
//        Console.WriteLine($"Устройство: {Name}");
//    }

//    public void Desc()
//    {
//        Console.WriteLine($"Описание: {Characteristics}");
//    }
//}

//class Kettle : Device
//{
//    public Kettle() : base("Чайник", "Греет воду")
//    {
//    }

//    public override void Sound()
//    {
//        Console.WriteLine("Чайник: Свистит.");
//    }
//}

//class Microwave : Device
//{
//    public Microwave() : base("Микроволновка", "Разогревает еду")
//    {
//    }

//    public override void Sound()
//    {
//        Console.WriteLine("Микроволновка: Пищит.");
//    }
//}

//class Car : Device
//{
//    public Car() : base("Автомобиль", "Перевозит людей и грузы")
//    {
//    }

//    public override void Sound()
//    {
//        Console.WriteLine("Автомобиль: Бибикает.");
//    }
//}

//class Steamship : Device
//{
//    public Steamship() : base("Пароход", "Перевозит по воде")
//    {
//    }

//    public override void Sound()
//    {
//        Console.WriteLine("Пароход: Гудит.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Device[] devices = { new Kettle(), new Microwave(), new Car(), new Steamship() };

//        foreach (var device in devices)
//        {
//            device.Show();
//            device.Desc();
//            device.Sound();
//            Console.WriteLine();
//        }
//    }
//}
//Task 2

//class MusicalInstrument
//{
//    public string Name { get; set; }
//    public string Characteristics { get; set; }

//    public MusicalInstrument(string name, string characteristics)
//    {
//        Name = name;
//        Characteristics = characteristics;
//    }

//    public virtual void Sound()
//    {
//        Console.WriteLine("Этот инструмент издает звук.");
//    }

//    public void Show()
//    {
//        Console.WriteLine($"Музыкальный инструмент: {Name}");
//    }

//    public void Desc()
//    {
//        Console.WriteLine($"Описание: {Characteristics}");
//    }

//    public virtual void History()
//    {
//        Console.WriteLine("История создания неизвестна.");
//    }
//}

//class Violin : MusicalInstrument
//{
//    public Violin() : base("Скрипка", "Струнный смычковый инструмент с высоким звучанием")
//    {
//    }

//    public override void Sound()
//    {
//        Console.WriteLine("Скрипка: Тонкие и мелодичные звуки.");
//    }

//    public override void History()
//    {
//        Console.WriteLine("Скрипка появилась в XVI веке в Италии.");
//    }
//}

//class Trombone : MusicalInstrument
//{
//    public Trombone() : base("Тромбон", "Медный духовой инструмент с раздвижной трубой")
//    {
//    }

//    public override void Sound()
//    {
//        Console.WriteLine("Тромбон: Громкие и низкие звуки.");
//    }

//    public override void History()
//    {
//        Console.WriteLine("Тромбон появился в XV веке в Европе.");
//    }
//}

//class Ukulele : MusicalInstrument
//{
//    public Ukulele() : base("Укулеле", "Четырехструнный гавайский инструмент")
//    {
//    }

//    public override void Sound()
//    {
//        Console.WriteLine("Укулеле: Легкие и звонкие аккорды.");
//    }

//    public override void History()
//    {
//        Console.WriteLine("Укулеле появилось в XIX веке на Гавайях.");
//    }
//}

//class Cello : MusicalInstrument
//{
//    public Cello() : base("Виолончель", "Струнный смычковый инструмент с глубоким звучанием")
//    {
//    }

//    public override void Sound()
//    {
//        Console.WriteLine("Виолончель: Глубокие и выразительные звуки.");
//    }

//    public override void History()
//    {
//        Console.WriteLine("Виолончель появилась в XVI веке в Италии.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        MusicalInstrument[] instruments = { new Violin(), new Trombone(), new Ukulele(), new Cello() };

//        foreach (var instrument in instruments)
//        {
//            instrument.Show();
//            instrument.Desc();
//            instrument.Sound();
//            instrument.History();
//            Console.WriteLine();
//        }
//    }
//}
//Task 3
//abstract class Worker
//{
//    public abstract void Print();
//}

//class President : Worker
//{
//    public override void Print()
//    {
//        Console.WriteLine("Президент: Руководит всей компанией и принимает стратегические решения.");
//    }
//}

//class Security : Worker
//{
//    public override void Print()
//    {
//        Console.WriteLine("Охранник: Обеспечивает безопасность компании и сотрудников.");
//    }
//}

//class Manager : Worker
//{
//    public override void Print()
//    {
//        Console.WriteLine("Менеджер: Организует работу сотрудников и следит за выполнением задач.");
//    }
//}

//class Engineer : Worker
//{
//    public override void Print()
//    {
//        Console.WriteLine("Инженер: Разрабатывает и поддерживает технические системы.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Worker[] workers = { new President(), new Security(), new Manager(), new Engineer() };

//        foreach (var worker in workers)
//        {
//            worker.Print();
//        }
//    }
//}
