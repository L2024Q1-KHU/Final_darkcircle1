using Meta.WitAi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EX_OVRController;
using TMPro;

public class EX_OVRPlayer_OnRaycastHit_Click : MonoBehaviour
{
    public GameObject HitGameObject;
    public string HitTag;
    public GameObject ActionGameObject;

    EX_OVRController MyController = new EX_OVRController();
    public ControllerButtons Button;
    
    EX_OVRPlayer_Raycast_Settings Settings;

    public TMP_Text Text;

    private void Start()
    {
        Settings = GetComponent<EX_OVRPlayer_Raycast_Settings>();
    }

    private void Update()
    {
        RaycastHit hit = Settings.GetHit();
        string TargetButton = Button.ToString();
        if (HitGameObject != null)
        {
            if (hit.collider != null && hit.collider.gameObject == HitGameObject)
            {
                if (OVRInput.Get(MyController.Buttons[TargetButton]))
                {
                    Text.text = "DebugInfo:Target Button = " + TargetButton;
                    Text.transform.position = hit.point;
                    ActionGameObject.SendMessage("RunAction", hit);
                }
            }
        }
        else if (!string.IsNullOrEmpty(HitTag))
        {
            if (hit.collider != null && hit.collider.tag == HitTag)
            {
                if (OVRInput.Get(MyController.Buttons[TargetButton]))
                {
                    Text.text = "DebugInfo:Target Button = " + TargetButton;
                    Text.transform.position = hit.point;
                    ActionGameObject.SendMessage("RunAction", hit);
                }
            }
        }
    }
}
