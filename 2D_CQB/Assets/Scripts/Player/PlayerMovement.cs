using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector] public Vector2 movementDirection = Vector2.zero;
    [HideInInspector] public Vector2 lookPoint;
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
    }
    else
    {
        rb.MovePosition((Vector2)transform.position + movementDirection.normalized * speed * Time.fixedDeltaTime);
    }

    // Calculate the look direction vector from the player to the lookPoint
    Vector2 lookDirection = lookPoint - rb.position;

    // Calculate the angle in degrees
    float targetAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

    // Apply the rotation directly to face the mouse position
    rb.MoveRotation(targetAngle);
}


    // private void FixedUpdate() 
    // {
    //     if (isTiptoeing)
    //     {
    //         rb.MovePosition((Vector2)transform.position + movementDirection.normalized * TiptoeSpeed * Time.fixedDeltaTime);  
    //     }
    //     else
    //     {
    //         rb.MovePosition((Vector2)transform.position + movementDirection.normalized * speed * Time.fixedDeltaTime);
    //     }

    //     Vector2 lookDirection = lookPoint - (Vector2)transform.position;
    //     float targetAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
    //     float angle = Mathf.LerpAngle(rb.rotation, targetAngle, 10f * Time.deltaTime);
    //     rb.MoveRotation(angle);
    // }

}
