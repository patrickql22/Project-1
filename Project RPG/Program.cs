using System;

class Program
{
    static int hp = 100;
    static int credits = 800;
    static string agent = "Jett";
    static string[] items = {"Classic", "Knife"};
    static bool spike = false;

    static void Main()
    {
        Console.WriteLine("=== VALORANT TEXT RPG ===");

        while (hp > 0)
        {
            Console.WriteLine("\n1. Buy");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Defend");
            Console.WriteLine("4. Game State");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Buy(); break;
                case "2": Attack(); break;
                case "3": Defend(); break;
                case "4": State(); break;
                case "5": return;
                default: Console.WriteLine("Invalid choice."); break;
            }

            if (credits >= 1500)
            {
                Console.WriteLine("YOU WIN!");
                return;
            }
        }

        Console.WriteLine("GAME OVER!");
    }

    // Scene 1
    static void Buy()
    {
        Console.WriteLine("\n--- BUY PHASE ---");
        Console.WriteLine("1. Sheriff ($800)");
        Console.WriteLine("2. Shield ($400)");

        string choice = Console.ReadLine();

        if (choice == "1" && credits >= 800)
        {
            credits -= 800;
            items[0] = "Sheriff";
            Console.WriteLine("Bought Sheriff!");
        }
        else if (choice == "2" && credits >= 400)
        {
            credits -= 400;
            hp += 25;
            items[1] = "Shield";
            Console.WriteLine("Bought Shield! +25 HP");
        }
        else
        {
            Console.WriteLine("Invalid choice or not enough credits.");
        }
    }

    // Scene 2
    static void Attack()
    {
        Console.WriteLine("\n--- ATTACK SITE ---");
        Console.WriteLine("1. Rush");
        Console.WriteLine("2. Sneak");
        Console.WriteLine("3. Ability");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            hp -= 20;
            credits += 300;
            spike = true;
        }
        else if (choice == "2")
        {
            credits += 200;
            spike = true;
        }
        else if (choice == "3")
        {
            hp += 10;
            spike = true;
        }

        if (spike)
        {
            Console.WriteLine("SPIKE PLANTED!");
            credits += 500;
            spike = false;
        }
    }

    // Scene 3
    static void Defend()
    {
        Console.WriteLine("\n--- DEFEND SITE ---");
        Console.WriteLine("1. Hold Angle");
        Console.WriteLine("2. Push Enemy");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                credits += 200;
                Console.WriteLine("Enemy eliminated!");
                break;

            case "2":
                hp -= 30;
                Console.WriteLine("You pushed the enemy!");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void State()
    {
        Console.WriteLine("\n--- GAME STATE ---");
        Console.WriteLine("Agent: " + agent);
        Console.WriteLine("HP: " + hp);
        Console.WriteLine("Credits: " + credits);

        for (int i = 0; i < items.Length; i++)
            Console.WriteLine(items[i]);

        foreach (string item in items)
            Console.WriteLine("Item: " + item);
    }
}










