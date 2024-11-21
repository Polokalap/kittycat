namespace kittycat;

public class ReadFile
{
    public static void ReadFunc(string [] args)
    {
        if (args[1].Length.Equals(""))
        {
            Console.WriteLine("Usage: kittycat -r <file>");
        }
        else
        {
            string path = args[1];
            
            try
            {
                Console.Write(File.ReadAllText(path));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to read {path}.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}