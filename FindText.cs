using System.Text.RegularExpressions;

namespace kittycat;

public class FindText
{
    public static void FindFunc(string[] args)
    {
        string path = args[1];
        
        string file = File.ReadAllText(path);
        
        string search = "";
            
        for (int i = 2; i < args.Length; i++)
        {
            search += args[i] + " ";
        }
        
        try
        {
            Regex textRegex = new Regex(@search);
            Match textMatch = textRegex.Match(@file);
            if (textMatch.Success)
            {
                Console.WriteLine($"{textMatch.Value} (found)");
            }
            else
            {
                Console.WriteLine($"Couldn't find {search}");
            }
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Couldn't find text {search}");
            Console.WriteLine(ex.Message);
        }
    }
}