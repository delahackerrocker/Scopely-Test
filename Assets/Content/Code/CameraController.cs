using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey( KeyCode.LeftArrow )) { this.transform.position = this.transform.position + new Vector3( -1, 0, 0 ); }
		if (Input.GetKey( KeyCode.RightArrow )) { this.transform.position = this.transform.position + new Vector3( 1, 0, 0 ); }
		if (Input.GetKey( KeyCode.UpArrow )) { this.transform.position = this.transform.position + new Vector3( 0, 0, 1 ); }
		if (Input.GetKey( KeyCode.DownArrow )) { this.transform.position = this.transform.position + new Vector3( 0, 0 , -1 ); }
	}
}
