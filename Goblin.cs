namespace Rpg;

public class Goblin
{
    public string Name;
    public int Health;
    public int Attack;

    public Goblin()
    {
        Name = "Goblin";
        Health = 100;
        Attack = 15;
    }

    public void PrintStats()
    {
        Console.WriteLine($"Name: {Name} | Health: {Health} | Attack: {Attack}");
    }
    
    
    
}