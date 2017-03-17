using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {



    //header
    public Text notesText;
    public Text coinsText;
    public Slider EXPGauge;
    public Text comboText;

    //PlayerArea
    public Image background;
    public Sprite[] backgrounds;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeNotes(int notes)
    {
        notesText.text = notes + " notes";
    }

    public void ChangeCoins(int coins)
    {
        coinsText.text = coins + " coins";
    }

    public void ChangeBackground(int bg)
    {
        background.sprite = backgrounds[bg];
    }

    public void ChangeComboText(int combo)
    {
        if(combo > 1)
        {
            comboText.text = "Combo: " + combo;
        }
        else
        {
            comboText.text = "";
        }
        
    }
}
