using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleSpawner : MonoBehaviour {

	public GameObject module;

	// Use this for initialization
	void Start () {

		SpawnModule ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnModule () {
		Object.Instantiate (module, transform);
	}
}
