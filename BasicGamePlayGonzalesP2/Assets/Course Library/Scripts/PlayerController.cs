using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContyroller : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
