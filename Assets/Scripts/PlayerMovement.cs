using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigidBody;
    readonly string jumpKey = "Jump";
    readonly string horizontal = "Horizontal";
    readonly string vertical = "Vertical";
    [SerializeField] float movement = 5f;
    [SerializeField] float jumpHeight = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis(horizontal);
        float verticalInput = Input.GetAxis(vertical);

        rigidBody.velocity = new Vector3(horizontalInput * movement, rigidBody.velocity.y, verticalInput * movement);

        if (Input.GetButtonDown(jumpKey))
        {
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, jumpHeight, rigidBody.velocity.z);
        };

    }
}
