namespace kittycat;

public class Display
{
    public static void Help()
    {
        Console.WriteLine("Usage: kittycat -r <file>");
        Console.WriteLine("--version  : Displays version");
        Console.WriteLine("--discord  : Invites you to the Discord server");
        Console.WriteLine("--source  : Gives you a link to the source code");
        Console.WriteLine("-r : Reads file - kittycat -r <file>");
        Console.WriteLine("-f : Searches for the text in the file - kittycat -f <file> <text>");
        Console.WriteLine("\n Examples:");
        Console.WriteLine("kittycat -r f.pef - reads f.pef file");
    }

    public static void Source()
    {
        Console.WriteLine("KittyCat is made by Polokalap");
        Console.WriteLine("Consider Supporting at https://buymeacoffee.com/Polokalap");
        Console.WriteLine("https://github.com/Polokalap/kittycat");
    }

    public static void Discord()
    {
        Console.WriteLine("Join My Discord at https://discord.gg/WpzRvhymyJ");
    }
}