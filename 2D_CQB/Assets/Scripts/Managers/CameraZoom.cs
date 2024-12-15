using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    Camera cameraCamera;
    [SerializeField] GameObject player;
    public Vector2 zoomSpeed = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        cameraCamera = GetComponent<Camera>();
        player.GetComponent<PlayerInputPC>().scrollSpeed = zoomSpeed;
        if (zoomSpeed.y != 0)
        {
            cameraCamera.orthographicSize= zoomSpeed.y;
        }
    }
}
