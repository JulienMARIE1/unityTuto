using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	public Transform Target;
	public float Distance = 18;
	public float CameraY = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Target.position.x -5, transform.position.y, Target.position.z - Distance);
	}
	void LateUpdate(){
		Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x, CameraY, Camera.main.transform.position.z); 	
	
	}
}	
