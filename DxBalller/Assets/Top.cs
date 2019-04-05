using UnityEngine;
using System.Collections;

public class Top : MonoBehaviour {

	Rigidbody2D _Rigi;
	void Start () {
		_Rigi = gameObject.GetComponent<Rigidbody2D> ();
		_Rigi.velocity = new Vector2 (0,8);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D _Col){
		if (_Col.gameObject.name == "Raket") {
			Vector2 ÇarpışmaNoktası = _Col.contacts[0].point;
			Vector2 RaketMerkezi = _Col.gameObject.transform.position;
			Vector2 Yeniİvme = ÇarpışmaNoktası - RaketMerkezi + _Rigi.velocity;
			Yeniİvme=Yeniİvme.normalized *8;
			_Rigi.velocity =Yeniİvme;
		}else if (_Col.gameObject.name.StartsWith("Block")) {
			Destroy(_Col.gameObject);
			//Puan Sayacı
			GameObject.Find("skorBoard").GetComponent<skorGuncelle>().skorBoardGuncelle();

		}


	}
}
