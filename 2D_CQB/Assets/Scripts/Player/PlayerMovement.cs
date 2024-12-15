using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector] public Vector2 movementDirection = Vector2.zero;
    [HideInInspector] public bool isTiptoeing;

    public float speed = 20f;
    private float TiptoeSpeed
    {
        get
        {
            return speed / 5f;
        }
    }

    [SerializeField] private Rigidbody2D rb;

    // Private field for lookPoint to ensure it's set and used correctly
    private Vector2 lookPoint;

    private void Reset()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        TranslationMovement();
        RotationMovement();
    }

    public void SetLookPoint(Vector2 point)
    {
        lookPoint = point;
    }

    private void TranslationMovement()
    {
        // float moveSpeed = isTiptoeing ? TiptoeSpeed : speed;
        // rb.MovePosition((Vector2)transform.position + movementDirection.normalized * moveSpeed * Time.fixedDeltaTime);

        if (!isTiptoeing)
        {
            rb.MovePosition((Vector2)transform.position + movementDirection.normalized * speed * Time.fixedDeltaTime);
        }else
        if (isTiptoeing)
        {
            rb.MovePosition((Vector2)transform.position + movementDirection.normalized * TiptoeSpeed * Time.fixedDeltaTime);
        }
    }

    private void RotationMovement()
    {
        // Ensure lookPoint is valid
        if (lookPoint == Vector2.zero)
            return;

        Vector2 direction = (lookPoint - (Vector2)transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.MoveRotation(angle);
    }
}
