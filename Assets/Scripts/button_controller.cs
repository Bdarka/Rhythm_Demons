using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_controller : MonoBehaviour
{
    private SpriteRenderer SR;
    public Color pressed_color;
    public Color default_color;
    private score_tracker ST;
    private Health_tracker HT;
    

    public KeyCode Attack_Key;
    public KeyCode Parry_Key;

    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponentInParent<SpriteRenderer>();
        ST = GameObject.FindGameObjectWithTag("ScoreTracker").transform.GetComponent<score_tracker>();
        HT = GameObject.FindGameObjectWithTag("HealthTracker").transform.GetComponent<Health_tracker>();
    }

    // Update is called once per frame
    void Update()
    {
        input_check(Parry_Key, "parry");
        input_check(Attack_Key, "attack");

        input_release(Parry_Key);
        input_release(Attack_Key);

    }

    void input_check(KeyCode key, string correct_tag)
    {
        if (Input.GetKeyDown(key))
        {
            SR.color = pressed_color;
            RaycastHit CheckRay;
            if (Physics.SphereCast(transform.position, 0.5f, -transform.forward, out CheckRay))
            {
                if (CheckRay.transform.CompareTag(correct_tag))
                {
                    CheckRay.transform.gameObject.SetActive(false);
                    Debug.Log("Hit");
                    ST.UpdateText(1);
                    HT.UpdateHealth(5);
                }
                else
                {
                    CheckRay.transform.gameObject.SetActive(false);
                    Debug.Log("Miss"); 
                    ST.UpdateText(-1);
                    HT.UpdateHealth(-10);
                }
            }
            else
            {
                Debug.Log("Miss");
                ST.UpdateText(-1);
                HT.UpdateHealth(-5);
            }
        }
    }

    void input_release(KeyCode key)
    {
        if (Input.GetKeyUp(key))
        {
            SR.color = default_color;
        }
    }
}
