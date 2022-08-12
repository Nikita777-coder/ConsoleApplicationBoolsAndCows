using System.Text;

namespace BoolsAndCows.Game;

/// <summary>
/// Class for generation number of game.
/// </summary>
public class BoolsAndCowsGame : Functions
{
    private string GeneratedNumberInString { get; }
    private ulong GenerationNumberForGame(byte minBound = 1, byte maxBound = 1)
    {
        // Min and max bounds of the game number length;
        byte lowerMinBound = minBound, upperMaxBound = maxBound;
        ulong generatedNum = 0;
        var digitList = new List<byte> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        // Variable "random" is used for avoidance double calling of the class Random.
        var random = new Random();
        
        // Generating of game number length. It depends from mode of game.
        if (Mode == Mode.s)
            upperMaxBound = lowerMinBound = 4;
        Length = (byte) random.Next(lowerMinBound, upperMaxBound + 1);
        
        // Generating of game number;
        for (byte i = 0; i < Length; ++i)
        {
            int ind;
            if (i != 0)
            {
                ind = random.Next(0, digitList.Count);
                generatedNum *= 10;
            }
            else
                ind = random.Next(1, digitList.Count);
            generatedNum += digitList[ind];
        }

        return generatedNum;
    }
    
    // Method for the last symbol of counted noun.
    private string PlusSOrNot(byte count) => count != 1 ? "s" : "";

    /// <summary>
    /// Constructor, which fill all features of class.
    /// </summary>
    /// <param name="mode">code of the game mode</param>
    public BoolsAndCowsGame(char mode, byte oneBoard = 1, byte twoBoard = 1)
    {
        Mode = Enum.Parse<Mode>(mode.ToString());
        GetGenerateNumber = GenerationNumberForGame(Math.Min(oneBoard, twoBoard), Math.Max(oneBoard, twoBoard));
        GeneratedNumberInString = GetGenerateNumber.ToString();
    }
    
    public byte Length { get; private set; }

    public ulong GetGenerateNumber { get; init; }
    
    public Mode Mode { private get; init; }

    public string GetInfoAboutLengthOfGuessNumber() => $"The game number length is {Length}";

    public string GetInfoAboutBulls(ulong userNumber)
    {
        string userNumberInString = userNumber.ToString();
        byte count = 0;
        List<char> bullsDigits = new();
        
        for (int i = 0; i < userNumberInString.Length; ++i)
            if (userNumberInString[i] == GeneratedNumberInString[i])
            {
                ++count;
                bullsDigits.Add(userNumberInString[i]);
            }

        return $"{count} bull{PlusSOrNot(count)}";
    }

    public string GetInfoAboutCows(ulong userNumber)
    {
        string userNumberInString = userNumber.ToString();
        byte count = 0;
        List<char> cowsDigits = new();
        
        for (int i = 0; i < userNumberInString.Length; ++i)
            if (userNumberInString[i] != GeneratedNumberInString[i])
                if (GeneratedNumberInString.IndexOf(userNumberInString[i]) != -1)
                {
                    ++count;
                    cowsDigits.Add(userNumberInString[i]);
                }

        return $"{count} cow{PlusSOrNot(count)}";
    }
}