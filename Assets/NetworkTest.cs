using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkTest : NetworkManager {
    CamRay ray;

	// Use this for initialization
	void Start () {
        ray = GameObject.FindObjectOfType<CamRay>();
        ray.OnClick += Connect;
	}

    void Connect()
    {
        StartClient();
    }

    private void OnDestroy()
    {
        if (ray.OnClick != null)
        {
            ray.OnClick -= Connect;
        }
    }
}
