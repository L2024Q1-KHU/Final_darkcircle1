using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Event_OVRController_ButtonClass;

public class Event_OVRController_OnPointAndClick : MonoBehaviour
{
    public GameObject HitGameObject;
    public string HitTag;
    public GameObject ActionGameObject;

    Event_OVRController_ButtonClass ButtonClass = new Event_OVRController_ButtonClass();
    public ControllerButtons Button;

    Event_OVRController_Settings Settings;

    //public TMP_Text Text;

    private void Start()
    {
        Settings = GetComponent<Event_OVRController_Settings>();
    }

    private void Update()
    {
        RaycastHit hit = Settings.GetHit();
        string TargetButton = Button.ToString();
        if (HitGameObject != null)
        {
            //if (hit.collider != null && hit.collider.gameObject == HitGameObject)
            //{
            //    if (OVRInput.Get(Buttons.Buttons[TargetButton]))
            //    {
            //        //Text.text = "DebugInfo:Target Button = " + TargetButton;
            //        //Text.transform.position = hit.point;
            //        ActionGameObject.SendMessage("RunAction", hit);
            //    }
            //}
            if (hit.collider != null)
            {
                if (hit.collider.gameObject == HitGameObject)
                {
                    if (OVRInput.Get(ButtonClass.Buttons[TargetButton]))
                    {
                        ActionGameObject.SendMessage("RunAction", hit);
                    }                    
                }
            }
            else
            {
                ActionGameObject.SendMessage("StopAction", hit);
            }
        }
        else if (!string.IsNullOrEmpty(HitTag))
        {
            //if (hit.collider != null && hit.collider.tag == HitTag)
            //{
            //    if (OVRInput.Get(Buttons.Buttons[TargetButton]))
            //    {
            //        //Text.text = "DebugInfo:Target Button = " + TargetButton;
            //        //Text.transform.position = hit.point;
            //        ActionGameObject.SendMessage("RunAction", hit);
            //    }
            //}
            if (hit.collider != null)
            {
                if (hit.collider.tag == HitTag)
                {
                    if (OVRInput.Get(ButtonClass.Buttons[TargetButton]))
                    {
                        ActionGameObject.SendMessage("RunAction", hit);
                    }
                }
            }
            else
            {
                ActionGameObject.SendMessage("StopAction", hit);
            }
        }
    }
}
