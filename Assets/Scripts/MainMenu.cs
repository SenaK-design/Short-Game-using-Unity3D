using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public float buttonsizeH;
	public float buttonsizeW;
	public float button1H,button1W,button2H,button2W,button3H,button3W,button4H,button4W;
	public GUISkin Buttonskins;
	public bool Developer=false,Howtoplay=false;
	public string stringToEdit = "Hello World\nI've got 2 lines...";


	void Awake(){
		buttonsizeH = Screen.height / 10;
		buttonsizeW = Screen.width / 5;
		//height
		button1H = Screen.height / 4;
		button2H = button1H + buttonsizeH+5;
		button3H = button2H + buttonsizeH+5;
		button4H = button3H + buttonsizeH+5;
		//witdh
		button1W = Screen.width/2-(buttonsizeW/2);
		button2W = button1W;
		button3W = button2W;
		button4W = button3W;
	}

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI(){
		GUI.skin = Buttonskins;
			
		if (GUI.Button(new Rect(button1W,button1H,buttonsizeW,buttonsizeH),"Oyuna Başla!")){
			Application.LoadLevel("Level 1");
		}
		if (GUI.Button(new Rect(button2W,button2H,buttonsizeW,buttonsizeH),"Nasıl Oynanır?")){
			Howtoplay=true;
			StartCoroutine(Mywaitcan(4.0f));
		}
		if (GUI.Button(new Rect(button3W,button3H,buttonsizeW,buttonsizeH),"Geliştiriciler")){
			Developer=true;
			StartCoroutine(Mywaitcan(4.0f));
		}
		if (GUI.Button(new Rect(button4W,button4H,buttonsizeW,buttonsizeH),"Çıkış")){
			Application.Quit();
		}
		if (Howtoplay) {
			GUI.Box (new Rect (button4W, button4H + buttonsizeH + 5, buttonsizeW, 197), "Yön tuşları\nİleri:W\nGeri:S\nSağ:D\nSol:A\nEşyaları toplamak için:E\nEşyaları büyüt:sol mouse\n Eşyaları küçült:sağ mouse tuşu\nEsc ile oyunu durdurabilirsin");
		}
		if (Developer) {
			GUI.Box (new Rect (button1W-button1W/4, button1H - buttonsizeH, buttonsizeW*2, 30), "Bu oyun Yusuf Eren UTKU tarafından geliştirilmiştir.");

		}


		}
	// Update is called once per frame
	void Update () {
	
	}
	public IEnumerator Mywaitcan(float delay){
		yield return new WaitForSeconds(delay);
		Howtoplay = false;
		Developer = false;
	}
}
