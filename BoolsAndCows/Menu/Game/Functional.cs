namespace BoolsAndCows.MenuClasses.Game;

/// <summary>
/// Menu game functional. 
/// </summary>
interface Functional
{
    /// <summary>
    /// Simple mode.
    /// </summary>
    void s();
    
    /// <summary>
    /// Hard mode.
    /// </summary>
    void h();
    
    /// <summary>
    /// Function for choosing game mode.
    /// </summary>
    void ChoiceOfLevel();
    
    /// <summary>
    /// Choose min quantity of digits in hidden number (only for h mode).
    /// </summary>
    void ChoiceOfMinCountOfDigitsInNumber();
    
    /// <summary>
    /// Choose max quantity of digits in hidden number (only for h mode).
    /// </summary>
    void ChoiceOfMaxCountOfDigitsInNumber();
}