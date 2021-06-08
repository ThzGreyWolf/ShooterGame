using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {
    public Transform target;
    private Transform m_mainCam;
    private Vector3 m_offset;

    void Start() {
        m_mainCam = Camera.main.transform;
        m_offset = target.position - m_mainCam.position;
    }

    void LateUpdate() {
        float targetAngle = target.eulerAngles.y;
        Quaternion rot = Quaternion.Euler(0, targetAngle, 0);

        m_mainCam.position = target.position - (rot * m_offset);
        m_mainCam.LookAt(target);
    }
}
