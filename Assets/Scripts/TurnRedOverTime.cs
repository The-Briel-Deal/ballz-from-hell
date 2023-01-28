using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;
using System.Timers;

public class TurnRedOverTime : MonoBehaviour
{
    // Start is called before the first frame update
    private static System.Timers.Timer timer;
    void Start()
    {
        timer = new System.Timers.Timer(10);
        timer.Elapsed += (sender, e) =>
        {
            
            Light light = GameObject.FindGameObjectWithTag("LevelOneMainLight").GetComponent<Light>();
            Color color = light.color;
            light.color = new Color(255, color.g - 1, color.b - 1);
            print($"bruh {color}");
        };
        timer.Start();
    }
    void OnApplicationQuit()
    {
        timer.Stop();
    }
}
