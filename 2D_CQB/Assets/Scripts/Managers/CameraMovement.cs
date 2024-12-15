using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Vector3 offset; // To maintain a fixed offset between the camera and the player

    // Start is called before the first frame update
    void Start()
    {
        // Calculate the initial offset at the start of the game
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Maintain the initial offset, ensuring the camera follows the player without being affected by rotation
        transform.position = player.transform.position + offset;
    }
}
