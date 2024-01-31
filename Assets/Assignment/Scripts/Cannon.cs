using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    //float to hold rotation speed
    public float speed = 50f;
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //rotate cannon around platform origin
        float cannonMove = Input.GetAxis("Vertical");
        transform.RotateAround(gameObject.transform.position, Vector3.forward, -speed * Time.deltaTime * -cannonMove);
    }
}
