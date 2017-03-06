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

    public float tapTimer;
    public int combo;


    void Update()
    {
        tapTimer += Time.deltaTime;
    }


    public void OnTap()
    {
        if(tapTimer < 0.6f && tapTimer > 0.4f)
        {
            combo++;
        }
        else
        {
            combo = 1;
            
        }
        tapTimer = 0;

        sound.PlayOneShot(IM.instruments[0].GetAudioClip());
        GetScore();
        UI.ChangeComboText(combo);

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
        stats.notes += 1 + Mathf.RoundToInt(stats.notesPerTap * 1.2f * (combo -1));
        UI.changeNotes(stats.notes);
    }
}
