using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Main : MonoBehaviour
{
    public List<Stage> stages;
    
    private void OnGUI()
    {
        if (GUI.Button(new Rect (200, 200, 200, 200), "Create"))
        {
            for (var i = 0; i < 16_384; i++) stages.Add(new Stage(this, i));
        }
        
        if (GUI.Button(new Rect(200, 600, 200, 200), "New"))
        {
            stages = new List<Stage>();
        }
        
        if (GUI.Button(new Rect(500, 600, 200, 200), "Clear")) stages.Clear();

        if (GUI.Button(new Rect(200, 900, 200, 200), "Collect"))
        {
            GC.Collect();
        }
    }

    private void OnDestroy()
    {
        Debug.Log("On Destroy");
    }
}
