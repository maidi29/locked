using UnityEngine;
using System.Collections;

public class ChessRiddle : MonoBehaviour {
	public GameObject knight;
	public GameObject mysteryKey;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider collider) {
		if (collider.gameObject == knight) {
			mysteryKey.gameObject.SetActive(true);
		}
	}
}
