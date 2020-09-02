using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour {
    
    [SerializeField] float rotationSpeed = 1f;
    [SerializeField] Transform target, player; //assign the object of the target and the player (main camera is the child of target object)

    float mouseX, mouseY; // assign variable for mouse input rotation

    void Start() {
        Cursor.visible = false; // to hide the cursor
        Cursor.lockState = CursorLockMode.Locked; //lock the cursor or mouse
    }

    void LateUpdate() {
        CamControl();
    }

    void CamControl() {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed; //initiate the mouse X axis (left and right)
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed; // initiate the mouse Y axis (up and down)
        mouseY = Mathf.Clamp(mouseY, -35, 60); // clamp the up and down rotation so it'll not rotate beyond up and down

        transform.LookAt(target); //ritate the target object (parent of main camera)

        if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("d") || Input.GetKey("a")) { //if player move then rotate both camera and player (so you won't see the face of the character)
            target.rotation = Quaternion.Euler(mouseY, mouseX, 0); //rotate the camera (x, y, z) x = up and down, y = left and right
            player.rotation = Quaternion.Euler(0, mouseX, 0); //rotate the player left and right alongside with camera horizontal rotation
        } else { //if player don't move then only rotate the camera (so you be able to see the face of the player)
            target.rotation = Quaternion.Euler(mouseY, mouseX, 0); // rotate only the camera (target)
        }
    }
}
