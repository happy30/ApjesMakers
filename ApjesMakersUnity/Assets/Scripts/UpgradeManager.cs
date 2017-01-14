using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour {

    UIManager ui;


    public int backgroundProgress;


    void Awake()
    {
        ui = GameObject.Find("Canvas").GetComponent<UIManager>();
    }
	// Use this for initialization
	void Start ()
    {
        ui.ChangeBackground(backgroundProgress);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
