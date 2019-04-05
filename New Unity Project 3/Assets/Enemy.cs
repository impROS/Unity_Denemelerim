using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public Transform Player;
	void Start () {
		Player = GameObject.Find ("Player").transform;
	}
	void Update () {
		Vector3 _Dir = Player.position - this.transform.position;
		if (Vector3.Distance(Player.position,this.transform.position) > 1) {
			gameObject.GetComponent<CharacterController> ().Move (_Dir*Time.deltaTime);
		}
	}
}
