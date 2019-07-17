using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenData : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalVar.appear == 1) {
			
			GlobalVar.appear = 0;
		}
		if (GlobalVar.hide == 1) {

			GlobalVar.hide = 0;
		}
	}

	public void onClick(){
		
	}
}
