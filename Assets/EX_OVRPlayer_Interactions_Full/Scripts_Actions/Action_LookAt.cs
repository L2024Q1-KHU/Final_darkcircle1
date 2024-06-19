using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_LookAt : MonoBehaviour
{
    public Transform Source;
    public Transform Target;


    // Update is called once per frame
    void Update()
    {
        Source.LookAt(Target);
    }
}
