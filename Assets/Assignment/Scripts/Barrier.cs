using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    //float to count number of times collided with
    float breakCounter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //change colour of barrier depening on counter
        if (breakCounter == 0)
        {
            spriteRenderer.color = Color.green;
        }
        else if (breakCounter == 1)
        {
            spriteRenderer.color = Color.yellow;
        }
        else if (breakCounter == 2)
        {
            spriteRenderer.color = Color.red;
        }
        //destroy self if counter is 3
        else if (breakCounter == 3)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //increment counter
        breakCounter += 1;
    }
}
