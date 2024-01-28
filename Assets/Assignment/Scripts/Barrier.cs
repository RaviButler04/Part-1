using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    float breakCounter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
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
        else if (breakCounter == 3)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        breakCounter += 1;
    }
}
