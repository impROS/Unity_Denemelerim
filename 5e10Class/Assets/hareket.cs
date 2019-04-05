using UnityEngine;
using System.Collections;

public class hareket : MonoBehaviour {

	// Use this for initialization
	Vector3 _moveDir;
	Rigidbody _rigi;
	public float _horizantalSpeed,_verticalSpeed;
	void Start () {
		_rigi = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){

			_horizantalSpeed *=-1;
		}
		_moveDir = new Vector3(_horizantalSpeed,_verticalSpeed,0);
		_rigi.velocity = _moveDir;
	}
}
