﻿using UnityEngine;
using System.Collections;

public class startExpPart : MonoBehaviour {
	
	public GameObject Exp;

	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("hit");
		Instantiate (Exp, GameObject.Find ("Trigger1").transform.position, GameObject.Find ("Trigger1").transform.rotation);
	}
}
