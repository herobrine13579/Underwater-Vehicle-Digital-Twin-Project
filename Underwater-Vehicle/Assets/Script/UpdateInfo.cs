using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateInfo : MonoBehaviour {

	public Text depth = null;
	public Text speed = null;

	public Text leftSpeed = null;
	public Text rightSpeed = null;
	public Text leftPressure = null;
	public Text rightPressure = null;

	public Text shuibengSys = null;
	public Text yeyaSysTemp = null;
	public Text dianjiTemp = null;

	public Text shuibengOutPressure = null;
	public Text shuibengYeyaFlux = null;
	public Text shuibengYeyaPressure = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		depth.text = "10"; //example
		//update interface put here.
	}
}
