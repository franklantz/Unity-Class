using UnityEngine;
using System.Collections;

public class CreateBall : MonoBehaviour {
	
	public Rigidbody ball;
	public float counter;

	// Use this for initialization
	void Start () {
	
		counter = 0;
		
	}
	
	void MakeBall(){
		Rigidbody ballClone = (Rigidbody) Instantiate(ball, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
			
	if (Input.GetKeyDown (KeyCode.Space)& counter < 10){
		MakeBall();
		counter = counter + 1;
		}		
	
	}
}
