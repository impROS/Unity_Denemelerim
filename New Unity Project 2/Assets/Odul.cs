using UnityEngine;
using System.Collections;

public class Odul : MonoBehaviour {

	void OnCollisionEnter(Collision _Col){
		if (_Col.gameObject.name == "Sphere") {
			Destroy (gameObject);
		}
	
	}
}
