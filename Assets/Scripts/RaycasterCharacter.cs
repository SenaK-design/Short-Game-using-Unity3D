using UnityEngine;
using System.Collections;

public class RaycasterCharacter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		Debug.DrawRay(transform.position,fwd*10,Color.green);
		GameObject changer;
		if (Input.GetMouseButtonDown(0)) {
			


			if (Physics.Raycast(transform.position, fwd,out hit,3.0f)){
				if(hit.collider.gameObject.tag=="canbigger"){
				print("There is something in front of the object!");
					changer=hit.collider.gameObject;
					//Vector3 upper,upper1;
					//upper=hit.collider.transform.localScale;
					changer.transform.localScale+=new Vector3(0.5f,0.5f,0.5f);

				}
			}

			}
		if (Input.GetMouseButtonDown(1)) {
			
			
			
			if (Physics.Raycast(transform.position, fwd,out hit,3.0f)){
				if(hit.collider.gameObject.tag=="canbigger"){
					print("There is something in front of the object!");
					changer=hit.collider.gameObject;
					//Vector3 upper,upper1;
					//upper=hit.collider.transform.localScale;
					changer.transform.localScale+=new Vector3(-0.5f,-0.5f,-0.5f);
					
				}
			}
			
		}


	}
}
