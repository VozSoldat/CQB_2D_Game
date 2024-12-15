using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputPC : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
    public Vector2 scrollSpeed;
    // Start is called before the first frame update
    private void Reset() {
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement == null)
            return;
        PlayerInputHandler();
    }
    void PlayerInputHandler()
    {
        TranslationInput();
        RotationInput();
        MouseScrollInput();
    }

    void TranslationInput()
    {
        
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        bool isTiptoeing = Input.GetButton("Tiptoe");
        playerMovement.movementDirection = new Vector2(horizontal, vertical);

        playerMovement.isTiptoeing = isTiptoeing;
        
    }
    void RotationInput()
    {
        if (MouseLocation.Instance == null || playerMovement == null)
            return;

        Vector2 mouseWorldPosition = MouseLocation.Instance.GetMouseWorldPosition();

        if (mouseWorldPosition != Vector2.zero)
        {
            playerMovement.SetLookPoint(mouseWorldPosition);
        }
    }

    void MouseScrollInput()
    {
        scrollSpeed = Input.mouseScrollDelta;
    }

}
