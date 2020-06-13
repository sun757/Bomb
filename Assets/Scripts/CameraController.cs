using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float camSens = 0.10f;
    private Vector3 lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)

    private void Update()
    {
        // mouse movement
        Transform shpereTransform = this.transform.parent;

        lastMouse = Input.mousePosition - lastMouse;
        lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);
        lastMouse = new Vector3(shpereTransform.eulerAngles.x + lastMouse.x, shpereTransform.eulerAngles.y + lastMouse.y, 0);
        shpereTransform.eulerAngles = lastMouse;
        //Debug.Log(lastMouse);
        lastMouse = Input.mousePosition;
        // position
        //transform.localPosition = new Vector3(sphere.localPosition.x, 10, sphere.localPosition.z);
    }
    private Vector3 GetBaseInput()
    { //returns the basic values, if it's 0 than it's not active.
        Vector3 p_Velocity = new Vector3();
        if (Input.GetKey(KeyCode.W))
        {
            p_Velocity += new Vector3(0, 0, 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            p_Velocity += new Vector3(0, 0, -0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            p_Velocity += new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            p_Velocity += new Vector3(0.1f, 0, 0);
        }
        return p_Velocity;
    }
}
