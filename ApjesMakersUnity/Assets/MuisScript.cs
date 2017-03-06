using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuisScript : MonoBehaviour
{
    RectTransform rect;
    float moveSpeed;
    float rotateSpeed;


	// Use this for initialization
	void Start ()
    {
        rect = GetComponent<RectTransform>();
        moveSpeed = 700;
        rotateSpeed = 80;
	}
	
	// Update is called once per frame
	void Update ()
    {
        rect.anchoredPosition += new Vector2(-moveSpeed * Time.deltaTime, 0);

        if(rect.anchoredPosition.x < -1050)
        {
            rect.eulerAngles += new Vector3(0, 0, rotateSpeed * Time.deltaTime);
        }
        if (rect.anchoredPosition.x < -1400)
        {
            Destroy(gameObject);
        }
    }
}
