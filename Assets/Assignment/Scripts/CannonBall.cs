using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CannonBall : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public GameObject failure;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        //gives it force as soon as it is created
        Vector2 initialForce = -transform.up * 100000 * Time.deltaTime;
        rigidbody.AddForce(initialForce);
    }

    // Update is called once per frame
    void Update()
    {
        //the 4.57 is the height that the x should spawn at
        Vector3 spawner = new Vector3(transform.position.x, -4.57f, 0);

        if (transform.position.y <= -5)
        {
            //make an 'x' and then destroy self - if ball is lower than -5
            Instantiate(failure, spawner, Quaternion.AngleAxis(45, Vector3.forward));
            Destroy(gameObject);
        }
    }
}
