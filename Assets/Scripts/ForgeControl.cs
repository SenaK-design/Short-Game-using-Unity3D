using UnityEngine;
using System.Collections;

public class ForgeControl : MonoBehaviour {
	public Character character;
	public GUIText FeederBook,FeederMetal,KeyFinish;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider other)
	{
		if (Input.GetKeyDown (KeyCode.E)) {
			if((character.metalsayisi==3)&&(character.kitap==true)){
				character.key=true;
				KeyFinish.text = "Anahtar yaptın!!";
				StartCoroutine(Mywaitcan(4.0f));
			}
			if ( (character.metalsayisi != 3)&&(character.kitap ==true)){
				FeederBook.text="Kitap tamam!";
				FeederMetal.text="Metaller nerde?";
				StartCoroutine(Mywaitcan(4.0f));
			}
			if ( (character.metalsayisi == 3)&&(character.kitap !=true)){
				FeederBook.text="Kitap nerde?";
				FeederMetal.text="Metaller tamam!";
				StartCoroutine(Mywaitcan(4.0f));
			}
			if ( (character.metalsayisi != 3)&&(character.kitap !=true)){
				FeederBook.text="Kitap nerde?";
				FeederMetal.text="Metaller nerde?";
				StartCoroutine(Mywaitcan(4.0f));
			}
		}
	}
	public IEnumerator Mywaitcan(float delay){
		yield return new WaitForSeconds(delay);
		FeederBook.text= ("");
		FeederMetal.text=("");
		KeyFinish.text = ("");
	}
}
