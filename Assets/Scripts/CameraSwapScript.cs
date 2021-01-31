using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwapScript : MonoBehaviour
{

    public GameObject triggerBox;
    CinemachineVirtualCamera[] children;
    private Animator animator;
    private int camCount = 4;
    private int currentCam = 1;
    private FMOD.Studio.EventInstance spinLeftInst;
    private FMOD.Studio.EventInstance spinRightInst;
    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
     
    }

    // Update is called once per frame
  void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            spinLeftInst = FMODUnity.RuntimeManager.CreateInstance("event:/SFX/SpinLeft");
            spinLeftInst.start();
            spinLeftInst.release();
            SwapCamera(-1);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            spinRightInst = FMODUnity.RuntimeManager.CreateInstance("event:/SFX/SpinRight");
            spinRightInst.start();
            spinRightInst.release();
            SwapCamera(1);
        }
    }

    void SwapCamera(int num)
    {
        currentCam += num;
        if (currentCam <= 0)
        {
            currentCam = 4;
        }
        if (currentCam >4)
        {
            currentCam = 1;
        }
        animator.Play("Camera " + currentCam);    
       
    }

    void OnTriggerEnter(Collision hit)
    {
        if(hit.transform.tag == "Player")
        {
            foreach (CinemachineVirtualCamera vcam in transform)
            {

            }
        }
    }
}
