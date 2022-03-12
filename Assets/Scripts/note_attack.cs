using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note_attack : MonoBehaviour
{
    public bool can_be_pressed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (can_be_pressed && Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
            Destroy(this.gameObject);
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
