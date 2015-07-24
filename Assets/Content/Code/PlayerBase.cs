using UnityEngine;
using System.Collections;

public class PlayerBase : MonoBehaviour
{
	public static PlayerBase _instance;
	public GameManager gameManager;

	void Awake()
	{
		_instance = this;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		gameManager.GameIsOver();
		Destroy ( this.gameObject );
	}
}
