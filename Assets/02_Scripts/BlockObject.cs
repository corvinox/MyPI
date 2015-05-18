using UnityEngine;
using System.Collections;

public class BlockObject : MonoBehaviour {

	Block block { get; set; }

	void OnEnable () {
		Debug.Log ("Enable!");
	}

	void OnDisable() {
		Debug.Log ("Disable!");
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
