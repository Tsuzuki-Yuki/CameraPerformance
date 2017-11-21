using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraC : MonoBehaviour, ICamera
{
    
    public void MoveStart()
    {
        Debug.Log("Start CameraC");
    }


    public void Reset()
    {
        Debug.Log("Reset CameraC");
    }
}