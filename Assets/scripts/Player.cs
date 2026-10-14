using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rigidbody;
    [SerializeField] float limitofjump;
    [SerializeField] float jumpSeconds;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // left and right movement with A and D , y velocity remains same

        var Horizonatlinput = Input.GetAxis("Horizontal");
        rigidbody.linearVelocity = new Vector2(Horizonatlinput * 5, rigidbody.linearVelocity.y);

        // when fire bottom pressed stores the time and add .5 seconds in the variable which we compare later

        if (Input.GetButtonDown("Fire1") )
            limitofjump = Time.time + jumpSeconds;

        // comparing 2 comdition for the limiting  the jump

        if (Input.GetButton("Fire1") && limitofjump > Time.time)
            rigidbody.linearVelocity = new Vector2(rigidbody.linearVelocity.x, 5f ); 


    }
}
