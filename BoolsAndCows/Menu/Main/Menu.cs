using BoolsAndCows.Interface;
using BoolsAndCows.MenuClasses.Game;

namespace BoolsAndCows.MenuClasses;

/// <summary>
/// Main Menu.
/// </summary>
class Menu : MainFunctions
{
    // Console Menu.
    private ConsoleMenu cm;

    /// <summary>
    /// Launch menu.
    /// </summary>
    public Menu()
    {
        Console.Clear();
        cm = new ConsoleMenu(">");
        Greeting();
        cm.addMenuItem(0, "New game", Game);
        //cm.addMenuItem(1, "Settings", Settings);
        cm.addMenuItem(1, "Exit", Exit);
        cm.showMenu();
    }

    public void Greeting()
    {
        cm.Header = "\n" +
                    "                              █▀▄ █░█ █░░ █░░ ▄▀▀     ▄▀▄ █▄░█ █▀▄     ▄▀ ▄▀▄ █░░░█ ▄▀▀\n" +
                    "                              █▀█ █░█ █░▄ █░▄ ░▀▄     █▀█ █░▀█ █░█     █░ █░█ █░█░█ ░▀▄ \n" +
                    "                              ▀▀░ ░▀░ ▀▀▀ ▀▀▀ ▀▀░     ▀░▀ ▀░░▀ ▀▀░     ░▀ ░▀░ ░▀░▀░ ▀▀░ \n" +
                    "                                                ░░░░░░░░░░░░░░░░░░░░░░\n" +
                    "                                                ░░░░▄░░▄░░░░░░░░░░░░░░\n" +
                    "                                                ░░░░░█████▓████╗░░░░░░\n" +
                    "                                                ░░░░░└┘████████╚░░░░░░\n" +
                    "───────────────────────────────────────────────────────▌▐──└┘▌▐─" +
                    "───────────────────────────────────────────────────────\n\n";
    }

    public void Game()
    {
        var item = new NewGame(cm);
    }

    public void Exit()
    {
        // Some picture - in processed.
        Environment.Exit(0);
    }
}