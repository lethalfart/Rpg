using Rpg;
Random random = new Random();

string playerName;
string playerOption;

Console.WriteLine("cool super awesomen RPG with fucking scary monsters");

Console.Write("Name your brave hero: ");
playerName = Console.ReadLine();


Player player = new Player(playerName);
Goblin goblin = new Goblin();


void playerHit()
{
    player.critChance = random.Next(1, 11);
    if (player.critChance == 10)
    {
        player.Attack = player.Attack + 15;
        Console.Write("Critical hit! Your attack does 15 more damage :p");
    }
    goblin.Health = goblin.Health - player.Attack;
    Console.WriteLine($"\nYou hit the {goblin.Name} for {player.Attack} damage!\nThe {goblin.Name} now has {goblin.Health} health!\nPress enter to continue....\n");
    if (player.critChance == 10)
    {
        player.Attack = player.Attack - 15;
    }
}

void goblinHit()
{
    player.Health = player.Health - goblin.Attack;
    Console.WriteLine($"\nOh no! A goblin has hit you for {goblin.Attack} you now have {player.Health} health!\nPress enter to continue.....\n");
    Console.ReadKey();
}


while (player.Health > 0 && goblin.Health > 0)
{
    Console.WriteLine($"\nName: {player.Name} | Player hp {player.Health} | Player ATK: {player.Attack}\n \n--Player turn--\n \n1. Attack goblin\n2.Drink health potion");
    playerOption = Console.ReadLine().ToLower();
    if (playerOption == "1")
    {
        playerHit();
        if (goblin.Health > 0)
        {   Console.WriteLine($"--{goblin.Name} turn--");
            goblinHit();
        }
    }
    else if (playerOption == "2")
    {
        player.drinkPotion();
        if (goblin.Health > 0)
        {
            Console.WriteLine($"--{goblin.Name} turn--");
            goblinHit();
        }
        
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"\n{playerOption} is not a valid option.\n \nPress enter to continue...");
        Console.ReadKey();
    }
}

if (player.Health <= 0)
{
    Console.WriteLine("You lose!");
}
else if (goblin.Health <= 0)
{
    Console.WriteLine("You Win!");
}








