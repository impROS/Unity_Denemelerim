using UnityEngine;
using System.Collections;

public class kazandin : MonoBehaviour
{
	public static int CounterSayma = 0;
	// Use this for initialization
	UnityEngine.UI.Text Texter;

	void Start ()
	{
		Texter = GameObject.Find ("Text").GetComponent<UnityEngine.UI.Text> ();
		Texter.enabled = false;
		int CounterSayma = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter (Collider _Col)
	{
		Debug.Log ("Trigger");
		if (_Col.name == "Player") {
			CounterSayma++;
			if (CounterSayma == 3) {
				Debug.Log ("Kazandın!!!");
				Texter.enabled = true;
				Application.LoadLevel (Application.loadedLevelName);
			}

		}
		
	}
}
