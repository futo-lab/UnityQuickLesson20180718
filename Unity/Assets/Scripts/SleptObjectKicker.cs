using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleptObjectKicker: MonoBehaviour {
    Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(rigidbody.IsSleeping()){
            rigidbody.WakeUp();
        }
	}
}

