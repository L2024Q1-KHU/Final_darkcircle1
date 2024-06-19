using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Event_OVRController_ButtonClass;

public class Event_OVRController_OnClick : MonoBehaviour
{
    public GameObject ActionGameObject;

    Event_OVRController_ButtonClass ButtonClass = new Event_OVRController_ButtonClass();
    public ControllerButtons Button;

    private void Update()
    {
        string TargetButton = Button.ToString();
        if (OVRInput.Get(ButtonClass.Buttons[TargetButton]))
        {
            ActionGameObject.SendMessage("RunAction");
        }
        else
        {
            ActionGameObject.SendMessage("StopAction");
        }
    }
}
