using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindMillScript : MonoBehaviour
{
    public float rotateSpeed;



    // Update is called once per frame
    void Update()
    {
        GetComponent<RectTransform>().Rotate(new Vector3(0, 0, rotateSpeed * Time.deltaTime));
    }
}
