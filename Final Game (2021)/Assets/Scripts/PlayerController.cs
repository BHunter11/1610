using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D ballRigidbody2D;
    public float speed = 3f;
    public float jumpForce = 300f;

    private Vector2 direction;
    private Vector2 yDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //moves the ball
        direction.x = Input.GetAxis("Horizontal") * speed;
        ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
        //allows the ball to jump
        if (Input.GetButtonDown("Jump"))
        {
            yDirection.y = jumpForce;
            ballRigidbody2D.AddForce(yDirection, ForceMode2D.Force);
        }
    }
}
