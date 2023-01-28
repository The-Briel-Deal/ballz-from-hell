using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HellLaserMovement : MonoBehaviour
{
    public Vector3 To;
    public float Speed;
    public bool StartLaser;
    // Start is called before the first frame update
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, To, Speed);
        if (transform.position == To)
        {
            Destroy(gameObject);
        }
    }
}
