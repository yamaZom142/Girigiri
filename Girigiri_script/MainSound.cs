using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSound : MonoBehaviour {
    public AudioClip audioClip1;
    private AudioSource audioSource;
    // Use this for initialization
    void Start () {

        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
        audioSource.Play();
        audioSource.volume = 0.05f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
