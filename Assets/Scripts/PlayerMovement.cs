using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigidBody;
    public int playerPosition = 0;
    string jumpKey = "Jump";
    string horizontal = "Horizontal";
    string vertical = "Vertical";
    string upKey = "up";
    string downKey = "down";
    string rightKey = "right";
    string leftKey = "left";

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

        rigidBody.velocity = new Vector3(horizontalInput * 5F, rigidBody.velocity.y, verticalInput * 5f);

        if (Input.GetButtonDown(jumpKey))
        {
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, 5f, rigidBody.velocity.z);
        };

    }
}
