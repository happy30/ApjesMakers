using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusPlaySound : MonoBehaviour
{

	public void PlaySound()
    {
        GameObject.Find("SFX").GetComponent<PlaySFX>().PlaySound(GameObject.Find("SFX").GetComponent<PlaySFX>().bus);
    }
}
