using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(() =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("CameraPerformance");
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
