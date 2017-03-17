using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv1_PropSpawner : MonoBehaviour {

    public List<GameObject> props = new List<GameObject>();

    public GameObject coin;
    public GameObject person;

    float spawnTime;
    public float minSpawnTime;
    public float maxSpawnTime;

    public Transform coinSpawner;
    public Transform peopleSpawner;

    GameObject spawnedProp;
    GameObject spawnedCoin;
    GameObject spawnedPerson;

    void Update()
    {
        if(!IsInvoking("SpawnProp"))
        {
            spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            Invoke("SpawnProp", spawnTime);
        }

        if (!IsInvoking("SpawnPerson"))
        {
            spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            Invoke("SpawnPerson", spawnTime);
        }
    }

    void SpawnProp()
    {
        GameObject propToSpawn = props[Random.Range(0, props.Count)];
        int yOffset = Random.Range(-40, 40);

        spawnedProp = (GameObject)Instantiate(propToSpawn);
        spawnedProp.transform.SetParent(transform);
        spawnedProp.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        spawnedProp.GetComponent<RectTransform>().localPosition = new Vector3(0, yOffset, 0);
    }

    public void SpawnCoin()
    {
        spawnedCoin = (GameObject)Instantiate(coin);
        spawnedCoin.transform.SetParent(coinSpawner);
        spawnedCoin.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        spawnedCoin.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    }

    void SpawnPerson()
    {
        spawnedPerson = (GameObject)Instantiate(person);
        spawnedPerson.transform.SetParent(peopleSpawner);
        spawnedPerson.GetComponent<RectTransform>().localScale = new Vector3(2, 2, 2);
        spawnedPerson.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    }

}
