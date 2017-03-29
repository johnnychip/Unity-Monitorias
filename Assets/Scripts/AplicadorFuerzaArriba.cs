using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplicadorFuerzaArriba : MonoBehaviour {

	private float fuerzaaaa = 20f;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector3.up * fuerzaaaa, ForceMode2D.Impulse);
		}
	}

}
