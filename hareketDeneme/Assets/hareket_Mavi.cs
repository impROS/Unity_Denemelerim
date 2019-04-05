using UnityEngine;
using System.Collections;

public class hareket_Mavi: MonoBehaviour {
	private GameObject kapi;
	// Use this for initialization
	void Start ()
	{
		kapi =  GameObject.Find("kapi_Mavi");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			
			transform.position = new Vector3 (transform.position.x, transform.position.y + 0.1f, transform.position.z);
			
			
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y - 0.1f, transform.position.z);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position = new Vector3 (transform.position.x - 0.1f, transform.position.y, transform.position.z);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position = new Vector3 (transform.position.x + 0.1f, transform.position.y, transform.position.z);
		}
		
	}
	void OnCollisionEnter(Collision nesne){
		
		if (nesne.gameObject.name == "key_Mavi") {
			MeshRenderer m =kapi.GetComponent<MeshRenderer>();
			m.enabled = true;
			Destroy(nesne.gameObject);
			
			
		}
	}
}
