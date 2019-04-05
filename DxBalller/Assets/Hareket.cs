using UnityEngine;
using System.Collections;

public class Hareket : MonoBehaviour {
	public float _hız;
	Rigidbody2D _Rigi;
	public Vector3 RightLimit,LeftLimit;
	bool CursorShow;
	void Start () {
		CursorShow = false;
		_Rigi = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (!CursorShow) {
			Ray _Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			Vector3 MouseKonumu = _Ray.GetPoint(10);
			if (MouseKonumu.x < RightLimit.x && MouseKonumu.x > LeftLimit.x) {
				MouseKonumu.y = transform.position.y;
				MouseKonumu.z = transform.position.z;
				transform.position = MouseKonumu;
			}else if (MouseKonumu.x > RightLimit.x) {
				MouseKonumu.y = transform.position.y;
				MouseKonumu.z = transform.position.z;
				MouseKonumu.x = RightLimit.x;
				transform.position = MouseKonumu;
			}else if (MouseKonumu.x < LeftLimit.x) {
				MouseKonumu.y = transform.position.y;
				MouseKonumu.z = transform.position.z;
				MouseKonumu.x = LeftLimit.x;
				transform.position = MouseKonumu;
			}
		}
		if (Input.GetKeyDown(KeyCode.Escape)) {
			CursorShow = !CursorShow;
		}
		if (CursorShow) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}
		Cursor.visible = CursorShow;

	}
}

