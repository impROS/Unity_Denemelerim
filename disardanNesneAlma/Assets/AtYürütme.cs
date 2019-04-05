using UnityEngine;
using System.Collections;

public class AtYürütme : MonoBehaviour {

	Animator _Anim;
	public float _Speed;
	void Start () {
		_Anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			if (_Speed <= 1) {
				_Speed+= Time.deltaTime/20;
			}
		}
		if (Input.GetKey(KeyCode.S)) {
			if (_Speed >= 0) {
				_Speed-= Time.deltaTime/20;
			}
		}
		_Anim.SetFloat ("Speed", _Speed);
		if (_Speed > 0.2f) {
			_Anim.speed = _Speed * 2.5f;
			if (_Anim.speed < 1) {
				_Anim.speed = 1;
			}
		} else {
			_Anim.speed = 1;
		}
	}
}
