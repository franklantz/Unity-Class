using UnityEngine;
using System.Collections;

public class TextChanger : MonoBehaviour {
	
	TextMesh textMesh;
	
	public Transform destination;
	public Vector3 distance;

	// Use this for initialization
	void Start () {
		textMesh = GetComponent<TextMesh>();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		// draw a line between this object's position and the Destination's position
		Debug.DrawLine( transform.position, destination.position );
		
		// set the text of the TextMesh to Vector3 of GameObject to the Destination
		textMesh.text = (destination.position - transform.position).ToString();
		
		transform.position += ( new Vector3(0f, 10f, 0f) * Mathf.Sin (Time.time * 10)) * Time.deltaTime;
		
		if (Time.time > 5f && GetComponent<AudioSource>().isPlaying == false)
			GetComponent<AudioSource>().Play();
	
	}
}
