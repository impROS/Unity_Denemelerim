using UnityEngine;
using System.Collections;

public class kazanma_Sari : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision nesne){

		if (nesne.gameObject.name == "kapi_Sari") {
			Debug.Log("Kazandin,bir sonraki level yapilinca görüşürüz haci");
			Destroy(nesne.gameObject);
			//Application.LoadLevel(1);
		}
	}
}
