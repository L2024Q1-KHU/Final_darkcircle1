using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Action_DebugInfo : MonoBehaviour
{
    public TMP_Text DebugInfo;

    public void RunAction(RaycastHit hit)
    {
        DebugInfo.text = $"DebugInfo: {hit.collider.name}";
        DebugInfo.transform.position = hit.point;
    }

    public void StopAction()
    {
        DebugInfo.text = $"DebugInfo: NONE";
    }
}
