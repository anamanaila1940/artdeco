using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour
{
    /**
* This script is made by Brackeys
*
* Author:  Brackeys
* Location: https://youtu.be/_QajrabyTJc
* Accessed: 25/11/2022
*/
    public float mouseSensitivity = 100f;

    public Transform playerBody; //it is used for the rotation of the body

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //lock the cursor inside the frame
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; //stores the input of the mouse on the X axis
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; //stores the input of the mouse on the Y axis

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);//doesn't allow the player to look behind

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // alows rotation up and down

        playerBody.Rotate(Vector3.up * mouseX); //enables the rotation left and orght
    }
}
