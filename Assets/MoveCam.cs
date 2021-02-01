using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{

    private bool refHit = false;
    public GameObject reference;
    public float speed = 1;

    private void OnTriggerEnter(Collider other)
    {
        float platSpeed = Mathf.PingPong(Time.time * speed, 1);
        refHit = !refHit;
        if (refHit)
        {
            reference.transform.position = Vector3.Lerp(reference.transform.position, new Vector3(reference.transform.position.x, 34.0f, reference.transform.position.z), 100);
        }
        else
        {
            reference.transform.position = Vector3.Lerp(reference.transform.position, new Vector3(reference.transform.position.x, 9.8f, reference.transform.position.z), 100);
        }
    }
}
