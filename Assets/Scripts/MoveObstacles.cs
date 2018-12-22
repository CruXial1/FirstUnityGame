using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacles : MonoBehaviour
{
    public Transform position;
    public Rigidbody body;

    public float movementSpeed = 100f;
    public float positionX;

    bool positiveX = true;

    private void Start()
    {
        body.AddForce(3000, 0 ,0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (position.position.x < -22)
        {
            Debug.Log("minus position");
            body.AddForce(movementSpeed * Time.fixedDeltaTime, 1, 1, ForceMode.VelocityChange);
            positiveX = false;
        }

        if (position.position.x > 22)
        {
            body.AddForce(-movementSpeed * Time.fixedDeltaTime, 1, 1, ForceMode.VelocityChange);
            positiveX = true;
        }
    }
}
