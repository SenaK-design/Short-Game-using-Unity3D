using UnityEngine;
using System.Collections;

public class DonusKutusuactive : MonoBehaviour {
	public GameObject gorunmezkutu;

	// Use this for initialization
	void Start () {
		gorunmezkutu.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter()
		{
		gorunmezkutu.SetActive(true);

		}
}
