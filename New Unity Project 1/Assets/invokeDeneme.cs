using UnityEngine;
using System.Collections;

public class invokeDeneme : MonoBehaviour {
	public GameObject hedef;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("NesneYarat", 1, 4);
	}
	
	// Update is called once per frame
	void Update () {
		}
	void NesneYarat(){
		float x = Random.Range (-50f, 50f);
		float z = Random.Range (-50f, 50f);
		float y = Random.Range (-50f, 50f);
		Instantiate (hedef, new Vector3 (x, y, z), Quaternion.identity);
	}
}
