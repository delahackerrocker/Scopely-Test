using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public static GameManager _instance;

	public int coins = 0;

	public float spawnFrequency = 1.5f;

	public GameObject badGuyPrototype;
	public GameObject[] spawners;
	public GameObject heroesBase;

	public int totalBadGuys = -1;
	public GameObject[] badGuys;

	void Awake()
	{
		_instance = this;
	}

	// Use this for initialization
	void Start ()
	{
		badGuys = new GameObject[100];
		Invoke( "CreateAnotherBadGuy", 0.01f );
	}
	
	// Update is called once per frame
	public void AddCoins( int addThisMany )
	{
		coins += addThisMany;
	}

	protected void CreateAnotherBadGuy()
	{
		//
		totalBadGuys++;

		GameObject randomSpawner = spawners[ Random.Range( 0, spawners.Length ) ];

		GameObject newBadGuy = Instantiate( badGuyPrototype, randomSpawner.transform.position, Quaternion.identity) as GameObject;
		newBadGuy.GetComponent<NavMeshAgent>().SetDestination( heroesBase.transform.position );
		newBadGuy.GetComponent<NavMeshAgent>().speed = Random.Range( 20, 50 );

		badGuys[ totalBadGuys ] = newBadGuy;

		Invoke( "CreateAnotherBadGuy", spawnFrequency );
	}

	public GameObject GetRandomBadGuy()
	{
		int pick = totalBadGuys;

		return badGuys[ pick ];
	}

	public void GameIsOver()
	{
		Time.timeScale = 0;
		Debug.Log ( "Game Over" );
	}
}
