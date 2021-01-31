using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundTest : MonoBehaviour
{
    private FMODUnity.StudioEventEmitter emitter;

    // Start is called before the first frame update
    void Start()
    {
        emitter = GetComponent<FMODUnity.StudioEventEmitter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) {
            emitter.SetParameter("Level", 1);
        }
        if (Input.GetKey(KeyCode.Alpha2)) {
            emitter.SetParameter("Level", 2);
        }
        if (Input.GetKey(KeyCode.Alpha3)) {
            emitter.SetParameter("Level", 3);
        }
        if (Input.GetKey(KeyCode.Alpha4)) {
            emitter.SetParameter("Level", 4);
        }
        if (Input.GetKey(KeyCode.Alpha5)) {
            emitter.SetParameter("Level", 5);
        }
        if (Input.GetKey(KeyCode.Alpha6)) {
            emitter.SetParameter("Level", 6);
        }
        if (Input.GetKey(KeyCode.Alpha7)) {
            emitter.SetParameter("Level", 7);
        }

        if (Input.GetKey(KeyCode.Space)) {
            SceneManager.LoadScene("Level 2");
        }
    }
}
