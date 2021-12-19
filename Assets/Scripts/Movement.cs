using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public FixedJoystick leftStick;
    public float speed = 3.0f;
    public float rotatespeed = 720.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xVelo = leftStick.Horizontal;
        float zVelo = leftStick.Vertical;

        Vector3 direction = new Vector3(xVelo, 0, zVelo);
        direction.Normalize();
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        if (direction != Vector3.zero)
        {
            Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotatespeed * Time.deltaTime);
        }
    }
}
