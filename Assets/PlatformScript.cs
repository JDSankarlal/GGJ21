using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{

    public Vector3 targetPos1, targetPos2;
    public Rigidbody rb;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        rb.MovePosition(transform.position + -Vector3.up * Time.deltaTime * speed);


        
    }
}
