﻿using UnityEngine;
using System.Collections;

public class ScentReceptor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


  void OnParticleCollision(GameObject gameObject)
  {
      Debug.Log("collision: " + gameObject.name);
  }
}
