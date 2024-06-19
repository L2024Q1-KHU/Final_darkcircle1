using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Outline : MonoBehaviour
{
    public GameObject GameObjectWithOutline;
    Outline outline;
    public bool outlineAtStart = false;

    void Start()
    {
        outline = GameObjectWithOutline.GetComponent<Outline>();
        if (outlineAtStart)
        {
            outline.enabled = true;
        }
    }

    public void RunAction(RaycastHit hit)
    {
        outline.enabled = true;
    }

    public void StopAction(RaycastHit hit)
    {
        outline.enabled = false;
    }
}
