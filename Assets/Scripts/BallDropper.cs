using UnityEngine;
using System.Collections;

public class BallDropper : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position += ( new Vector3(16f, 0f, 0f) * Mathf.Sin (Time.time * 2)) * Time.deltaTime;
	
	}
}
