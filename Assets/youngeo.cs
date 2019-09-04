using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youngeo : MonoBehaviour {
    
    private string keyName;
    private AudioSource noteSource;
    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
		Leap.Controller controller = new Leap.Controller ();
		Leap.Frame frame = controller.Frame ();
		Leap.Hand hand = frame.Hands [0];
		Leap.Vector velocity = hand.PalmVelocity;

		if ((int)velocity.y < 0) {
			keyName = other.name;
			noteSource = gameObject.AddComponent<AudioSource> ();
			noteSource.clip = Resources.Load<AudioClip> ("Notes/" + keyName);
			noteSource.Play ();
			print (noteSource.volume);

			if (keyName == "C2" || keyName == "C3" || keyName == "C4" || keyName == "C5") {
				other.transform.GetComponent<Renderer> ().material.color = new Color32 (219, 140, 139, 255);
			} else if (keyName == "D2" || keyName == "D3" || keyName == "D4" || keyName == "D5") {
				other.transform.GetComponent<Renderer> ().material.color = new Color32 (217, 205, 136, 255);
			} else if (keyName == "E2" || keyName == "E3" || keyName == "E4" || keyName == "E5") {
				other.transform.GetComponent<Renderer> ().material.color = new Color32 (165, 218, 136, 255);
			} else if (keyName == "F2" || keyName == "F3" || keyName == "F4" || keyName == "F5") {
				other.transform.GetComponent<Renderer> ().material.color = new Color32 (137, 218, 144, 255);
			} else if (keyName == "G2" || keyName == "G3" || keyName == "G4" || keyName == "G5") {
				other.transform.GetComponent<Renderer> ().material.color = new Color32 (137, 217, 211, 255);
			} else if (keyName == "A2" || keyName == "A3" || keyName == "A4" || keyName == "A5") {
				other.transform.GetComponent<Renderer> ().material.color = new Color32 (139, 158, 219, 255);
			} else if (keyName == "B2" || keyName == "B3" || keyName == "B4" || keyName == "B5") {
				other.transform.GetComponent<Renderer> ().material.color = new Color32 (186, 138, 219, 255);
			} else if (keyName == "C#2" || keyName == "C#3" || keyName == "C#4" || keyName == "C#5") {
				other.transform.GetComponent<Renderer> ().material.color = new Color32 (218, 172, 138, 255);
			} else if (keyName == "D#2" || keyName == "D#3" || keyName == "D#4" || keyName == "D#5") {
				other.transform.GetComponent<Renderer> ().material.color = new Color32 (198, 218, 136, 255);
			} else if (keyName == "F#2" || keyName == "F#3" || keyName == "F#4" || keyName == "F#5") {
				other.transform.GetComponent<Renderer> ().material.color = new Color32 (137, 218, 178, 255);
			} else if (keyName == "G#2" || keyName == "G#3" || keyName == "G#4" || keyName == "G#5") {
				other.transform.GetComponent<Renderer> ().material.color = new Color32 (138, 191, 218, 255);
			} else if (keyName == "A#2" || keyName == "A#3" || keyName == "A#4" || keyName == "A#5") {
				other.transform.GetComponent<Renderer> ().material.color = new Color32 (153, 138, 219, 255);
			}
		}

    }

    private void OnTriggerExit(Collider other) {
//        noteSource.Stop();
        other.transform.GetComponent<Renderer>().material.color = Color.white;

		if (other.name.Contains("#"))
        {
            other.transform.GetComponent<Renderer>().material.color = Color.black;

        }
    }
}
