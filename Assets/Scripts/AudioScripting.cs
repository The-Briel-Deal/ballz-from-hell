using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AudioScripting : MonoBehaviour
{
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public int Frame;
    public UnityEvent clip1Finished;
    public UnityEvent clip2Finished;
    public UnityEvent clip3Finished;
    public UnityEvent clip4Finished;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartTalkingCoroutine());
    }

    // Update is called once per frame
/*    void FixedUpdate()
    {   
        if (Frame == 2100)
        {
            gameObject.GetComponent<AudioSource>().clip = clip2;
            gameObject.GetComponent<AudioSource>().Play();
        }
        if (Frame == 2500)
        {
            gameObject.GetComponent<AudioSource>().clip = clip3;
            gameObject.GetComponent<AudioSource>().Play();
        }
        Frame += 1;
    }*/
    IEnumerator StartTalkingCoroutine()
    {
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        yield return new WaitForSeconds(audioSource.clip.length);
        clip1Finished.Invoke();
        audioSource.clip = clip2;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length+4);
        clip2Finished.Invoke();
        audioSource.clip = clip3;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length+ 4);
        clip3Finished.Invoke();
        audioSource.clip = clip4;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length-1);
        print("invoking");
        clip4Finished.Invoke();
    }
}
