using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4collider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        other.transform.GetComponent<Renderer>().material.color = Color.green;
        other.transform.localScale = new Vector3(other.transform.localScale.x, other.transform.localScale.y / 2, other.transform.localScale.z);
        other.transform.localScale = new Vector3(other.transform.position.x, other.transform.position.y / 2, other.transform.position.z);
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.GetComponent<Renderer>().material.color = Color.white;
    }


}
