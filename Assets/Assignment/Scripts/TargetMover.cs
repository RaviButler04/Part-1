using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    public float speed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -7 || transform.position.x > 7)
        {
            speed = speed * -1;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
