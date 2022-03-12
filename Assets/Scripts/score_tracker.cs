using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_tracker : MonoBehaviour
{
    public Text score_text;
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        score_text.text = "Score: " + points.ToString();
    }

    // Update is called once per frame
    public void UpdateText(int change)
    {
        points += change;
        score_text.text = "Score: " + points.ToString();
    }
}
