using System;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class Hero : IDisposable
{
    public Hero(Stage stage)
    {
        this.stage = stage;
    }

    
    
    public Stage stage;
    
    
    
    public void Dispose()
    {
        Debug.Log("Hero Dispose");
        stage = null;
    }
}
