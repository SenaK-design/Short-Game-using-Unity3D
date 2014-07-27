using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {
	public Character c1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider other){
		if (c1.key == true) {
			Debug.Log("exiting");
			Application.Quit();

				}

		}
}
