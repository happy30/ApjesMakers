using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OuterCircle : MonoBehaviour {

    public float BPM;
    float msToTarget;

    RectTransform rect;


	// Use this for initialization
	void Start ()
    {
        CalculateMsToTarget();
        rect = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rect.sizeDelta -= new Vector2(1 * msToTarget * Time.deltaTime, 1 * msToTarget * Time.deltaTime);
        if(rect.sizeDelta.x < 100)
        {
            Destroy(transform.parent.gameObject);
        }
	}

    void CalculateMsToTarget()
    {
        msToTarget = 60000 / BPM;
    }
}
