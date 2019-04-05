using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public bool _isPlaying;
	void Start () {
		_isPlaying = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) && !_isPlaying) {
			gameObject.GetComponent<Rigidbody> ().velocity = Vector3.up * 5;
			_isPlaying = true;
			Cursor.visible = false;
		}
	}
}
