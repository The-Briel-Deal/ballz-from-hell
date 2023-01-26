using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public float AimX;
    public float AimY;
    private bool firstDown;
    void Start()
    {
        firstDown = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && firstDown)
        {
            GameObject.Instantiate(gameObject);
            firstDown = false;
            gameObject.tag = "Untagged";
            gameObject.GetComponent<Rigidbody>().velocity += new Vector3(-20, -10 + AimY, AimX);
        }
    }
}
