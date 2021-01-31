using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwapScript : MonoBehaviour
{

    private Animator animator;
    private int camCount = 4;
    public static int currentCam = 1;

    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SwapCamera(-1);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
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
}
