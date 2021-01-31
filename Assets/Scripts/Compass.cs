using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{
    public Image myImageComponent;

    public List<Sprite> images = new List<Sprite>();

    public void Start()
    {
        myImageComponent = GetComponent<Image>();
    }

    private void Update()
    {         
        if (CameraSwapScript.currentCam == 1)
        {
            myImageComponent.sprite = images[0];
        }
        else if (CameraSwapScript.currentCam == 2)
        {
            myImageComponent.sprite = images[1];
        }
        else if (CameraSwapScript.currentCam == 3)
        {
            myImageComponent.sprite = images[2];
        }
        else if (CameraSwapScript.currentCam == 4)
        {
            myImageComponent.sprite = images[3];
        }
    }
}