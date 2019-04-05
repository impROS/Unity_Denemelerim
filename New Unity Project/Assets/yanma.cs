using UnityEngine;
using System.Collections;

public class yanma : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter (Collider _Col)
	{
		Debug.Log ("yandingirdi");
		if (_Col.name == "Player") {
			Debug.Log ("yandim da yandim!!!");
			Application.LoadLevel (Application.loadedLevelName);
		}
	}
	void OnColliderEnter (Collision _Col)
	{
		Debug.Log ("yandingirdi");
		if (_Col.gameObject.name == "Player") {
			Debug.Log ("yandim da yandim!!!");
			Application.LoadLevel (Application.loadedLevelName);
		}
	}
}