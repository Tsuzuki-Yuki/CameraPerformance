using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraB : MonoBehaviour, ICamera
{

    [SerializeField] private Transform[] paths;
    [SerializeField] private GameObject unityChan;
    [SerializeField] private AnimationCurve customEase;

    private Vector3 startPosition;
    private Quaternion startRotation;

    private Vector3[] cameraPath;

    private Tween tween;


    void Awake()
    {
        startPosition = gameObject.transform.position;
        startRotation = gameObject.transform.rotation;

        cameraPath = new Vector3[] { paths[0].position, paths[1].position };
    }

    void Update()
    {
        transform.LookAt(unityChan.transform);
    }


    public void MoveStart()
    {
        Debug.Log("Start CameraB");
        tween = transform.DOPath(cameraPath, 8f, PathType.CatmullRom)
                         .SetEase(customEase)
                         .SetLoops(-1);
    }


    public void Reset()
    {
        tween.Kill();
        gameObject.transform.position = startPosition;
        gameObject.transform.rotation = startRotation;
    }
}
