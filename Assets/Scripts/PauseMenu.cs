using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	public bool isPaused = false,isGuiActive=false;
	public MouseLook mouseactive;
	float buttonsizeH;
	float buttonsizeW;
	float button1H,button1W,button2H,button2W,button3H,button3W,button4H,button4W;
	float anahtarH,anahtarW;
	public GUISkin Buttonskins;
	public bool Developer=false,Howtoplay=false;
	public Character infos;
	
	
	void Awake(){
		anahtarW = Screen.width;
		//
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
		Screen.lockCursor = true;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if(Input.GetKeyDown(KeyCode.Escape)){
		
			if(isPaused==false){
				Screen.lockCursor=false;
				isPaused=true;
				isGuiActive=true;
				mouseactive.enabled=false;
				Time.timeScale=0;
				Debug.Log("sıfır");
			}

		}

	}
	void OnGUI(){
		GUI.skin = Buttonskins;
		GUI.Label (new Rect (Screen.width / 2 -12, Screen.height / 2 - 12,	24, 24), "+");	
		if(infos.kitap==false){
			GUI.Box( new Rect(10,10,200,60),infos.metalsayisi+"/3 metal topladın\n"+"Kitap ise hala kayıp!");
		}
		if(infos.kitap==true){
			GUI.Box( new Rect(10,10,200,60),infos.metalsayisi+"/3 metal topladın\n"+"Kitap taşıyorsun!");
		}
		if (infos.key == true) {
			GUI.Box( new Rect(anahtarW/2-300,10,600,60),"Anahtar sende! Artık burdan çıkabilirsin! Sarı ışığa git ve E'ye bas");
				}
		if (isGuiActive == true) {
						

						if (GUI.Button (new Rect (button1W, button1H, buttonsizeW, buttonsizeH), "Oyuna Devam Et!")) {
				Screen.lockCursor=true;
				isPaused=false;
				isGuiActive=false;
				mouseactive.enabled=true;
				Time.timeScale=1;
						}
						if (GUI.Button (new Rect (button2W, button2H, buttonsizeW, buttonsizeH), "Nasıl Oynanır?")) {
								Howtoplay = true;
								StartCoroutine (Mywaitcan (4.0f));
						}
						if (GUI.Button (new Rect (button3W, button3H, buttonsizeW, buttonsizeH), "Geliştiriciler")) {
								Developer = true;
								StartCoroutine (Mywaitcan (4.0f));
						}
						if (GUI.Button (new Rect (button4W, button4H, buttonsizeW, buttonsizeH), "Çıkış")) {
								Application.Quit ();
						}
						if (Howtoplay) {
								GUI.Box (new Rect (button4W, button4H + buttonsizeH + 5, buttonsizeW, 197), "Yön tuşları\nİleri:W\nGeri:S\nSağ:D\nSol:A\nEşyaları toplamak için:E\nEşyaları büyüt:sol mouse\n Eşyaları küçült:sağ mouse tuşu\nEsc ile oyunu durdurabilirsin");
						}
						if (Developer) {
								GUI.Box (new Rect (button1W - button1W / 4, button1H - buttonsizeH, buttonsizeW * 2, 30), "Bu oyun Yusuf Eren UTKU tarafından geliştirilmiştir.");
			
						}
				}
		
	}
	public IEnumerator Mywaitcan(float delay){
		yield return new WaitForSeconds(delay);
		Howtoplay = false;
		Developer = false;
	}
}
