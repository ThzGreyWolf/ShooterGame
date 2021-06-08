using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float m_speed;
    [SerializeField] private float m_deadZone;
    private Transform m_transform;
    private Rigidbody m_rb;
    void Start() {
        m_transform = GetComponent<Transform>();
        m_rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        // Stopwatch stopwatch = new Stopwatch();
        // stopwatch.Start();
 
        // m_rb.AddForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0 , speed * Input.GetAxis("Vertical")));
        // m_transform.Translate((m_transform.forward * (speed * Input.GetAxis("Vertical"))) * Time.deltaTime);
        // m_transform.Translate((m_transform.right * (speed * Input.GetAxis("Horizontal"))) * Time.deltaTime);

        // stopwatch.Stop();
        // UnityEngine.Debug.Log(stopwatch.ElapsedMilliseconds);
        LookAtMouse();
        // m_transform.Translate(((m_transform.forward * (speed * Input.GetAxis("Vertical"))) * Time.deltaTime) + 
        //                         ((m_transform.right * (speed * Input.GetAxis("Horizontal"))) * Time.deltaTime));
        m_transform.Translate(((Vector3.forward * (m_speed * Input.GetAxis("Vertical"))) * Time.deltaTime) + 
                                ((Vector3.right * (m_speed * Input.GetAxis("Horizontal"))) * Time.deltaTime));
    }

    private void LookAtMouse() {
        RaycastHit hit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit)) {
            if(Vector3.Distance(m_transform.position, hit.point) > m_deadZone) {
                m_transform.LookAt(hit.point);
            }
        }
    }

    private void Crouch() {
        
    }
}