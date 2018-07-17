using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour {
    public float power = 500;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider c){
        if(c.name == "Ball"){
            Rigidbody rb = c.GetComponent<Rigidbody>();
            Vector3 forceDirection = transform.TransformDirection(Vector3.up);
            rb.velocity = rb.velocity - Vector3.Project(rb.velocity, Vector3.up);
            rb.AddForce(forceDirection*power);
        }
    }
}
