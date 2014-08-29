//Made by KirbyRawr from Overflowing Studios
//Please don't claim it as yourself.
//If you pirated it consider buying it (:
//Thanks

using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour {

	public KeyCode leftKey = KeyCode.Keypad4;
	public KeyCode rightKey = KeyCode.Keypad6;

	[HideInInspector]
	public GameObject character;
	[HideInInspector]
	public UMAModels umaModels;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(umaModels == null){
		umaModels = GameObject.Find ("UMAModels").GetComponent<UMAModels> ();
		}
		if(umaModels != null && character == null){

		if(umaModels.modifiers.Male == true)
			character = GameObject.Find ("Male_Unified");

		if(umaModels.modifiers.Female == true)
			character = GameObject.Find ("Female_Unified");

		}

		//if(character != null)
		//this.transform.LookAt(character.transform);

		if(Input.GetKeyDown(leftKey)){

			if(character != null)
			this.transform.RotateAround(character.transform.localPosition,new Vector3(0,-1,0),20f);

		}

		if(Input.GetKeyDown(rightKey)){

			if(character != null)
			this.transform.RotateAround(character.transform.localPosition,new Vector3(0,1,0),20f);
			
		}

	}
}
