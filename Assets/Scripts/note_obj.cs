using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note_obj : MonoBehaviour
{

    public Animator Enemy_animator;
    public string trigger_name;
    // Start is called before the first frame update
    void Start()
    {
        Enemy_animator = GameObject.FindGameObjectWithTag("enemy").GetComponent<Animator>();
    }

    public void OnDisable()
    {
        Enemy_animator.SetTrigger(trigger_name);
    }

}
