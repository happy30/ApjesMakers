using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySFX : MonoBehaviour {

    AudioSource _sound;
    public AudioClip[] druppel;
    public AudioClip muis;
    public AudioClip[] coin;

    public AudioClip bus;

	// Use this for initialization
	void Start ()
    {
        _sound = GetComponent<AudioSource>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlaySound(AudioClip[] clip)
    {
        _sound.PlayOneShot(clip[Random.Range(0, clip.Length -1)]);
    }

    public void PlaySound(AudioClip clip)
    {
        _sound.PlayOneShot(clip);
    }
}
