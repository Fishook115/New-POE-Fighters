using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{

    //Variables
    public float cameraPanSpeed = -5f;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        //Start Position
        startPos = transform.position;
    }

// Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.deltaTime * cameraPanSpeed, 20);
        transform.position = startPos + Vector2.down * newPos;
    }
}
