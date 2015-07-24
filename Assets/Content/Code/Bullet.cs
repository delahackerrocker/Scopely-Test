using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		Invoke ( "DestroyThis", 4.0f );
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	protected void DestroyThis()
	{
		Destroy( this.gameObject );
	}
}
