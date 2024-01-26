using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 temp = Vector3.MoveTowards(transform.position, cursorPos, MoveSpeed * Time.deltaTime);
        rb.MovePosition(temp);
        Vector3 moveDirection = (cursorPos - (Vector2)transform.position).normalized;
        if (moveDirection.x < 0)
        {
            sr.flipX = true;
        }
        else if(moveDirection.x > 0)
        {
            sr.flipX = false;
        }
        
    }
}
