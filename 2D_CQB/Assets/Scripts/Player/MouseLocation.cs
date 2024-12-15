using UnityEngine;

public class MouseLocation : MonoBehaviour
{
    public static MouseLocation Instance;
    public LayerMask groundLayer; // Assign this to the Ground layer in the Inspector

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Vector2 GetMouseWorldPosition()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero, Mathf.Infinity, groundLayer);

        if (hit.collider != null)
        {
            return hit.point;
        }
        return Vector2.zero; // Return zero if no hit
    }
}
