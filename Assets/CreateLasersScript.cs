using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLasersScript : MonoBehaviour
{
    AudioScripting SatansAudioScripting = GameObject.FindGameObjectWithTag("AudioScript").GetComponent<AudioScripting>();
    public GameObject HellLaser;
    public GameObject Platform;
    private bool firstTime = true;
    private bool startTilting = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void TiltPlatform()
    {
        
        
    }
    public void LasersToCreateWhenClip4Finished()
    {
        CreateHellLaser(new Vector3(5.80000019f, 13.690382f, -21.2999992f), new Vector3(5.80000019f, 13.690382f, 20.2000008f), .15f);
        CreateHellLaser(new Vector3(-20.0599995f, 13.3500004f, -6.5f), new Vector3(13.8999996f, 17.7000008f, 3.9000001f), .1f);
        CreateHellLaser(new Vector3(-3.5f, 12.690382f, -16.5000114f), new Vector3(2f, -13.690382f, 23.7000008f), .1f);
        CreateHellLaser(new Vector3(-8.5f, 13.690382f, -16.5000114f), new Vector3(2f, 13.690382f, 23.7000008f), .1f);
        CreateHellLaser(new Vector3(15.6000004f, 13.690382f, 20.8999996f), new Vector3(-4.4000001f, 13.690382f, -34.2000008f), .1f);

    }
    public void LasersToCreateWhenClip5Finished()
    {
        CreateHellLaser(new Vector3(5.80000019f, 13.690382f, -21.2999992f), new Vector3(5.80000019f, 13.690382f, 20.2000008f), .15f);
        CreateHellLaser(new Vector3(-20.0599995f, 13.3500004f, -6.5f), new Vector3(13.8999996f, 17.7000008f, 3.9000001f), .1f);
        CreateHellLaser(new Vector3(-3.5f, 12.690382f, -16.5000114f), new Vector3(2f, -13.690382f, 23.7000008f), .1f);
        CreateHellLaser(new Vector3(-8.5f, 13.690382f, -16.5000114f), new Vector3(2f, 13.690382f, 23.7000008f), .1f);
        CreateHellLaser(new Vector3(15.6000004f, 13.690382f, 20.8999996f), new Vector3(-4.4000001f, 13.690382f, -34.2000008f), .1f);
        startTilting = true;

    }
    void CreateHellLaser(Vector3 from, Vector3 to, float speed)
    {
        var hellLaser = Instantiate(HellLaser, from, Quaternion.identity);
        var hellLaserMovement = hellLaser.GetComponent<HellLaserMovement>();
        hellLaserMovement.To = to;
        hellLaserMovement.Speed = speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (startTilting)
        {
            Platform.transform.rotation = Quaternion.RotateTowards(Platform.transform.rotation, new Quaternion(0.00803335942f, -0.0223955847f, -0.0769884884f, 0.99674809f), .005f);
        }
        /*Platform.transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, .01f);*/
    }
}
