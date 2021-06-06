using System;

[Serializable]
public class Hero
{
    public Hero(Stage stage, string name)
    {
        _stage = stage;
        this.name = name;
    }

    
    
    public string name;


    private Stage _stage;
}
