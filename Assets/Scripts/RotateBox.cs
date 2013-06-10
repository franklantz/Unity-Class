using UnityEngine;
using System.Collections;

public class RotateBox : MonoBehaviour {
	
	float rotateSpeed = 100f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.Space)){
		rigidbody.AddRelativeTorque(0f, 0f, rotateSpeed * Time.deltaTime);
		}
	
	}
}
