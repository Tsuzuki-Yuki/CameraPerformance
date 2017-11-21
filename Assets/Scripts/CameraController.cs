using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{

    [SerializeField] private GameObject cameraA;
    [SerializeField] private GameObject cameraB;
    [SerializeField] private GameObject cameraC;

    private GameObject activeCamera;
    private string currentKey;

    private Dictionary<string, GameObject> cameraDict = new Dictionary<string, GameObject>();


    // Use this for initialization
    void Start()
    {
        activeCamera = cameraA;
        cameraB.SetActive(false);
        cameraC.SetActive(false);

        cameraDict.Add("A", cameraA);
        cameraDict.Add("B", cameraB);
        cameraDict.Add("C", cameraC);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            currentKey = Input.inputString;

            if (!cameraDict.ContainsKey(currentKey.ToUpper()))
            {
                Debug.Log(currentKey.ToUpper() + "は登録されていません");
                return;
            }

            if (activeCamera == cameraDict[currentKey.ToUpper()])
            {
                return;
            }

            activeCamera.GetComponent<ICamera>().Reset();
            activeCamera.SetActive(false);

            cameraDict[currentKey.ToUpper()].SetActive(true);
            cameraDict[currentKey.ToUpper()].GetComponent<ICamera>().MoveStart();
            activeCamera = cameraDict[currentKey.ToUpper()];
        }
    }
}
