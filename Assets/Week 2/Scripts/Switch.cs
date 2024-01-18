using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color myColor1;
    public Color myColor2;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = myColor2;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger from: " + collision.gameObject);
        //spriteRenderer.color = Color.red;
        //gameObject.SetActive(false);
        //gameObject.activeInHierarchy
        //spriteRenderer.enabled = false;
        spriteRenderer.color = myColor1;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = myColor2;
    }
}
