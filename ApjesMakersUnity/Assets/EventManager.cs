﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public GameObject druppel;
    public RectTransform druppelSpawner;
    public Transform druppelSpawnerTransform;

    public GameObject muis;
    public Transform muisSpawnerTransform;

    public float interval = 5;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > interval)
        {
            DoRandomEvent();
        }
    }
        
	void DoRandomEvent()
    {
        if(Random.value > 0.5f)
        {
            SpawnDruppel();
        }
        else
        {
            SpawnMuis();
        }     
        SetInterval();
    }

    void SetInterval()
    {
        timer = 0;
        interval = Random.Range(5, 10);
    }

    void SpawnMuis()
    {
        GameObject spawnedMuis;
        spawnedMuis = (GameObject)Instantiate(muis);
        spawnedMuis.transform.SetParent(muisSpawnerTransform);
        spawnedMuis.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        spawnedMuis.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
    }

    void SpawnDruppel()
    {
        GameObject spawnedDruppel;
        spawnedDruppel = (GameObject)Instantiate(druppel);
        spawnedDruppel.transform.SetParent(druppelSpawnerTransform);
        spawnedDruppel.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        spawnedDruppel.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
    }
}
