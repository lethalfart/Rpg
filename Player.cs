namespace Rpg;

public class Player
{
    Random random = new Random();
    public string Name;
    public int Health;
    public int Attack;
    public int Potions;
    public int critChance;

    public Player(string name)
    {
        Name = name;
        Health = 100;
        Attack = 10;
        Potions = 3;
        critChance = random.Next(0, 10);

    }

    public void PrintStats()
    {
        Console.WriteLine($"Name: {Name} | Health: {Health} | Attack: {Attack}");
    }

    public void drinkPotion()
    {
        if (Potions > 0)
        {
            Health = Health + 30;
            Potions--;
            Console.WriteLine($"You have drank a potion and recovered 30 hp! you have {Potions} potions left and your current health is {Health}!");
        }
        else
        {
           Console.WriteLine($"You are out of potions :(");
        }
    }




}