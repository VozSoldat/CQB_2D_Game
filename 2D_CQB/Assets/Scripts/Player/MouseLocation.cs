using UnityEngine;

public class MouseLocation : MonoBehaviour
{
    public Camera mainCamera;
    public static MouseLocation Instance;
    [HideInInspector] public Vector2 mousePosition;
    public bool isValid;

    private void Awake() {
        if (Instance == null) Instance = this;
        else if (Instance != this) Destroy(gameObject);
    }

    private void Reset() {
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Get the mouse position in screen space
        Vector2 screenPosition = Input.mousePosition;

        // Convert screen position to world position directly
        mousePosition = mainCamera.ScreenToWorldPoint(screenPosition);

        // Assuming the ground layer is large enough to cover the whole game view
        isValid = true;
    }
}
