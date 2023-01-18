using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    /**
* This script is made by Brackeys
*
* Author:  Brackeys
* Location: https://youtu.be/_QajrabyTJc
* Accessed: 25/11/2022
*/

    public CharacterController controller; //refrence to character controller

    public float speed = 12f;
    public float gravity = -9.81f;
    Vector3 velocity; //stores current velocity

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; //sets the direction of where the player wants to move

        controller.Move(move * speed * Time.deltaTime); //enables the movement of the player

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime); //enables the player to fall
    }
}
