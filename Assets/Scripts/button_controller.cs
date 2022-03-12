using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_controller : MonoBehaviour
{
    private SpriteRenderer SR;
    //public Sprite Default_image;
    //public Sprite Pressed_image;

    public Color pressed_color;
    public Color default_color;

    public KeyCode key_to_use;

    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key_to_use))
        {
            SR.color = pressed_color;

        }

        if (Input.GetKeyUp(key_to_use))
        {
            SR.color = default_color;

        }

    }
}
