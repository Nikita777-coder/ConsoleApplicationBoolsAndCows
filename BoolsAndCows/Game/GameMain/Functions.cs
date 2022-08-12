namespace BoolsAndCows.Game;
/// <summary>
/// The main functionality of the game.
/// </summary>
public interface Functions
{
    /// <summary>
    /// Method which give info about game number length.
    /// </summary>
    string GetInfoAboutLengthOfGuessNumber();

    /// <summary>
    /// Feature for generating game number.
    /// </summary>
    ulong GetGenerateNumber { get; init; }
    
    /// <summary>
    /// Method which give info about how and what digit-bulls in user number.
    /// </summary>
    /// <returns>string presentation about how and what digit-bulls in user number</returns>
    string GetInfoAboutBulls(ulong userNumber);
    
    /// <summary>
    /// Method which give info about how and what digit-cows in user number.
    /// </summary>
    /// <returns>string presentation about how and what digit-cows in user number</returns>
    string GetInfoAboutCows(ulong userNumber);
    
    /// <summary>
    /// Feature for initialization of game mode.
    /// </summary>
    Mode Mode { init; }
}