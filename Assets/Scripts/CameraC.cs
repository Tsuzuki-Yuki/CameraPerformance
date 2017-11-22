using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraC : MonoBehaviour, ICamera
{
    [SerializeField] private Transform[] paths;
    [SerializeField] private GameObject unityChan;

    private Vector3 startPosition;
    private Quaternion startRotation;

    private Vector3[] cameraPath;

    private Tween tween;

    void Awake()
    {
        startPosition = gameObject.transform.position;
        startRotation = gameObject.transform.rotation;

        cameraPath = new Vector3[] { paths[0].position, paths[1].position, paths[2].position, startPosition };
    }

    void Update()
    {
        transform.LookAt(unityChan.transform);
    }


    public void MoveStart()
    {
        Debug.Log("Start CameraC");
        tween = transform.DOPath(cameraPath, 20f, PathType.Linear)
                         .SetEase(Ease.Linear)
                         .SetLoops(-1);
    }


    public void Reset()
    {
        tween.Kill();
        gameObject.transform.position = startPosition;
        gameObject.transform.rotation = startRotation;
    }
}