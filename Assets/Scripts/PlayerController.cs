using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick joystick;
    [SerializeField] private Animator animator;
    [SerializeField] private float moveSpeed;

    private void FixedUpdate()
    {
        // Get the input values from the joystick
        float horizontalInput = -joystick.Horizontal;
        float verticalInput = -joystick.Vertical;

        // Calculate the movement direction based on joystick input
        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Apply movement speed to the movement direction
        Vector3 movement = movementDirection * moveSpeed;

        // Apply the movement to the Rigidbody velocity
        _rigidbody.velocity = new Vector3(movement.x, _rigidbody.velocity.y, movement.z);

        // Rotate the player to face the movement direction
        if (movementDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movementDirection);
        }

        //Debug.Log(horizontalInput + " " + verticalInput);

    }
}
