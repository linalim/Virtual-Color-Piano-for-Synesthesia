using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
       // other.material.SetColor("_Color", Color.red);
        //other.transform.localScale = new Vector3(other.transform.localScale.x, other.transform.localScale.y / 2, other.transform.localScale.z);
        //other.transform.localScale = new Vector3(other.transform.position.x, other.transform.position.y / 2, other.transform.position.z);
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.localScale = new Vector3(other.transform.localScale.x, other.transform.localScale.y *2, other.transform.localScale.z);
        other.transform.localScale = new Vector3(other.transform.position.x, other.transform.position.y *2, other.transform.position.z);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
