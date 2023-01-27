using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int FixedFrames;
    // Start is called before the first frame update
    void Start()
    {
        FixedFrames = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = $"Time: {30 - (FixedFrames/50)}";
        FixedFrames += 1;
    }
}
