using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject ball;
	Vector3 _offset = new Vector3(0f, 30f, -54f);

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		transform.position = ball.transform.position + _offset;
	}
}
