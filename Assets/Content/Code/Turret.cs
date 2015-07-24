using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour
{
	protected float rateOfFire = 2.0f;

	public Rigidbody bullet;

	// Use this for initialization
	void Start() 
	{
		Invoke ( "FireCannon", rateOfFire );
	}

	public void FireCannon() 
	{
		this.transform.LookAt( GameManager._instance.GetRandomBadGuy().transform.position );

		Rigidbody newBullet;
		newBullet = Instantiate( bullet, transform.position, transform.rotation ) as Rigidbody;
		newBullet.velocity = transform.TransformDirection( Vector3.forward * 160 );

		Invoke ( "FireCannon", rateOfFire );
	}
}