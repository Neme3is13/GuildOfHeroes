Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);

alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine(">>> Участники готовы <<<");
Console.WriteLine();
Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());
Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");


Console.WriteLine();
Console.WriteLine(">>> Персонажи Dota 2 <<<");

DotaHero invoker = new DotaHero("Invoker", "Mid", 600, 48.5);
DotaHero tinker = new DotaHero("Tinker", "Mid", 550, 51.2);
DotaHero earthshaker = new DotaHero("Earthshaker", "Support", 620, 50.8);

Console.WriteLine($"{invoker.Name} | Роль: {invoker.Role} | HP: {invoker.Health} | WinRate: {invoker.WinRate}% | Игр сыграно: {invoker.GamesPlayed}");
Console.WriteLine($"{tinker.Name} | Роль: {tinker.Role} | HP: {tinker.Health} | WinRate: {tinker.WinRate}% | Игр сыграно: {tinker.GamesPlayed}");
Console.WriteLine($"{earthshaker.Name} | Роль: {earthshaker.Role} | HP: {earthshaker.Health} | WinRate: {earthshaker.WinRate}% | Игр сыграно: {earthshaker.GamesPlayed}");