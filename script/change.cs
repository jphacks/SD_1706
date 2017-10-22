using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour {
	public AudioSource[] oto;
	/*public AudioClip audioclip1;
	public AudioClip audioclip2;
	public AudioClip audioclip3;
	private AudioSource audioSource;*/
	//filter_value
	//public float p_x;
	//public float p_y;
	float x = Screen.width / 10;
	float y = 0;
	float w = Screen.width * 8 / 10;
	float hs = Screen.height / 20;

	//lowpass
	float a_x;
	float v_x;
	float r_x;

	//highpass
	float a_y;
	float v_y;
	float r_y;

	float a_z;

	//music_flug
	//int m;

	//original_value
	public float h;
	InputCheck accel;
	GameObject accel_catch;


	// Use this for initialization
	void Start () {
		oto = gameObject.GetComponents<AudioSource> ();
		/*m = 1;
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip = audioclip1;
		audioSource.Play ();*/


		accel_catch = GameObject.Find ("InputCheck");
		//filter_status_first
		//p_x = 0;
		//p_y = 0;
		//low_filter_first
		a_x = 0;
		v_x = 0;
		r_x = 1.5f;
		//high_filter_first
		a_y = 0;
		v_y = 0;
		r_y = 1.5f;

		a_z = 0;
		//original_first
		h = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		accel = accel_catch.GetComponent<InputCheck> ();
		a_x = accel.acceleration.x;
		a_y = accel.acceleration.y;
		a_z = accel.acceleration.z;
		v_x += a_x * h;
		if (1 <= r_x && r_x <= 3.3)
			r_x += v_x * h;
		if (1 > r_x && v_x > 0)
			r_x += v_x * h;
		if (3.3 < r_x && v_x < 0)
			r_x += v_x * h;
		//p_x = Mathf.Pow (r_x, 10);
				
		a_y = accel.acceleration.y;
		v_y += a_y *h;
		if( 1 <= r_y  && r_y <= 2.5f)
			r_y += v_y *h;
		if( 1 <= a_y && v_y  > 0)
			r_y += v_y*h;
		if(2.50 < r_y && v_y  < 0)
			r_y += v_y*h;


		/*if (m == 1) {
			if (a_x > 5) {
				m++;
				audioSource.clip = audioclip2;
			}
		}*/
			
		//p_y = Mathf.Pow(10, 1 + r_x);

		if (a_x > 5)
			oto [3].Play ();
		if (a_y > 5)
			oto [4].Play ();
		if (a_z > 5)
			oto [5].Play ();
	}

	void OnGUI()
	{
		if (GUI.Button (new Rect (x, y, w - 300, 30), "EDM")) {
			oto [0].Play ();
			oto [1].Stop ();
			oto [2].Stop ();
		}
		if (GUI.Button (new Rect (x, y + 300, w - 300, 30), "HARDCORE")) {
			oto [0].Stop ();
			oto [1].Play ();
			oto [2].Stop ();
		}
		if (GUI.Button (new Rect (x, y + 600, w - 300, 30), "TRANCE")) {
			oto [0].Stop ();
			oto [1].Stop ();
			oto [2].Play ();
		}
	}

}
