using UnityEngine;
using System.Collections;

public class skorGuncelle : MonoBehaviour {

	// Use this for initialization
	public int skor = 0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void skorBoardGuncelle(){
		skor++;
		if (skor < 49) {
			GetComponent<TextMesh>().text =skor.ToString();
		}else {
			GetComponent<TextMesh>().text ="Kazandiniz- impROS";
			Application.LoadLevel(Application.loadedLevelName);
		}

	}
}
