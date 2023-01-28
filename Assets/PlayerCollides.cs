using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollides : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "HellLaser")
        {
            gameObject.GetComponent<EndGame>().StartDeathCoroutine();
            Destroy(gameObject);
        }
    }
}
