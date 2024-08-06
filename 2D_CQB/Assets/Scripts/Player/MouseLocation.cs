using System.Collections;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class MouseLocation : MonoBehaviour
{
    public Camera mainCamera;
    public static MouseLocation Instance;
    [HideInInspector] public Vector2 mousePosition;
    public bool isValid;
    [SerializeField] bool a ;
    Ray mouseRay;
    RaycastHit2D hit2D;
    Vector2 screenPosition;
    [SerializeField] LayerMask whatIsGround;
    // Start is called before the first frame update
    private void Awake() {
        if(Instance == null) Instance = this;
        else if(Instance != this) Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        isValid = false;
        screenPosition = Input.mousePosition;
        mouseRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        // mousePosition = hit2D.point;

        if (Physics2D.Raycast(mouseRay.origin, mouseRay.direction, Mathf.Infinity, whatIsGround))
        {
            isValid = true;
            Transform hitObjectPosition = hit2D.transform;
        }

    }

}
