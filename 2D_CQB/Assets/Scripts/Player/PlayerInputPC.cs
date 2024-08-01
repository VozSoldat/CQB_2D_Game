using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputPC : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
    // Start is called before the first frame update
    private void Reset() {
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovementHandler();
    }
    void PlayerMovementHandler()
    {
        if (playerMovement == null)
            return;
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        bool isTiptoeing = Input.GetButton("Tiptoe");
        // bool isTiptoeing = Input.GetKey(KeyCode.Space);
        playerMovement.movementDirection = new Vector2(horizontal, vertical);
        playerMovement.isTiptoeing = isTiptoeing;
    }
}
