using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    //mouse sensitivity
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;

    //maakt de muis onzichtbaar
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    //laat de speler rond kijken door met de muis te bewegen
    void Update()
    {
        
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
