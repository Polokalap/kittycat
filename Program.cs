using kittycat;

class Program()
{
    static void Main(string[] args)
    {
        string version = "0.01v";
        if (args.Length > 0)
        {
            // Command
            switch (args[0])
            {
                case "--help":
                    Display.Help();
                    break;
                case "--version":
                    Console.WriteLine($"{version} made by Polokalap");
                    break;
                case "--source":
                    Display.Source();
                    break;
                case "--discord":
                    Display.Discord();
                    break;
                case "-r":
                    ReadFile.ReadFunc(args);
                    break;
                case "-read":
                    ReadFile.ReadFunc(args);
                    break;
                case "-f":
                    FindText.FindFunc(args);
                    break;
                case "-find":
                    FindText.FindFunc(args);
                    break;
                default:
                    Console.WriteLine("Usage: kittycat --help");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Usage: kittycat --help");
        }
    }
}