using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(15, 0, 5);

    // Start is called before the first frame update
    void Start()
    {
        // Attach phe plane GameObject to the camera
        plane = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Make the camera following the plane
        transform.position = plane.transform.position + offset;
    }
}
