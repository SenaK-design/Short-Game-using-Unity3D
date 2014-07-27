using UnityEngine;
using System.Collections;

public class BookRotation : MonoBehaviour {
	public Character c1;
//	bool firstcome=false;
	public GameObject bookdestroyer;

	// Use this for initialization
	void Start () {
		c1.gameObject.GetComponent<Character>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f,0f,0.5f);
	
	}
	void OnTriggerStay(Collider other)
	{
		if (Input.GetKeyDown (KeyCode.E)) {
						Debug.Log ("kitap aldı");
						c1.kitap=true;
						bookdestroyer.SetActive(false);
						
				}
	}
}
