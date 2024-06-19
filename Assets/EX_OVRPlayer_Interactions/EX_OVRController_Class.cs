using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX_OVRController
{
    public enum ControllerButtons
    {
        LThumbStick,
        LIndexTrigger,
        LHandTrigger,
        X,
        Y,
        Start,
        RThumbStick,
        RIndexTrigger,
        RHandTrigger,
        A,
        B
    };

    public ControllerButtons Button;

    public Dictionary<string, OVRInput.RawButton> Buttons = new Dictionary<string, OVRInput.RawButton>
    {
        {"Start", OVRInput.RawButton.Start},
        {"LThumbStick", OVRInput.RawButton.LThumbstick},
        {"LIndexTrigger", OVRInput.RawButton.LIndexTrigger},
        {"LHandTrigger", OVRInput.RawButton.LHandTrigger},
        {"X", OVRInput.RawButton.X},
        {"Y", OVRInput.RawButton.Y},
        {"RThumbStick", OVRInput.RawButton.RThumbstick},
        {"RIndexTrigger", OVRInput.RawButton.RIndexTrigger},
        {"RHandTrigger", OVRInput.RawButton.RHandTrigger},
        {"A", OVRInput.RawButton.A},
        {"B", OVRInput.RawButton.B}
    };

    //Buttons.Add("LThumbStick", OVRInput.RawButton.LThumbstick);
    //Buttons.Add("LIndexTrigger", OVRInput.RawButton.LIndexTrigger);
    //Buttons.Add("LHandTrigger", OVRInput.RawButton.LHandTrigger);
    //Buttons.Add("X", OVRInput.RawButton.X);
    //Buttons.Add("Y", OVRInput.RawButton.Y);
    //Buttons.Add("Start", OVRInput.RawButton.Start);
    //Buttons.Add("RThumbStick", OVRInput.RawButton.RThumbstick);
    //Buttons.Add("RIndexTrigger", OVRInput.RawButton.RIndexTrigger);
    //Buttons.Add("RHandTrigger", OVRInput.RawButton.RHandTrigger);
    //Buttons.Add("A", OVRInput.RawButton.A);
    //Buttons.Add("B", OVRInput.RawButton.B);    
}
