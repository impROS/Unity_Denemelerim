using UnityEngine;
using System.Collections;

public class carpmaEngelleme : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name.StartsWith("oyuncu"))
		{
			//Destroy(col.gameObject);
		//	Application.LoadLevel(Application.loadedLevel);
			col.transform.position = new Vector3 (-11.1f, 13.01f, -0.12f);
		}
	}
}
