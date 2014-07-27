using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	public int metalsayisi=0;
	public GUIText hintsmetal;
	public GUIText hintskitap;
	public bool kitap = false;
	public bool key=false;
	public bool kitapfirst=false,metalfirst=false;

	// Use this for initialization
	void Start () {
		//Screen.lockCursor = true;

	}
	
	// Update is called once per frame
	void Update () {

		//if (Input.GetKeyDown("escape"))
			//Screen.lockCursor = false;

		if (metalfirst == false) {
						if (metalsayisi == 3) {
								metalfirst=true;
								hintsmetal.text = "Tüm metaller toplandı!";
								StartCoroutine (Mywaitcan (4.0f));

						}
				}
		if (kitapfirst == false) {
						if (kitap) {
								kitapfirst=true;
								hintskitap.text = "Kitap Toplandı!";
								StartCoroutine (Mywaitcan (4.0f));
						}

				}
	}
	public IEnumerator Mywaitcan(float delay){
		yield return new WaitForSeconds(delay);
		hintsmetal.text=("");
		hintskitap.text=("");
	}
}
