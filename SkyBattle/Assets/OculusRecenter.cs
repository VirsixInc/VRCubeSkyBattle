﻿using UnityEngine;
using System.Collections;

public class OculusRecenter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
			OVRManager.display.RecenterPose ();
	}
}
