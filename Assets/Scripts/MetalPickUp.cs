using UnityEngine;
using System.Collections;

public class MetalPickUp : MonoBehaviour {
	public GameObject Metal1;//çivi objesi
	public Character c1;//karakterin üstündeki scripte ulaşmak için karakter objesi
	public BoxCollider boxcol;//basılabilme alanı için boxcollider(keypressarea)
	public GUIText hints;
	public bool ilkgiris=false;
	// Use this for initialization

	void Start () {

		c1.gameObject.GetComponent<Character>();
		//boxcol=this.gameObject.GetComponent<BoxCollider>();
		//c1=karakter.GetComponent<Character> ();
	}
	
	// Update is called once per frame
	void Update () {

			//transform.Rotate(0, 5*Time.deltaTime, 0);
	
	}
	void OnTriggerStay()
	{
		if (Input.GetKeyDown (KeyCode.E)) {
			if(ilkgiris==false){
			ilkgiris=true;
			Metal1.SetActive(false);
			c1.metalsayisi++;
//			c1.metalsayisi++;
			//c1.metalsayisi++;
			Debug.Log("bir metal toplandı");
			hints.text="Bir metal parçası bulundu!("+c1.metalsayisi+"/3)";
			StartCoroutine(Mywaitcan(4.0f));
			

			//boxcol.isTrigger=false;

			}
			//this.collider.isTrigger(false);


										}
	}
	 public IEnumerator Mywaitcan(float delay){
		yield return new WaitForSeconds(delay);
		hints.text=("");
	}

}
