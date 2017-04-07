using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPG : MonoBehaviour, IArmas {

	public GameObject bulletPref;

	public void Disparar ()
	{
		Debug.Log("RPG");
		Instantiate (bulletPref);
		Instantiate (bulletPref);
	}

	public void Recargar ()
	{
		Debug.Log("Recargando RPG");
	}
}

