using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5.0f;
    private Rigidbody rbody;
    
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }
   
    void Update()
    {
        Move();
    }
    private void Move()
    {
        float horizontalVector = Input.GetAxis("Horizontal");
        float verticalVector = Input.GetAxis("Vertical");
        Vector2 playerVelocity = new Vector2(horizontalVector * movementSpeed, verticalVector * movementSpeed);
        rbody.velocity = playerVelocity;
    }
}
