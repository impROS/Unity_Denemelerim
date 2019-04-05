using UnityEngine;
using System.Collections;

public class ortaNokta : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool bulundu =  GameObject.Find("kup");
		Debug.log (bulundu.ToString());
	}
}
