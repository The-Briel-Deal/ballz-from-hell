using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCurrChords : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject CylinderBullet = GameObject.FindGameObjectsWithTag("unfiredCylinder")[0];
        var AimX = CylinderBullet.GetComponent<Shoot>().AimX;
        var AimY = CylinderBullet.GetComponent<Shoot>().AimY;
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = $"Aim X: {AimX},\nAim Y: {AimY}";
    }
}
