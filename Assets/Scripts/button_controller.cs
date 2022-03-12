using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_controller : MonoBehaviour
{
    private SpriteRenderer SR;
    //public Sprite Default_image;
    //public Sprite Pressed_image;

    

    public KeyCode Attack_Key;
    public KeyCode Parry_Key;

    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        SR = GetComponent<SpriteRenderer>();
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
            RaycastHit CheckRay;
            if (Physics.SphereCast(transform.position, 0.5f, -transform.forward, out CheckRay))
            {
                if (CheckRay.transform.CompareTag(correct_tag))
                {
                    CheckRay.transform.gameObject.SetActive(false);
                    Debug.Log("Hit");
                }
                else
                {
                    CheckRay.transform.gameObject.SetActive(false);
                    Debug.Log("Miss");
                }
            }
        }
    }

    void input_release(KeyCode key)
    {
        if (Input.GetKeyUp(key))
        {
        }
    }
}
