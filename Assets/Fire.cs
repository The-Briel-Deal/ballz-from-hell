using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire : MonoBehaviour
{
	void Start()
	{
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		GameObject[] arrayOfGameObjects =  GameObject.FindGameObjectsWithTag("unfiredCylinder");
		GameObject unfiredCylinder = arrayOfGameObjects[0];
		GameObject.Instantiate(unfiredCylinder);
		unfiredCylinder.GetComponent<Shoot>().firstDown = false;
		unfiredCylinder.tag = "Untagged";
		unfiredCylinder.GetComponent<Rigidbody>().velocity += new Vector3(-20, -10 + unfiredCylinder.GetComponent<Shoot>().AimY, unfiredCylinder.GetComponent<Shoot>().AimX);
	}
}
