using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotateCamera : MonoBehaviour
{
    private bool forward;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (forward)
        {
            transform.Rotate(0,0.05f,0);
            if (transform.localRotation.y > 0.4f)
                forward = false;
        }
        else if (!forward)
        {
            // Debug.Log(transform.rotation.y);
            transform.Rotate(0,-0.05f,0);
            if (transform.localRotation.y < -0.4f)
                forward = true;
        }
    }
}
