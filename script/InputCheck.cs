using System.Collections.Generic;
using UnityEngine;

public class InputCheck : MonoBehaviour {

	GameObject filter;
	filter filter_set;
	change change_music;
	//public Vector3 acceleration;
	public Vector3 acceleration;
	private Compass compass;
	public Quaternion gyro;
	private GUIStyle labelStyle;
	// Use this for initialization
	void Start () {

		filter = GameObject.Find ("MainCamera");

		//font
		this.labelStyle = new GUIStyle();
		this.labelStyle.fontSize = Screen.height / 22;
		this.labelStyle.normal.textColor = Color.white;

		Input.compass.enabled = true;

		Debug.Log(string.Format("<b>quolity{0}", Input.compass.headingAccuracy));
		Debug.Log(string.Format("<b>timestamp</b>:{0}", Input.compass.timestamp));

		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		filter_set = filter.GetComponent<filter> ();
		change_music = filter.GetComponent<change> ();
		this.acceleration = Input.acceleration;
		this.compass = Input.compass;
		this.gyro = Input.gyro.attitude;
	}

	void OnGUI()
	{
		if (acceleration != null)
		{
			float x = Screen.width / 10;
			float y = 0;
			float w = Screen.width * 8 / 10;
			float h = Screen.height / 20;

			/*for (int i = 0; i < 17; i++)
			{
				y = Screen.height / 10 + h * i;
				string text = string.Empty;

				switch (i)
				{
				case 0://X
					text = string.Format("accel-X:{0}", this.acceleration.x);
					break;
				case 1://Y
					text = string.Format("accel-Y:{0}", this.acceleration.y);
					break;
				case 2://Z
					text = string.Format("accel-Z:{0}", this.acceleration.z);
					break;
				case 3://X
					text = string.Format("comps-X:{0}", this.compass.rawVector.x);
					break;
				case 4://Y
					text = string.Format("comps-Y:{0}", this.compass.rawVector.y);
					break;
				case 5://Z
					text = string.Format("comps-Z:{0}", this.compass.rawVector.z);
					break;
				case 6://Z
					text = string.Format("magneticHeading:{0}", this.compass.magneticHeading);
					break;
				case 7://Z
					text = string.Format("trueHeading:{0}", this.compass.trueHeading);
					break;
				case 8://Y
					text = string.Format("gyro-x:{0}", this.gyro.x);
					break;
				case 9://Y
					text = string.Format("gyro-y:{0}", this.gyro.y);
					break;
				case 10://Y
					text = string.Format("gyro-z:{0}", this.gyro.z);
					break;
				case 11://Y
					text = string.Format("gyro-w:{0}", this.gyro.w);
					break;
				case 12:
					text = string.Format ("lowpassfilter:{0}", filter_set.low.cutoffFrequency);
					break;
				case 13:
					text = string.Format ("highpassfilter:{0}", filter_set.high.cutoffFrequency);
					break;
				case 14:
					text = string.Format ("H:{0}", change_music.h);
					break;
				case 15:
					//text=string.Format ("p_x:{0}", change_music.p_x);
					break;
				case 16:
					//text=string.Format ("p_y:{0}", change_music.p_y);
					break;
				default:
					throw new System.InvalidOperationException();
				}*/

				//GUI.Label(new Rect(x, y, w, h), text, this.labelStyle);

			if (GUI.Button (new Rect (x + 150, y+20, w-500, h+20), "H:UP"))
				change_music.h++;
			if (GUI.Button (new Rect (x, y+20, w-500, h+20), "H:DOWN"))
				change_music.h--;
			if (GUI.Button (new Rect (x, y, w - 500, h + 20), "EDM"))
				change_music.oto [0].Play ();
			if (GUI.Button (new Rect (x+50, y, w - 500, h + 20), "HARDCORE"))
				change_music.oto [1].Play ();
			if (GUI.Button (new Rect (x+100, y, w - 500, h + 20), "TRANCE"))
				change_music.oto [2].Play ();
			
			}
		
			
		}
	}
