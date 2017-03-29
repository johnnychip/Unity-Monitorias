using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour {

	public GameObject enemigoPrefab;

	private GameObject[] misEnemigos = new GameObject[5];

	public Transform[] spawnPoints;

	public Color[] misColores;
 
	// Use this for initialization
	void Start () {




	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
		
			CrearEnemigos ();

		}

	}

	void CrearEnemigos ()
	{
		for (int i = 0; i < misEnemigos.Length; i++) {
			int numeroAleatorio = Random.Range (0, spawnPoints.Length); 
			misEnemigos[i] = Instantiate (enemigoPrefab, spawnPoints[numeroAleatorio].position, spawnPoints[i].rotation);
			SpriteRenderer spriteTemporal = misEnemigos [i].GetComponent<SpriteRenderer> ();
			int numeroAleatorio2 = Random.Range (0, misColores.Length);
			spriteTemporal.color = misColores[numeroAleatorio2];
		}
	}
}
