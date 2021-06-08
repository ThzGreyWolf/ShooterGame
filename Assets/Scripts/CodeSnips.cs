// Head & Neck turn Code from BodyController

    // int screenWidth = Screen.width;
    // float mouseXPos = Mathf.Clamp(Input.mousePosition.x - screenWidth, -(screenWidth/2), screenWidth/2);
    // Debug.Log(mouseXPos);

    // float horiInput = Input.GetAxis("Mouse X");
    // // float horiInput = Input.GetAxis("Horizontal");
    // float vertInput = Input.GetAxis("Vertical");
    // if(horiInput != 0) {
    //     float headYRot = m_head.localEulerAngles.y > (m_maxHeadYRot + 10) ?  (m_head.localEulerAngles.y - 360) : m_head.localEulerAngles.y;
    //     float neckYRot = m_neck.localEulerAngles.y > (m_maxHeadYRot + 10) ?  (m_neck.localEulerAngles.y - 360) : m_neck.localEulerAngles.y;

    //     if((horiInput > 0 && headYRot >= m_maxHeadYRot) || (horiInput < 0 && headYRot <= -m_maxHeadYRot)) {
    //         TurnOnY(m_neck, m_maxNeckYRot, horiInput * m_turnSpeed);
    //     } else {
    //         TurnOnY(m_head, m_maxHeadYRot, horiInput * m_turnSpeed);
    //         if((horiInput > 0 && neckYRot < 0) || (horiInput < 0 && neckYRot > 0)) {
    //             TurnOnY(m_neck, m_maxNeckYRot, horiInput * m_turnSpeed);
    //         }
    //     }
    // }

    // private void TurnOnY(Transform part, float maxTurn, float turnSpeed) {
    //     float rotY = part.localEulerAngles.y > (maxTurn + 10) ?  (part.localEulerAngles.y - 360) : part.localEulerAngles.y;
    //     rotY = Mathf.Clamp((rotY + turnSpeed), -maxTurn, maxTurn);

    //     part.localEulerAngles = new Vector3(part.localEulerAngles.x, rotY < 0 ?  rotY + 360 : rotY, part.localEulerAngles.z);
    // }