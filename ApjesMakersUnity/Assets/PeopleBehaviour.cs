using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleBehaviour : MonoBehaviour {

    RectTransform rect;
    float speed;

    bool rotated;

    bool hasThrownMoney;

    Lv1_PropSpawner props;

	// Use this for initialization
	void Start () {
        props = GameObject.Find("Props").GetComponent<Lv1_PropSpawner>();
        rect = GetComponent<RectTransform>();
        speed = 140f;

        if(Random.value > 0.5f)
        {
            rotated = true;
            rect.localEulerAngles = new Vector3(0, 180, 0);
            speed = -140f;
            rect.anchoredPosition = new Vector2(1749, rect.anchoredPosition.y);
        }
	}

    void Update()
    {
        rect.anchoredPosition += new Vector2(speed * Time.deltaTime, 0);
        if (rect.anchoredPosition.x > 1750)
        {
            Destroy(gameObject);
        }

        if(rotated && !hasThrownMoney)
        {
            if(rect.anchoredPosition.x < 780)
            {
                if(Random.value > 0.5f)
                {
                    props.SpawnCoin();
                }
                hasThrownMoney = true;
            }
        }
        else if(!hasThrownMoney)
        {
            if (rect.anchoredPosition.x > 780)
            {
                if (Random.value > 0.5f)
                {
                    props.SpawnCoin();

                }
                hasThrownMoney = true;
            }
        }
    }
}
