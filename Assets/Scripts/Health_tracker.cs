using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_tracker : MonoBehaviour
{
    public Text score_text;
    public int HP = 100;
    // Start is called before the first frame update
    void Start()
    {
        score_text.text = "Health: " + HP.ToString();
    }

    // Update is called once per frame
    public void UpdateHealth(int change)
    {
        HP += change;
        if (HP > 100)
        {
            HP = 100;
        }
        else if (HP < 0)
        {
            HP = 0;
        }
        score_text.text = "Score: " + HP.ToString();
    }
}
