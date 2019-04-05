using UnityEngine;
using System.Collections;

public class kazanma : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnCollisionEnter (Collision _col)
	{
		if (_col.gameObject.name == "oyuncu") {
			Debug.Log ("Kazandin2<<");
			//Debug.Log ("Carpan = " + _col.gameObject.name);
		}
		
		//
	}
}
