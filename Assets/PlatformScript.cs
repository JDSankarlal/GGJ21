using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{

    public Vector3 targetPos1, targetPos2;
    public Rigidbody rb;
    public float speed = 1f;
    public bool platformCanMove;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = targetPos1;
    }

    // Update is called once per frame
    void Update()
    { 
        if (platformCanMove)
        {
            float time = Mathf.PingPong(Time.time * speed, 1);
            gameObject.transform.position = Vector3.Lerp(targetPos1, targetPos2, time);  
        }
    }

}
