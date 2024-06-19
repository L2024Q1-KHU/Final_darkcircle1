using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EX_OVRPlayer_Raycast_Settings : MonoBehaviour
{
    //public Transform OVRPlayerController;
    public Transform OVRController;
    public Transform HitPointDisplayer;
    public TMP_Text HitInfo;

    LineRenderer LineRenderer;
    public Material RayMatDef, RayMatHit;
    float lineRendererAdjust = 0.03f;
    public int rayLength = 100;

    public bool showLine = true;
    public bool showHitPoint = true;
    public bool showHitInfo = true;

    RaycastHit hit;

    void Start()
    {
        LineRenderer = GetComponent<LineRenderer>();
        LineRenderer.startWidth = 0.01f;
        LineRenderer.endWidth = 0.01f;
        LineRenderer.material = RayMatDef;
    }

    void Update()
    {
        Physics.Raycast(OVRController.position, OVRController.forward, out hit, rayLength);

        if (showLine)
        {
            ShowLine(hit);
        }
        if (showHitPoint && HitPointDisplayer != null)
        {
            ShowHitPoint(hit);
        }
        if (showHitInfo && HitInfo != null)
        {
            ShowHitInfo(hit);
        }
    }

    void ShowLine(RaycastHit hit)
    {
        Vector3 LintStartPoint = OVRController.transform.position + OVRController.transform.forward * lineRendererAdjust;
        Vector3 LintEndPoint = OVRController.transform.position + OVRController.transform.forward * rayLength;
        LineRenderer.material = RayMatDef;

        if (hit.collider != null)
        {
            LineRenderer.material = RayMatHit;
            LintEndPoint = hit.point;

            HitPointDisplayer.gameObject.SetActive(true);
            HitPointDisplayer.position = LintEndPoint;
        }

        LineRenderer.SetPosition(0, LintStartPoint);
        LineRenderer.SetPosition(1, LintEndPoint);
    }

    void ShowHitPoint(RaycastHit hit)
    {
        HitPointDisplayer.gameObject.SetActive(false);
        if (hit.collider != null)
        {
            HitPointDisplayer.gameObject.SetActive(true);
            HitPointDisplayer.position = hit.point;
            HitPointDisplayer.up = hit.normal;
        }
    }

    void ShowHitInfo(RaycastHit hit)
    {
        HitInfo.text = "";
        if (hit.collider != null)
        {
            HitInfo.text = hit.collider.name;
            HitInfo.transform.position = hit.point;
        }
    }

    public RaycastHit GetHit()
    {
        return hit;
    }
}
