using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    //float for platform speed
    public float speed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if platform is at either side of screen, if it is then reverse its direction.
        if (transform.position.x < -7 || transform.position.x > 7)
        {
            //reverse direction
            speed = speed * -1;
        }
        //move platform
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
