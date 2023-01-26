using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimLeft : MonoBehaviour
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
		print(arrayOfGameObjects);
		unfiredCylinder.GetComponent<Shoot>().AimX -= (float).25;
	}
}
