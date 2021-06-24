using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdContreller : MonoBehaviour
{
    public Rigidbody2D rgb;
    public float JumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rgb.velocity = Vector2.up * JumpForce;
        }
    }
}
