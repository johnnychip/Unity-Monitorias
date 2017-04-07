using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public IArmas[] armas =new IArmas[2];

	public Escopeta escopeta;
	public RPG rpg;

	void Start ()
	{
		armas [0] = escopeta;
		armas [1] = rpg;
	}

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			armas [1].Disparar ();
		}
	}
}
