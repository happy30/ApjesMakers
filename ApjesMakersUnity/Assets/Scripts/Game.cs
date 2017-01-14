using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public InstrumentManager IM;
    public UIManager UI;
    public StatsManager stats;
    public AudioSource sound;

    public Animator anim;


	public void OnTap()
    {
        sound.PlayOneShot(IM.instruments[0].GetAudioClip());
        GetScore();
        UI.ChangeLevel(stats.playerLevel, stats.exp, stats.GetEXPNeededForNextLevel());

        if(anim.GetBool("TapLeft"))
        {
            anim.SetBool("TapLeft", false);
        }
        else
        {
            anim.SetBool("TapLeft", true);
        }
    }

    public void GetScore()
    {
        stats.exp += stats.expPerTap;
        if(stats.exp > stats.GetEXPNeededForNextLevel())
        {
            stats.playerLevel++;
            stats.exp = 0;
        }
    }
}
