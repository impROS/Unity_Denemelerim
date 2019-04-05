using UnityEngine;
using System.Collections;

public class ChopperAnıim : MonoBehaviour {
	public float Speed;	
	Rigidbody _rigi;
	Transform _Üst1,_Üst2;
	void Start () {
		_Üst1 = transform.FindChild ("Üst1").transform;
		_Üst2 = transform.FindChild ("Üst2").transform;
		_rigi = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 Tmp = new Vector3(0,0,0);
		MainAnim ();
		bool _Input = false;
		if (Input.GetKey(KeyCode.LeftShift)) {
			Speed += Time.deltaTime*5;
		}
		if (Input.GetKey(KeyCode.LeftControl)) {
			Speed -= Time.deltaTime*5;
		}
		if (Input.GetKey(KeyCode.W)) {
			Tmp += new Vector3(0,0,-1);
			_Input = true;
		}
		if (Input.GetKey(KeyCode.S)) {
			Tmp += new Vector3(0,0,1);
			_Input = true;
		}
		if (Input.GetKey(KeyCode.A)) {
			Tmp += new Vector3(1,0,0);
			_Input = true;
		}
		if (Input.GetKey(KeyCode.D)) {
			Tmp += new Vector3(-1,0,0);
			_Input = true;
		}
		if (Input.GetKey(KeyCode.Q)) {
			Tmp += new Vector3(0,-1,0);
			_Input = true;
		}
		if (Input.GetKey(KeyCode.E)) {
			Tmp += new Vector3(0,1,0);
			_Input = true;
		}
		if (!_Input) {
			transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.Euler(0,transform.rotation.eulerAngles.y,0),45*Time.deltaTime);
		}
		transform.Rotate (Tmp);

	}

	void MainAnim ()
	{
		_Üst1.Rotate (new Vector3 (0, Speed, 0));
		_Üst2.Rotate (new Vector3 (0, Speed, 0));
		_rigi.AddForce (transform.up * Speed);
	}
}
