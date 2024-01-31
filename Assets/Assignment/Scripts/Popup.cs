using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    //float to act as timer
    float timer = 300;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //decrement timer
        timer -= 1;

        //if timer is at zero then destory self
        if (timer == 0)
        {
            Destroy(gameObject);
        }
    }
}
