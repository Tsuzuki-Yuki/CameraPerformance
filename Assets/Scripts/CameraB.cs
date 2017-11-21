using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraB : MonoBehaviour, ICamera
{

    public void MoveStart()
    {
        Debug.Log("Start CameraB");
    }


    public void Reset()
    {
        Debug.Log("Reset CameraB");
    }
}
