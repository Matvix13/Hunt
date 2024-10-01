using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    
    public float horizontal;
    public float vertical;
    public float sensivity = 1;
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X") * sensivity;
        vertical = Input.GetAxis("Mouse Y") * sensivity;

        transform.Rotate(0, horizontal, 0);
        transform.Rotate(0, 0, vertical);
    }
}
