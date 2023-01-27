using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptedMovement : MonoBehaviour
{
    public int Frame;
    // Start is called before the first frame update
    void Start()
    {
        Frame = 0;
        print("hit");
        gameObject.transform.position = new Vector3(0, 5.23999977f, 0);
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3();
        gameObject.GetComponent<Rigidbody>().ResetInertiaTensor();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Frame < 20)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 3));
        } else if (Frame < 50)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(2, 0, -7));
        } else if (Frame < 100)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-3, 0, 1));
        }
        else if (Frame < 250)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(2, 0, -2));
        }
        else if (Frame < 300)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-10, 0, 5));
        }
        else if (Frame < 500)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(3, 0, 5));
        }
        else if (Frame < 600)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-5, 0, -10));
        }
        else if (Frame < 800)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(10, 0, 10));
        } else
        {
            Start();
        }

        Frame += 1;
    }
}
