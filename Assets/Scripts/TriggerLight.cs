using UnityEngine;
using System.Collections;

public class TriggerLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		light.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {	
	
			light.enabled = true;
	
		
	}
	
	
	
}
