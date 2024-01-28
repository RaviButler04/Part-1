using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        //rigidbody.AddForce(Vector3.forward * Time.deltaTime * 1000);
        //rigidbody.AddForce(Vector3.up * Time.deltaTime * 10000);

        Vector2 force = -transform.up * 100000 * Time.deltaTime;
        rigidbody.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
