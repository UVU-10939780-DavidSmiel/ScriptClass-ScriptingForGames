using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int value;
    
    public void UpdateValue(int amount)
    {
        value += amount;
    }
    // Update is called once per frame
    public void SetValue(int amount)
    {
        value = amount;
    }
}
