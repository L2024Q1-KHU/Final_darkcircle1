using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Audio : MonoBehaviour
{
    public GameObject GameObjectWithAudio;
    AudioSource Audio;

    void Start()
    {
        Audio = GameObjectWithAudio.GetComponent<AudioSource>();
    }

    public void RunAction(RaycastHit hit)
    {
        if (!Audio.isPlaying)
        {
            Audio.Play();
        }
    }

    public void StopAction(RaycastHit hit)
    {
        Audio.Stop();
    }
}
