using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    public float rotateSpeed;
    public float yBucket;
    public int coinValue;


    float fallSpeed;

    StatsManager stats;
    UIManager ui;

	// Use this for initialization
	void Start ()
    {
        stats = GameObject.Find("GameManager").GetComponent<StatsManager>();
        ui = GameObject.Find("Canvas").GetComponent<UIManager>();
        fallSpeed = .5f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<RectTransform>().Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));

        fallSpeed += Time.deltaTime * 4;

        GetComponent<RectTransform>().Translate(new Vector3(0, -fallSpeed * Time.deltaTime, 0));

        if(GetComponent<RectTransform>().anchoredPosition.y < yBucket)
        {
            GameObject.Find("SFX").GetComponent<PlaySFX>().PlaySound(GameObject.Find("SFX").GetComponent<PlaySFX>().coin);
            stats.coins += coinValue;
            ui.ChangeCoins(stats.coins);
            Destroy(gameObject);
        }
	}
}
