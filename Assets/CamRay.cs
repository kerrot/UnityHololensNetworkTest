using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRay : MonoBehaviour {

    GameObject obj;
	
    public delegate void ClickEvent();
    public ClickEvent OnClick; 

	// Update is called once per frame
	void Update () {
        RaycastHit hit;

		if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
        {
            if (hit.collider is CapsuleCollider)
            {
                if (obj == null && OnClick != null)
                {
                    OnClick();
                }

                obj = hit.collider.gameObject;
                obj.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }
        else
        {
            if (obj)
            {
                obj.GetComponent<MeshRenderer>().material.color = Color.white;
                obj = null;
            }
        }
	}
}
