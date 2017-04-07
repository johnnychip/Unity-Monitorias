using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escopeta : MonoBehaviour, IArmas {
	
	public GameObject bulletPref;

	public void Disparar ()
	{
		Debug.Log("Escopeta");
		Instantiate (bulletPref);
	}

	public void Recargar ()
	{
		Debug.Log("Recargando Escopeta");
	}
}
