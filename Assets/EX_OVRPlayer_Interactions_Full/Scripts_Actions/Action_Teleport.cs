using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Teleport : MonoBehaviour
{
    public GameObject Player;
    public Transform TeleportTarget;
    Vector3 TeleportPoint;
    bool isTeleporting;

    private void Update()
    {
        if (isTeleporting)
        {
            var player = Player.GetComponentInChildren<OVRPlayerController>();
            player.enabled = false;
            Player.transform.position = Vector3.Lerp(Player.transform.position, TeleportPoint, 0.1f);
            player.enabled = true;

            float dist = Vector3.Distance(Player.transform.position, TeleportPoint);
            if (dist < 0.1f)
            {
                isTeleporting = false;
            }
        }
    }

    public void RunAction(RaycastHit hit)
    {
        isTeleporting = true;
        TeleportPoint = hit.point;
    }
}
