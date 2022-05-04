using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    // Assign camera GameObjects in Inspector to switch between cameras
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;

    // Activate next camera if previous is activated
    public void switchCam()
    {

        if (cam1.gameObject.activeSelf)
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
        }

        else if (cam2.gameObject.activeSelf)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
        }

        else
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
        }
    }
}
