using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv1_PropSpawner : MonoBehaviour {

    public List<GameObject> props = new List<GameObject>();

    float spawnTime;
    public float minSpawnTime;
    public float maxSpawnTime;

    GameObject spawnedProp;

    void Update()
    {
        if(!IsInvoking("SpawnProp"))
        {
            spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            Invoke("SpawnProp", spawnTime);
        }
    }

    void SpawnProp()
    {
        GameObject propToSpawn = props[Random.Range(0, props.Count - 1)];
        int yOffset = Random.Range(-40, 40);

        spawnedProp = (GameObject)Instantiate(propToSpawn);
        spawnedProp.transform.SetParent(transform);
        spawnedProp.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        spawnedProp.GetComponent<RectTransform>().localPosition = new Vector3(0, yOffset, 0);
    }

}
