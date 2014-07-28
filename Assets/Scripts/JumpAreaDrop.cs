using UnityEngine;
using System.Collections;

public class JumpAreaDrop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("bir");
		other.transform.position = new Vector3(-40.21512f, 2.530637f, 66.28324f);
	}
}
