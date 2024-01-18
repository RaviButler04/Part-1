using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;

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
        Debug.Log("Lever is hit" + door.gameObject);
        if(door.activeInHierarchy)
        {
            door.SetActive(false);
        }
        else if(!door.activeInHierarchy)
        {
            door.SetActive(true);
        }
    }
}
