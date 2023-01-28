using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraCircle : MonoBehaviour
{
    // Start is called before the first frame update
    private int Frame;
    void Start()
    {
        Frame = 0;
        gameObject.GetComponent<Transform>().position = new Vector3((float)-11.7, (float)10.75, (float)-23.88);
        gameObject.GetComponent<Transform>().rotation = new Quaternion((float)0.192638144, (float)0.270619214, (float)-0.0313678347, (float)0.942694008);
    }

    private void FixedUpdate()
    {
        if (Frame < 240)
        {
            gameObject.GetComponent<Transform>().position += new Vector3((float)-.05, 0, 0);
        } else if (Frame == 241)
        {
            gameObject.GetComponent<Transform>().position = new Vector3((float)-26.52, (float)15.43, (float)-26.15);
            gameObject.GetComponent<Transform>().rotation = new Quaternion(0.195084423f, 0.391350299f, -0.00595515454f, 0.899306238f);
        } else if (Frame < 500)
        {
            gameObject.GetComponent<Transform>().position += new Vector3(0, (float)-.05, 0);
            gameObject.GetComponent<Transform>().Rotate(new Vector3(0, .01f, 0));
        } else if (Frame == 501)
        {
            gameObject.GetComponent<Transform>().position = new Vector3(-20.1800003f, 10.3999996f, -19.7800007f);
            gameObject.GetComponent<Transform>().rotation = new Quaternion(0.169216067f, 0.370544881f, -0.0770394728f, 0.910015106f);
        }
        else if (Frame < 2000)
        {
            gameObject.GetComponent<Transform>().RotateAround(new Vector3(0, 0, 0), Vector3.up, 1);
        } else
        {
            Start();
        }

        Frame += 1;
    }
}
