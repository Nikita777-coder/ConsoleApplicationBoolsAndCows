namespace BoolsAndCows.Game;

public class AlgoritmPlaying
{
    private byte oneBound, twoBound;
    private char mode;
    
    // Function which try to get correct number.
    private ulong GetUserNum(string userNum)
    {
        if (!ulong.TryParse(userNum, out ulong number))
            throw new FormatException("Entered string can't be parse to ulong.");
        if (number.ToString().Length != BACGame.Length)
            throw new OverflowException("Entered number have overflow length.");
        return number;
    }
    
    private BoolsAndCowsGame BACGame { get; set; }
    
    /// <summary>
    /// Game launch.
    /// </summary>
    /// <param name="mode">mode which user chose</param>
    /// <param name="oneBound"></param>
    /// <param name="twoBound"></param>
    public AlgoritmPlaying(char mode, byte oneBound = 1, byte twoBound = 1)
    {
        this.mode = mode;
        this.oneBound = oneBound;
        this.twoBound = twoBound;
    }
    
    /// <summary>
    /// Start playing.
    /// </summary>
    public void Game()
    {
        BACGame = new BoolsAndCowsGame(mode, oneBound, twoBound);
        ulong userNum = 0;
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   _          _   _             _             _ \n" +
                          "  | |        | | ( )           | |           | |\n" +
                          "  | |     ___| |_|/ ___   _ __ | | __ _ _   _| |\n" +
                          "  | |    / _ | __| / __| | '_ || |/ _` | | | | |\n" +
                          "  | |___|  __/ |_  |__ | | |_) | | (_| | |_| |_|\n" +
                          "  |_____/|___||__| |___/ | .__/|_||__,_||__, (_)\n" +
                          "                         | |             __/ |  \n" +
                          "                         |_|            |___/   \n");
        Console.ResetColor();
        
        Console.WriteLine($"{BACGame.GetInfoAboutLengthOfGuessNumber()}.");
        do
        {
            Console.Write("Try to guess game number: ");

            try
            {
                userNum = GetUserNum(Console.ReadLine());
                Console.WriteLine($"{BACGame.GetInfoAboutBulls(userNum)}, {BACGame.GetInfoAboutCows(userNum)}.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n{e.Message}");
            }
        } while (BACGame.GetGenerateNumber != userNum);
        
        Console.WriteLine("\n\nMy congratulations! You guessed the hiden number");
        Console.WriteLine("Press Enter to continue");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {}
    }
}