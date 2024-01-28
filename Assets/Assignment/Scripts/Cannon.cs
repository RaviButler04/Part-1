using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float speed = 50f;
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float cannonMove = Input.GetAxis("Vertical");
        transform.RotateAround(gameObject.transform.position, Vector3.forward, -speed * Time.deltaTime * -cannonMove);
    }
}
