using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HiddenData : MonoBehaviour {

	public GameObject blockMain;
	public GameObject block1;
	public GameObject block2;
	public GameObject block3;
	public Text text = null;
	int hide = 0;

	// Use this for initialization
	void Start () {
		//blockMain = GameObject.Find ("RawImageMain");
		//block1 = GameObject.Find ("RawImage1");
		//block2 = GameObject.Find ("RawImage2");
		//block3 = GameObject.Find ("RawImage3");
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (GlobalVar.appear == 1) {
			
			GlobalVar.appear = 0;
		}
		if (GlobalVar.hide == 1) {

			GlobalVar.hide = 0;
		}*/
	}

	public void onClick(){
		
		if (hide == 0) {
			blockMain.SetActive (false);
			block1.SetActive (false);
			block2.SetActive (false);
			block3.SetActive (false);
			text.text = "显示数据";
			hide = 1;
		} else {
			blockMain.SetActive (true);
			block1.SetActive (true);
			block2.SetActive (true);
			block3.SetActive (true);
			text.text = "隐藏数据";
			hide = 0;
		}
	}
}
