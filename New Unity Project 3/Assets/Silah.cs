using UnityEngine;
using System.Collections;

public class Silah : MonoBehaviour {
	void Start () {
		
	}
	void Update () {
		if (Input.GetMouseButton(0)) {
			Ray _Ray = Camera.main.ScreenPointToRay (new Vector3 (Screen.width / 2, Screen.height / 2, 0));
			Vector3 Bas = _Ray.origin;
			Vector3 Son = _Ray.GetPoint (200);
			gameObject.GetComponent<LineRenderer> ().SetPosition (0, Bas);
			gameObject.GetComponent<LineRenderer> ().SetPosition (1, Son);
			RaycastHit _Hit;
			if (Physics.Raycast(_Ray,out _Hit,float.MaxValue)) {
				if (_Hit.collider.gameObject.name == "Düsman") {
					Debug.Log ("Hit!!!");
					GameObject _Kan = (GameObject)Instantiate (Resources.Load ("Kan"), _Hit.point, Quaternion.identity);
					_Kan.transform.parent = _Hit.collider.gameObject.transform;

				}
			}
	
		}
	}
}
