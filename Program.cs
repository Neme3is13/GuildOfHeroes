Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);


Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");

if (yaroslavAlive) {
    Console.WriteLine("Ярослав может продолжать приключение.");
} else {
    Console.WriteLine("Ярослав больше не может сражаться.");
}

string info = yaroslav.GetInfo();
Console.WriteLine("Строка получена. Сейчас выведем её:");
Console.WriteLine(info);

Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());

Console.WriteLine();
Console.WriteLine(">>> Персонажи Dota 2 <<<");

DotaHero invoker = new DotaHero("Invoker", "Mid", 600, 48.5);
DotaHero tinker = new DotaHero("Tinker", "Mid", 550, 51.2);
DotaHero earthshaker = new DotaHero("Earthshaker", "Support", 620, 50.8);

Console.WriteLine($"{invoker.Name} | Роль: {invoker.Role} | HP: {invoker.Health} | WinRate: {invoker.WinRate}% | Игр сыграно: {invoker.GamesPlayed}");
Console.WriteLine($"{tinker.Name} | Роль: {tinker.Role} | HP: {tinker.Health} | WinRate: {tinker.WinRate}% | Игр сыграно: {tinker.GamesPlayed}");
Console.WriteLine($"{earthshaker.Name} | Роль: {earthshaker.Role} | HP: {earthshaker.Health} | WinRate: {earthshaker.WinRate}% | Игр сыграно: {earthshaker.GamesPlayed}");

Console.WriteLine($"Игр сыграно до: {invoker.GamesPlayed}");

invoker.PlayMatches(3);
Console.WriteLine($"Игр сыграно после +3: {invoker.GamesPlayed}");

invoker.PlayMatches(-2);
Console.WriteLine($"Игр сыграно после -2: {invoker.GamesPlayed}");