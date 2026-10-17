using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rigidbody;
    SpriteRenderer spriteRenderer;
    [SerializeField] float limitofjump;
    [SerializeField] float jumpSeconds;
    public bool Isgrounded;
    public Sprite _jumpsprite;
    public Sprite _standsprite;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
        _standsprite = spriteRenderer.sprite;

    }

    void Start()
    {

    }
    /*void OnDrawGizmos()
    {
       spriteRenderer = GetComponent<SpriteRenderer>();
       float bottomY = spriteRenderer.bounds.extents.y;
       Vector2 Origin = new Vector2(transform.position.x,transform.position.y - bottomY );
       Gizmos.color = Color.yellow;
       Gizmos.DrawLine( Origin, Origin + Vector2.down * 0.1f );

    }*/

    // Update is called once per frame
    void Update()
    {
       
        Vector2 Origin = new Vector2(transform.position.x, transform.position.y - spriteRenderer.bounds.extents.y);
        var hit = Physics2D.Raycast(Origin, Vector2.down, 0.1f); // from towards till 
        if (hit.collider)
            Isgrounded = true;
        else
            Isgrounded = false;
        // left and right movement with A and D , y velocity remains same

        var Horizonatlinput = Input.GetAxis("Horizontal");
        rigidbody.linearVelocity = new Vector2(Horizonatlinput * 5, rigidbody.linearVelocity.y);

        // when fire bottom pressed stores the time and add .5 seconds in the variable which we compare later

        if (Input.GetButtonDown("Fire1") && Isgrounded)
            limitofjump = Time.time + jumpSeconds;

        // comparing 2 comdition for the limiting  the jump

        if (Input.GetButton("Fire1") && limitofjump > Time.time)
            rigidbody.linearVelocity = new Vector2(rigidbody.linearVelocity.x, 5f);


    }
}
