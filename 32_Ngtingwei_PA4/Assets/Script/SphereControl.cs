using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spheremovement();
    }

    private void Spheremovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.up * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.down * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.right * Time.deltaTime);
        }
    }
}
