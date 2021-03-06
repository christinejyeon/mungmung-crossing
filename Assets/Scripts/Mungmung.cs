using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mungmung : MonoBehaviour
{
    private int x = 0;
    private int y = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void OnCollisionEnter2D (Collision2D colInfo)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if Input.GetKey("space")
        {
            y += 1;
        }
        if Input.GetKey(KeyCode.RightArrow)
        {
            x += 1;
        }
        if Input.GetKey(KeyCode.LeftArrow)
        {
            x -= 1;
        }
        
    }
}
