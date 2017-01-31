using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    

    //header
    public Text levelText;
    public Slider EXPGauge;

    //PlayerArea
    public Image background;
    public Sprite[] backgrounds;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeLevel(int level, int exp, int expNeeded)
    {
        //levelText.text = "Lv: " + level;
        //EXPGauge.value = (float)exp / (float)expNeeded;
    }

    public void ChangeBackground(int bg)
    {
        background.sprite = backgrounds[bg];
    }
}
