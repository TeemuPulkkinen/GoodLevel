using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    // walking speed of the player
    public float walkSpeed;
    
    // Camera distance in z from player
    public float cameraDistZ = 6;

    // Rigidbody
    private Rigidbody rb;

    // Collider
    private Collider col;

    //size of the player
    private Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();

        size = col.bounds.size;

        CameraFollowPlayer();
    }

    void FixedUpdate()
    {
        
    }

    private void CameraFollowPlayer()
    {
        Vector3 cameraPosition = Camera.main.transform.position;

        cameraPosition.z = transform.position.z - cameraDistZ;

        Camera.main.transform.position = cameraPosition;
    }
}
