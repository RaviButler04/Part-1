using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject success;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //get x location of collision
        Vector3 spawner = new Vector3(collision.transform.position.x, -4f, 0);

        //destroy ball
        Destroy(collision.gameObject);

        //create a checkmark
        Instantiate(success, spawner, Quaternion.AngleAxis(45, Vector3.back));
    }
}
