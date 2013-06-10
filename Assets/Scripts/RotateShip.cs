using UnityEngine;
using System.Collections;

public class RotateShip : MonoBehaviour {
	
	public float rotateSpeed1 = 50f;
	public float rotateSpeed2 = 100f;
	public float rotateSpeed3 = 17f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	transform.Rotate(0f, rotateSpeed1 * Time.deltaTime,0f);
	transform.Rotate(rotateSpeed2 * Time.deltaTime, 0f, 0f);
	transform.Rotate(0f, 0f, rotateSpeed3 * Time.deltaTime);
	
	
	}
}
