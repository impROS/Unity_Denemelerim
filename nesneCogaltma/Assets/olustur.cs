using UnityEngine;
using System.Collections;

public class olustur : MonoBehaviour {
	float i=0.0F;
	public Transform degiskenNesne;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Instantiate(degiskenNesne,new Vector3(i*2.0F,0,0),Quaternion.identity);
		i=i+0.1F;
	}
}
