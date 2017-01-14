using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    public int expPerTap;
    public int exp;
    public int expCurrentLevel;

    public int playerLevel;
    public int expNeeded;

    public int GetEXPNeededForNextLevel()
    {
        expNeeded = Mathf.RoundToInt((float)playerLevel * 1.4f + (10f * playerLevel));
        return expNeeded;
    }
}
