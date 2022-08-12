using BoolsAndCows.Interface;
using BoolsAndCows.Game;

namespace BoolsAndCows.MenuClasses.Game;

public class NewGame : Functional
{
    // Menu for game functions.
    private ConsoleMenu cm;
    
    // Fields for function Play().
    private byte oneBound = 1, twoBound = 1;
    
    private ConsoleMenu Root { get;}
    
    // Confirmation of successful choosing of first board and go to parent menu.
    private void COSCOFBAGTPM(byte num)
    {
        Console.Clear();
        Console.WriteLine("The length of game number was chose successfully");
        oneBound = num;
        // Go to h menu;
        cm = cm.ParentMenu;
        cm.showMenu();
    }
    
    // Confirmation of successful choosing of second board and go to parent menu.
    private void COSCOSBAGTPM(byte num)
    {
        Console.Clear();
        Console.WriteLine("The length of game number was chose successfully");
        twoBound = num;
        // Go to h menu;
        cm = cm.ParentMenu;
        cm.showMenu();
    }
    private void SetNewMenu()
    {
        Console.Clear();
        var lastMenu = cm;
        cm = new ConsoleMenu(">");
        cm.ParentMenu = lastMenu;
    }

    private void Play(char mode)
    {
        Console.Clear();
        Console.ResetColor();
        var game = new AlgoritmPlaying(mode, oneBound, twoBound);
        game.Game();
        cm = Root;
        cm.showMenu();
    }
    
    /// <summary>
    /// New game starting.
    /// </summary>
    /// <param name="parent">path to <<New Game>> menu</param>
    public NewGame(ConsoleMenu parent)
    {
        Console.Clear();
        cm = new ConsoleMenu(">");
        Root = parent;
        cm.addMenuItem(0, "Choice of level", ChoiceOfLevel);
        cm.showMenu();
    }
    
    public void s() => Play('s');

    public void h()
    {
        SetNewMenu();
        cm.addMenuItem(0, "Choice of first bound count of digits in number", ChoiceOfMinCountOfDigitsInNumber);
        cm.addMenuItem(1, "Choice of second bound count of digits in number", ChoiceOfMaxCountOfDigitsInNumber);
        cm.addMenuItem(2, "Play", () => Play('h'));
        cm.showMenu();
    }
    public void ChoiceOfLevel()
    {
        SetNewMenu();
        cm.addMenuItem(0, "simple", s);
        cm.addMenuItem(1, "hard", h);
        cm.showMenu();
    }

    public void ChoiceOfMaxCountOfDigitsInNumber()
    {
        Console.Clear();
        SetNewMenu();
        cm.SubTitle = "---------------- Choose your max length of game number -----------------";

        for (byte i = 1; i < 11; ++i)
        {
            byte ind = i;
            cm.addMenuItem(ind - 1, ind.ToString(), () => COSCOFBAGTPM(ind));
        }

        cm.showMenu();
    }

    public void ChoiceOfMinCountOfDigitsInNumber()
    {
        Console.Clear();
        SetNewMenu();
        cm.SubTitle = "---------------- Choose your min length of game number -----------------";
        
        for (byte i = 1; i < 11; ++i)
        {
            byte ind = i;
            cm.addMenuItem(ind - 1, ind.ToString(), () => COSCOSBAGTPM(ind));
        }

        cm.showMenu();
        Console.ResetColor();
    }
}