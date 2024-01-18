using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rigidbody;
    public float force = 150f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force *Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player hit something");
    }
}
