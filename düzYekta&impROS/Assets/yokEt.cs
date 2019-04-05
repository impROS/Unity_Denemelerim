using UnityEngine;
using System.Collections;

public class yokEt : MonoBehaviour
{


	void Start ()
	{
		Destroy (gameObject,5);
	}
	
	// Update is called once per frame
	void Update ()
	{
			
	}

	void OnCollisionEnter (Collision _col)
	{

		if (_col.gameObject.name.Contains ("Ethan")) {
			Destroy (_col.gameObject);
			Destroy(this.gameObject);
		}
	}
}
