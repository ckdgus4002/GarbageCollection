using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class Main : MonoBehaviour
{
    public List<Stage> stages;


    private int debugging = 0;
    
    
    
    private void OnGUI()
    {
        if (GUI.Button(new Rect (200, 200, 200, 200), "Create"))
        {
            Debug.Log($"{debugging++} Create.");
            for (var i = 0; i < 100_000; i++) stages.Add(new Stage(this));
            Selection.activeObject = this;
        }

        if (GUI.Button(new Rect(200, 500, 200, 200), "New"))
        {
            Debug.Log($"{debugging++} New.");
            stages = new List<Stage>();
        }

        if (GUI.Button(new Rect(500, 500, 200, 200), "Clear"))
        {
            Debug.Log($"{debugging++} Clear.");
            stages.Clear();
        }
        
        // if (GUI.Button(new Rect(800, 500, 200, 200), "Dispose"))
        // {
        //     Debug.Log($"{debugging++} Dispose.");
        //     foreach (var s in stages) s.Dispose();
        // }
        
        if (GUI.Button(new Rect(1100, 500, 200, 200), "Null"))
        {
            Debug.Log($"{debugging++} Null.");
            stages = null;
        }

        if (GUI.Button(new Rect(200, 800, 200, 200), "Collect"))
        {
            Debug.Log($"{debugging++} Collect.");
            GC.Collect();
        }
    }

    private void OnDestroy()
    {
        Debug.Log($"{debugging++} Main On Destroy.");
    }
}
