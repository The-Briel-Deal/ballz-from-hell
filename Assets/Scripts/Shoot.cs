using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public int TriggerFrame;
    public int Frame;
    public float AimX;
    public float AimY;
    public float AimZ;
    public bool firstDown;
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Frame == TriggerFrame)
        {
            gameObject.GetComponent<Rigidbody>().velocity += new Vector3(AimX ,AimY, AimZ);
            gameObject.GetComponent<AudioSource>().Play();
        }
        Frame += 1;
    }
}
