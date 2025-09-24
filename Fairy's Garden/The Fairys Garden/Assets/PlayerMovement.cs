using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]


public class PlayerMovement : MonoBehaviour
{
   /* public CharacterController controller;

    [Header("Movement Settings")]
    public float speed = 6f;                // movement speed
    public float turnSmoothTime = 0.1f;     // smoothness of turning
    float turnSmoothVelocity;

    [Header("Camera Reference")]
    public Transform cam;                   // drag Main Camera (with Cinemachine Brain) here

    [Header("Gravity")]
    public float gravity = -9.81f;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public Transform groundCheck;

    Vector3 velocity;
    bool isGrounded;

    void Update()
    {
        // ground check
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // input
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            // rotate relative to camera
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            // move relative to camera direction
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }

        // gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
   */

    //I tried really hard to even just get the movement working and it did not in fact work, the cinemachine cameras are hard LOL
    //But I got this code using AI and it caused the Playerobject to shake a ton, need to fix it somehow. Project made!
}




