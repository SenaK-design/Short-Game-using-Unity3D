using UnityEngine;
using System.Collections;

public class JumpAreaDrop2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("iki");
		other.transform.position = new Vector3(-33.25635f, 2.530637f, 120.4105f);
	}
}
