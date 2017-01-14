using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Instrument
{
    public string instrumentName;
    public int level;
    public List<AudioClip> clips = new List<AudioClip>();

    int atClip;

    public AudioClip GetAudioClip()
    {
        return clips[Random.Range(0, clips.Count - 1)];
    }
}
