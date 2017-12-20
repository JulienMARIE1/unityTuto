using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour {

	int Speed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Speed = 1;
		transform.Rotate (new Vector3 (0, Speed, 0), Space.World);
	}
}
