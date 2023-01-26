using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimUp : MonoBehaviour
{
	void Start()
	{
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		GameObject unfiredCylinder = GameObject.FindGameObjectsWithTag("unfiredCylinder")[0];
		unfiredCylinder.GetComponent<Shoot>().AimY += (float).25;
	}
}
