using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
	public AudioSource SatanTalking;
	public AudioClip LossAudio;
	private bool FirstFall = true;
	void Update()
	{
		Transform transform = gameObject.GetComponent<Transform>();
		if (transform.position.y < -10 && FirstFall)
        {
			FirstFall = false;
			StartDeathCoroutine();
		}
	}
	public void StartDeathCoroutine()
    {
		StartCoroutine(DeathCoroutine());
	}
	IEnumerator DeathCoroutine()
	{
		SatanTalking.clip = LossAudio;
		SatanTalking.Play();
		Destroy(SatanTalking.gameObject.GetComponent<AudioScripting>());
		// wait for duration of the clip than continue executing rest of the code
		yield return new WaitForSeconds(SatanTalking.clip.length);
		SceneManager.LoadScene(0, LoadSceneMode.Single);
	}
}
