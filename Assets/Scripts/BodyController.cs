using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyController : MonoBehaviour {
    [SerializeField] private Transform m_head;
    [SerializeField] private float m_lookDistance;
    private Animator m_animator;

    void Start() {
        m_animator = GetComponent<Animator>();
    }

    void FixedUpdate() {
        float xInput = Input.GetAxis("Horizontal"), yInput = Input.GetAxis("Vertical");
        LookAround();
        m_animator.SetFloat("WalkDir", yInput);
        m_animator.SetFloat("StrafeDir", xInput);

        if(xInput != 0f || yInput != 0f) {
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, m_head.eulerAngles.y, 0), Time.deltaTime);
        }
    }

    private void LookAround() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, m_lookDistance)){
            m_head.LookAt(hit.point);
        }
    }
}