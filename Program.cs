Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

yaroslav.Health = 75;

Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.Level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.Level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.Level}");
Console.WriteLine($"Опыт: {artem.Experience}");


Console.WriteLine();
Console.WriteLine(">>> Персонажи Dota 2 <<<");

DotaHero invoker = new DotaHero("Invoker", "Mid", 600, 48.5);
DotaHero tinker = new DotaHero("Tinker", "Mid", 550, 51.2);
DotaHero earthshaker = new DotaHero("Earthshaker", "Support", 620, 50.8);

Console.WriteLine($"{invoker.Name} | Роль: {invoker.Role} | HP: {invoker.Health} | WinRate: {invoker.WinRate}% | Игр сыграно: {invoker.GamesPlayed}");
Console.WriteLine($"{tinker.Name} | Роль: {tinker.Role} | HP: {tinker.Health} | WinRate: {tinker.WinRate}% | Игр сыграно: {tinker.GamesPlayed}");
Console.WriteLine($"{earthshaker.Name} | Роль: {earthshaker.Role} | HP: {earthshaker.Health} | WinRate: {earthshaker.WinRate}% | Игр сыграно: {earthshaker.GamesPlayed}");