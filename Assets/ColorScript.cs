using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour {
	
	GameObject gameobject;
	public float every;
	float colorstep;
	Color[] _colors = new Color[12];
	//Color oldColor = new Color();
	//Color newColor = new Color();
	Color lerpedColor = new Color ();
	int i;

	// Use this for initialization
	void Start () {
		_colors[0] = new Color32 (219, 140, 139, 255);
		_colors[1] = new Color32 (217, 205, 136, 255);
		_colors[2] = new Color32 (165, 218, 136, 255);
		_colors[3] = new Color32 (137, 218, 144, 255);
		_colors[4] = new Color32 (137, 217, 211, 255);
		_colors[5] = new Color32 (139, 158, 219, 255);
		_colors[6] = new Color32 (186, 138, 219, 255);
		_colors[7] = new Color32 (218, 172, 138, 255);
		_colors[8] = new Color32 (198, 218, 136, 255);
		_colors[9] = new Color32 (137, 218, 178, 255);
		_colors[10] = new Color32 (138, 191, 218, 255);
		_colors[11] = new Color32 (153, 138, 219, 255);
		lerpedColor = _colors [0];
	}

	void Update () {
		lerpedColor = Color.Lerp (_colors [0], _colors [1], Mathf.PingPong (Time.time, 1));
		gameObject.GetComponent<Renderer> ().material.color = lerpedColor;
		//if (colorstep < every) {
		//	lerpedColor = Color.Lerp (_colors [i], _colors [i + 1], Mathf.PingPong(Time.time));
		//	print (_colors [i]);
		//	gameObject.GetComponent<Renderer> ().material.color = lerpedColor;
		//	//colorstep += 0.05f;
		//} else {
			//colorstep = 0;
		//	if (i < (_colors.Length - 2)) {
		//		i++;
		//	} else {
		//		i = 0;
		//	}

		//}


	}
}