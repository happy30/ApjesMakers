using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DruppelBehaviour : MonoBehaviour
{
    RectTransform rect;
    float fallSpeed;



	// Use this for initialization
	void Start ()
    {
        rect = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rect.anchoredPosition -= new Vector2(0, fallSpeed);
        if(fallSpeed < 100)
        {
            fallSpeed += 40 * Time.deltaTime;
        }

        if(rect.anchoredPosition.y < -1400)
        {
            GameObject.Find("SFX").GetComponent<PlaySFX>().PlaySound(GameObject.Find("SFX").GetComponent<PlaySFX>().druppel);
            Destroy(gameObject);
        }
        
	}
}
