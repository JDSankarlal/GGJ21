using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundTest : MonoBehaviour
{
    
    private FMODUnity.StudioEventEmitter emitter;
    private FMOD.Studio.EventInstance instance;

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(gameObject);
        emitter = GetComponent<FMODUnity.StudioEventEmitter>();
    }

    // Update is called once per frame
    void Update()
    {
        //SceneManager.sceneLoaded

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            emitter.SetParameter("Level", 1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            emitter.SetParameter("Level", 2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            Debug.Log("FUCK MY ASSHOLE BITCHASS HOE FROG");
            emitter.SetParameter("Level", 3);
            Debug.Log("Parameter set");
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            emitter.SetParameter("Level", 4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            emitter.SetParameter("Level", 5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6)) {
            emitter.SetParameter("Level", 6);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7)) {
            emitter.SetParameter("Level", 7);
        }

        if (Input.GetKey(KeyCode.Space)) {
            SceneManager.LoadScene("SoundTest2");
        }
    }
        
}