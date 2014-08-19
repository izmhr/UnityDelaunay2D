using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public float r = 6.0f;
	public float y = 1.0f;
	public float rad = 0.2f;
	float angle = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		angle += rad * Time.deltaTime;
		transform.position = new Vector3( r * Mathf.Cos (angle), y, r * Mathf.Sin(angle) );
		transform.LookAt (new Vector3(0, 0, 0) );
	}
}
