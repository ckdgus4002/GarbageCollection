using System;
using UnityEditor;
using UnityEngine;

[Serializable]
public class Stage : IDisposable
{
    public Stage(Main main)
    {
        this.main = main;
        hero = new Hero(this);
    }

    
    
    public Main main;
    public Hero hero;
    
    
    
    public void Dispose()
    {
        Debug.Log("Stage Dispose");

        main = null;
        hero = null;
    }
}