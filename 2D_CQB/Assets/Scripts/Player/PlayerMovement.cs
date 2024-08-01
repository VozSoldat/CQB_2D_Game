using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector] public Vector2 movementDirection = Vector2.zero;
    [HideInInspector] public bool isTiptoeing;

    public float speed = 20f;
    float TiptoeSpeed
    {
        get
        {
            return speed/5f;
        }
    }
    [SerializeField] Rigidbody2D rb;
    
    // Start is called before the first frame update
    private void Reset() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate() 
    {
        if (isTiptoeing)
        {
            rb.MovePosition((Vector2)transform.position + movementDirection.normalized * TiptoeSpeed * Time.fixedDeltaTime);    
        }else
        {
            rb.MovePosition((Vector2)transform.position + movementDirection.normalized * speed * Time.fixedDeltaTime);
        }
    }
}
