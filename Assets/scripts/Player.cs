using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var Horizonatlinput = Input.GetAxis("Horizontal");
        Debug.Log(Horizonatlinput);
        Rigidbody2D rb= GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(Horizonatlinput, rb.linearVelocity.y);

    }
}
