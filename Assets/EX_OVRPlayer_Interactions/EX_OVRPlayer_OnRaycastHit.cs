using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Meta.WitAi;

public class EX_OVRPlayer_OnRaycastHit : MonoBehaviour
{
    public GameObject HitGameObject;
    public string HitTag;
    public GameObject ActionGameObject;

    EX_OVRPlayer_Raycast_Settings Settings;

    private void Start()
    {
        Settings = GetComponent<EX_OVRPlayer_Raycast_Settings>();
    }

    void Update()
    {
        RaycastHit hit = Settings.GetHit();

        if (HitGameObject != null)
        {
            if (hit.collider.gameObject == HitGameObject && hit.collider != null)
            {
                ActionGameObject.SendMessage("RunAction", hit);
            }
        }
        else if (!string.IsNullOrEmpty(HitTag))
        {
            if (hit.collider != null && hit.collider.tag == HitTag)
            {
                ActionGameObject.SendMessage("RunAction", hit);
            }
        }
    }
}
