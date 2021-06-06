using System;

[Serializable]
public class Stage
{
    public Stage(Main main, int id)
    {
        _main = main;
        this.id = id;
        hero = new Hero(null, "Hero");
    }

    public int id;
    public Hero hero;

    private Main _main;
}