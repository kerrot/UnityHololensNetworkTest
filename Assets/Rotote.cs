using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotote : MonoBehaviour {
    [SerializeField]
    private Vector3 angle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(angle);
	}
}
