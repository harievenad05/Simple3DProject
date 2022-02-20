using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigidBody;
    public int playerPosition = 0;
    string spaceKey = "space";
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
        if (Input.GetKeyDown(spaceKey))
        {
            rigidBody.velocity = new Vector3(0, 5f, 0);
        };
        if (Input.GetKey(upKey))
        {
            rigidBody.velocity = new Vector3(0, 0, 5f);
        };
        if (Input.GetKey(downKey))
        {
            rigidBody.velocity = new Vector3(0, 0, -5f);
        };
        if (Input.GetKey(rightKey))
        {
            rigidBody.velocity = new Vector3(5f, 0, 0);
        };
        if (Input.GetKey(leftKey))
        {
            rigidBody.velocity = new Vector3(-5f, 0, 0);
        };
    }
}
