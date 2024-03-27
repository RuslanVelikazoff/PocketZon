using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Vector2 direction;

    [SerializeField] 
    private Joystick joystick;
    
    [SerializeField]
    private Rigidbody2D rigidbody;
    
    private void Update()
    {
        direction.x = joystick.Horizontal;
        direction.y = joystick.Vertical;
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + direction * speed * Time.fixedDeltaTime);
    }
}
