using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {
    float speed = 0.2f;
    float jumpspeed = 20.5f;
    float gravity = 20.0f;

    Vector3 moveDirection = Vector3.zero;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CharacterController controller = GetComponent< CharacterController > ();
        if (controller.isGrounded)
        {
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection + new Vector3(speed, 0, 0);

            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y += jumpspeed;
            }
        }
        else
        {
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y += jumpspeed;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime ;
        controller.Move(moveDirection * Time.deltaTime);
	}
}
