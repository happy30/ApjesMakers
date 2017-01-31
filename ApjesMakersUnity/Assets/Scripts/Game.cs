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

    public GameObject circle;
    GameObject spawnedCircle;
    public Transform backgroundObject;

    public float 



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

        if(spawnedCircle != null)
        {
            Destroy(spawnedCircle.gameObject);
        }

        spawnedCircle = (GameObject)Instantiate(circle);
        spawnedCircle.transform.SetParent(backgroundObject);
        spawnedCircle.GetComponent<RectTransform>().position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        spawnedCircle.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);
        spawnedCircle.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);


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
