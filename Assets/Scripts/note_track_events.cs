using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note_track_events : MonoBehaviour
{
    public beat_scroller BS;
    void Start()
    {
        BS = GameObject.FindGameObjectWithTag("BeatTracker").GetComponent<beat_scroller>();
    }

    // Update is called once per frame
    void StartBeats()
    {
        BS.has_started = true;
    }
}
