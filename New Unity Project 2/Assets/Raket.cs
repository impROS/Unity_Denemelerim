using UnityEngine;
using System.Collections;

public class Raket : MonoBehaviour {
	public float _LimitLeft,_LimitRight;
	void Start () {
	
	}
	void Update () {
		Ray _Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Vector3 _WorldSpace = _Ray.GetPoint (10);
		_WorldSpace.y = transform.position.y;
		_WorldSpace.z = transform.position.z;
		if (_WorldSpace.x < _LimitLeft) {
			_WorldSpace.x = _LimitLeft;
		}
		if (_WorldSpace.x > _LimitRight) {
			_WorldSpace.x = _LimitRight;
		}
		transform.position = Vector3.MoveTowards (transform.position,_WorldSpace,Time.deltaTime*10);
	}

	void OnCollisionEnter(Collision _Col){
		if (_Col.collider.gameObject.name == "Sphere") {
			if (GameObject.FindGameObjectsWithTag ("Odul").Length <= 0) {
				_Col.gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
				_Col.gameObject.GetComponent<Rigidbody> ().isKinematic = true;
				_Col.gameObject.transform.parent = gameObject.transform;
			} else {
				Vector3 ReflectVector =  _Col.contacts [0].point - transform.position;
				ReflectVector.y = 2;
				ReflectVector.z = 0;
				ReflectVector.Normalize ();
				ReflectVector *= 2.5f;
				_Col.gameObject.GetComponent<Rigidbody> ().velocity = ReflectVector*3;
			}
		}
	}
}
