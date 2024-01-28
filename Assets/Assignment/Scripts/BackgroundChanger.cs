using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    float counter = 1f;
    public SpriteRenderer spriteRenderer;

    public Color myColor1;
    public Color myColor2;
    public Color myColor3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(counter == 1)
        {
            spriteRenderer.color = myColor1;
        }
        if(counter == 2)
        {
            spriteRenderer.color = myColor2;
        }
        if(counter == 3)
        {
            spriteRenderer.color = myColor3;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(counter < 3)
        {
            counter++;
        }
        else
        {
            counter = 1;
        }
        Debug.Log(collision);
    }
}
