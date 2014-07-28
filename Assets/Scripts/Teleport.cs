using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
		{
		other.transform.position = new Vector3(-11.0986f, 2.361293f, 5.150945f);
		}


}
