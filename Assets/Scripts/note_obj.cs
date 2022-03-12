using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note_obj : MonoBehaviour
{
    public bool can_be_pressed = false;
    public KeyCode key_to_press;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (can_be_pressed && Input.GetKeyDown(key_to_press))
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "activator")
        {
            can_be_pressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "activator")
        {
            can_be_pressed = false;
        }
    }
}
