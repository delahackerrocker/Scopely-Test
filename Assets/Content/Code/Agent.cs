using UnityEngine;
using System.Collections;

public class Agent : MonoBehaviour
{
	public bool thisAgentIsAlive = true;

	public int health = 100;

	// Use this for initialization
	void Start () {
		this.GetComponent<NavMeshAgent>().SetDestination( PlayerBase._instance.gameObject.transform.position );
	}

	void OnTriggerEnter(Collider other) 
	{
		health -= 40;

		if ( health < 0 ) {
			thisAgentIsAlive = false;
			this.GetComponent<NavMeshAgent>().Stop ();
			this.gameObject.SetActive( false );

			GameManager._instance.AddCoins( 1 );
		}
	}

}
