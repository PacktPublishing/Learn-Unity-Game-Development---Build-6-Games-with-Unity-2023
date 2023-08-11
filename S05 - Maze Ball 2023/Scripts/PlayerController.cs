using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float rotateSpeed;
    public float maxRotation;

    float mouseX, mouseY;



    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            RotateMaze();

        }
    }



    private void RotateMaze()
    {
        mouseX += Input.GetAxis("Mouse X");
        mouseY += Input.GetAxis("Mouse Y");

        float rotateX = mouseX * rotateSpeed;
        float rotateZ = mouseY * rotateSpeed;

        rotateX = Mathf.Clamp(rotateX, -maxRotation, maxRotation);
        rotateZ = Mathf.Clamp(rotateZ, -maxRotation, maxRotation);

        transform.eulerAngles = new Vector3(rotateZ, transform.rotation.y, -rotateX);

    }




}
