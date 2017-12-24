using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraA : MonoBehaviour, ICamera
{

    public void MoveStart()
    {
        Debug.Log("Start CameraA");
    }


    public void Reset()
    {
        Debug.Log("Reset CameraA");
    }
}