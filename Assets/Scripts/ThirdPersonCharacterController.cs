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
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(horInput, 0f, verInput) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
}
