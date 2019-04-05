using UnityEngine;
using System.Collections;

public class yanma : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
}
	void OnCollisionEnter2D(Collision2D _Col){
		if (_Col.gameObject.name == "Top") {
			Destroy(_Col.gameObject);
			Application.LoadLevel(Application.loadedLevelName);
			GameObject.Find("skorBoard").GetComponent<skorGuncelle>().skor =0;
		}

}
}
