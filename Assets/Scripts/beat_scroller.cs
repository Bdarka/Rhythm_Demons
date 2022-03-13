using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beat_scroller : MonoBehaviour
{
    public float beat_tempo;

    public bool has_started;
    // Start is called before the first frame update
    void Start()
    {
        beat_tempo /= 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!has_started)
        {
            
        }
        else
        {
            transform.position -= new Vector3(beat_tempo * Time.deltaTime, 0f, 0f);
        }
    }
}
