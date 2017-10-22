using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class filter : MonoBehaviour {
	public AudioLowPassFilter low;
	public AudioHighPassFilter high;
	InputCheck gyro_pass;

	GameObject Input;

	//gyro_status
	float g_x;
	float g_y;
	//gyro_buckstatus
	float back_x;
	float back_y;



	// Use this for initialization
	void Start () {
		//gyro_status_first
		g_x = 0;
		g_y = 0;
		back_x = 0;
		back_y = 0;

		//get_Inputcheck
		Input = GameObject.Find ("InputCheck");
		//get_filter
		low = gameObject.GetComponent<AudioLowPassFilter> ();
		high = gameObject.GetComponent<AudioHighPassFilter> ();
	}
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKey (KeyCode.X))
			low.cutoffFrequency += 10;

		if (Input.GetKey (KeyCode.Z))
			low.cutoffFrequency -= 10;
		*/

		gyro_pass = Input.GetComponent<InputCheck> ();
		g_x = gyro_pass.gyro.z;
		g_y = gyro_pass.gyro.y;



		if (high.cutoffFrequency > 22000)
			high.cutoffFrequency = 22000;
		if (low.cutoffFrequency > 22000)
			low.cutoffFrequency = 22000;
		if (high.cutoffFrequency < 10)
			high.cutoffFrequency = 10;
		if (low.cutoffFrequency < 10)
			low.cutoffFrequency = 10;
		

		if (g_x > back_x && g_x <back_x+0.01f)
			low.cutoffFrequency -= 440.0f;
		else low.cutoffFrequency += 440.0f;

		if (g_y > back_y && g_y <back_y+0.01f)
			high.cutoffFrequency += 440.0f;
		else high.cutoffFrequency -= 440.0f;


		/*if (gyro_lpass.gyro.y < 0 )
			low.cutoffFrequency = 22000;

		if (gyro_lpass.gyro.y > 0 && gyro_lpass.gyro.y < 0.1)
			low.cutoffFrequency = 17600;

		if (gyro_lpass.gyro.y > 0.1 && gyro_lpass.gyro.y < 0.2)
			low.cutoffFrequency = 13200;

		if (gyro_lpass.gyro.y > 0.2 && gyro_lpass.gyro.y < 0.3)
			low.cutoffFrequency = 8800;

		if (gyro_lpass.gyro.y > 0.3 && gyro_lpass.gyro.y < 0.4)
			low.cutoffFrequency = 4400;

		if (gyro_lpass.gyro.y > 0.4 && gyro_lpass.gyro.y < 0.5)
			low.cutoffFrequency = 10;*/
		back_x = g_x;
		back_y = g_y;	
	}



}
