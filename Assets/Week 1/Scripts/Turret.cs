using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    float speed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float turretMove = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward, -speed * Time.deltaTime * -turretMove);
    }
}
