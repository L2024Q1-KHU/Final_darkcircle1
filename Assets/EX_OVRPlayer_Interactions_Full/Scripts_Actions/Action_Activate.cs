using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class Action_Activate : MonoBehaviour
{
    public GameObject GameObjectToActivate;
    public bool startActive;
    //public TMP_Text Text;    

    private void Start()
    {
        if(startActive)
        {
            GameObjectToActivate.SetActive(true);
        }
    }

    public void RunAction(RaycastHit hit)
    {
        GameObjectToActivate.SetActive(true);
        //Text.text = "Run";
    }

    public void StopAction(RaycastHit hit)
    {
        //Text.text = "Stop";
        GameObjectToActivate.SetActive(false);
    }
}
