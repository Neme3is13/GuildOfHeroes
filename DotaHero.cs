public class DotaHero {
    public string Name;
    public string Role;
    public int Health;
    public double WinRate;
    public int GamesPlayed;

    public DotaHero(string name, string role, int health, double winRate) {
        Name = name;
        Role = role;
        Health = health;
        WinRate = winRate;
        GamesPlayed = 0;
    }
}