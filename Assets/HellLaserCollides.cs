using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellLaserCollides : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<EndGame>().StartDeathCoroutine();
            Destroy(collision.gameObject);
        }
    }
}
