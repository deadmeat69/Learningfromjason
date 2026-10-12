using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rigidbody;
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

        // when fire bottom pressed and kept pressed horizontal remain same and vertical gets 5 velocity
        if (Input.GetButton("Fire1"))
            rigidbody.linearVelocity = new Vector2(rigidbody.linearVelocity.x, 5f);

    }
}
