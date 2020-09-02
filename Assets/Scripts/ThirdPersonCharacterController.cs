using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour {

    [SerializeField] float speed;

    // Update is called once per frame
    void Update() {
        PlayerMovement();
    }

    void PlayerMovement (){
        float horInput = Input.GetAxis("Horizontal"); // get the horizontal input (A & D)
        float verInput = Input.GetAxis("Vertical"); // get the vertical input (W and S)
        Vector3 playerMovement = new Vector3(horInput, 0f, verInput) * speed * Time.deltaTime; //create movement vector
        transform.Translate(playerMovement, Space.Self); // https://docs.unity3d.com/ScriptReference/Space.Self.html
    }
}
