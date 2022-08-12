namespace BoolsAndCows.Interface;


public class MenuItem
{
    #region Properties

    public int ID { get; set; }
    public string Text { get; set; }
    public Action Action { get; set; }

    #endregion

    #region Constructors

    public MenuItem()
    {

    }

    public MenuItem(int id, string text, Action action)
    {
        ID = id;
        Text = text;
        Action = action;
    }

    #endregion
}