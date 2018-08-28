using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "leaf")
            {
            Destroy(c.gameObject);
            }

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
