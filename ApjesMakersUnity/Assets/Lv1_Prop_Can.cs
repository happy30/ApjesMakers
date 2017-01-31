using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lv1_Prop_Can : MonoBehaviour {

    float speed;
    public float minSpeed;
    public float maxSpeed;

    float respawnTime;
    public float minRespawnTime;
    public float maxRespawnTime;

    RectTransform rect;
    bool hasInvoked;

	// Use this for initialization
	void Start ()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        respawnTime = Random.Range(minRespawnTime, maxRespawnTime);
        rect = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rect.anchoredPosition += new Vector2(speed * Time.deltaTime, 0);
        if(rect.anchoredPosition.x > 1400)
        {
            Destroy(gameObject);
        }
	}
}
