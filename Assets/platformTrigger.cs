using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    PlatformScript platformScript;
    void Start()
    {
        platformScript = GameObject.Find("Cube (5)").GetComponent<PlatformScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.transform.tag == "Player")
        {
            platformScript.platformCanMove = true;
        }
    }
}
