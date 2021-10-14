using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // https://www.youtube.com/watch?v=i8AG7EXCGBQ
    // Start is called before the first frame update
    [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
    private Vector3 moveDirection;
    private Vector3 velocity;
    // Mobile
    public float speed = 5000f;
    // REFERENCES
    [SerializeField] private CharacterController controller;
    // [SerializeField] private Animator animator;
    // [SerializeField] private Rigidbody rigidBody;
    // [SerializeField] private Transform playerBody;


    [SerializeField] private bool isGrounded;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float gravity;

    void Start()
    {
        controller.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {        
       MoveMobile();
    }

    private void MoveMobile()
    {
        Debug.Log("x: "+Input.acceleration.x + " x: " + Input.acceleration.y + " z: "+Input.acceleration.z);

        isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // get ypos accelerometer, mobil is landascape

        float moveZ = Input.acceleration.y;
        
        // Viene como true al igualarlo como false no ingresa y el carro deja de girar por todos lados y se puede controlar el vehículo

        if (isGrounded == false)
        {

            if (Input.acceleration.y >= -.8f && Input.acceleration.y <= -.6f)
            {
                Walk(); // Animation
                moveDirection = new Vector3(0, 0, moveZ * -1);
                moveDirection = transform.TransformDirection(moveDirection);
            }
            else
            {
                moveZ = 0f;
                moveDirection = new Vector3(0, 0, moveZ);
                moveDirection = transform.TransformDirection(moveDirection);
                Idle(); // Animation
            }

            // this is implemented in camera follow script
            /*if (Input.acceleration.x > 0f)
            {
                // Move rigth
                //float rigtx = Input.acceleration.x;
                //playerBody.Rotate(Vector3.up * rigtx * Time.deltaTime);
            }
            else if (Input.acceleration.x < 0f)
            {
                // Move Left
                //float leftx = Input.acceleration.x;
                //playerBody.Rotate(Vector3.up * leftx * Time.deltaTime);
            }*/

            moveDirection *= moveSpeed;
        }

        controller.Move(moveDirection * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    private void Idle()
    {
        // animator.SetFloat("Speed", 0, 0.1f, Time.deltaTime);
    }


    private void Walk()
    {
        moveSpeed = walkSpeed;
        // animator.SetFloat("Speed", 0.5f, 0.1f, Time.deltaTime);
        // daggerGameObject.enabled = false;
    }

}
