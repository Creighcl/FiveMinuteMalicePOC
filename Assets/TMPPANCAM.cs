using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TMPPANCAM : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera vcam;
    [SerializeField] float adjustmentAmount = 0.5f;

    public void MOVE()
    {
        CinemachineTrackedDolly dolly = vcam.GetCinemachineComponent<CinemachineTrackedDolly>();
        float curPos = dolly.m_PathPosition;
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = Mathf.Clamp(curPos + adjustmentAmount, 0f, 3f);
    }
}
