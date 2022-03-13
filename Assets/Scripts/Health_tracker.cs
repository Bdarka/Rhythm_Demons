using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health_tracker : MonoBehaviour
{
    public Text score_text;
    public int HP = 100;
    public int game_over_level;
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

        if (HP <= 0)
        {
            SceneManager.LoadScene(game_over_level);
        }
        score_text.text = "Health: " + HP.ToString();
    }
}
