using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class multiplier_tracker : MonoBehaviour
{
    public Text multiplier_text;
    public int MP = 1;
    // Start is called before the first frame update
    void Start()
    {
        multiplier_text.text = "Multiplier: " + MP.ToString();
    }

    // Update is called once per frame
    public void UpdateMultiplier(int change)
    {
        MP = change;
        if (MP > 3)
        {
            MP = 3;
        }
        
        multiplier_text.text = "Multiplier: x" + MP.ToString();
    }
}
