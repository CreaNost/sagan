﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxCamera : MonoBehaviour {

	void LateUpdate(){
		transform.rotation = Camera.main.transform.rotation;
	}
}