using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Meta.WitAi;

public class Event_OVRController_OnPoint : MonoBehaviour
{
    public GameObject HitGameObject;
    public string HitTag;
    public GameObject ActionGameObject;

    Event_OVRController_Settings Settings;

    private void Start()
    {
        Settings = GetComponent<Event_OVRController_Settings>();
    }

    void Update()
    {
        RaycastHit hit = Settings.GetHit();

        if (HitGameObject != null)
        {
            if(hit.collider != null)
            {
                if (hit.collider.gameObject == HitGameObject)
                {
                    ActionGameObject.SendMessage("RunAction", hit);
                }
            }
            else
            {
                ActionGameObject.SendMessage("StopAction", hit);
            }
        }
        else if (!string.IsNullOrEmpty(HitTag))
        {
            if (hit.collider != null)
            {
                if (hit.collider.tag == HitTag)
                {
                    ActionGameObject.SendMessage("RunAction", hit);
                }
            }
            else
            {
                ActionGameObject.SendMessage("StopAction", hit);
            }

        }
    }
}
