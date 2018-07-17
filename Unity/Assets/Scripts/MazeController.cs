using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeController : MonoBehaviour {
	public GameObject ball;
	Vector3 targetPosition;
	Vector3 mouseVel;

	void Start () {
		Reset();

	}

	void Reset(){
		mouseVel = Vector3.zero;
		targetPosition = Vector3.up*2.0f;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update () {
		mouseVel = mouseVel + new Vector3(Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y"), 0f)*0.1f;
		mouseVel = mouseVel * 0.9f;
		targetPosition.x = Mathf.Clamp( targetPosition.x + mouseVel.x*0.01f , -1.0f, 1.0f);
		targetPosition.z = Mathf.Clamp( targetPosition.z + mouseVel.y*0.01f, -1.0f, 1.0f);
		targetPosition.y = 1.0f;

		var q = Quaternion.FromToRotation(Vector3.up, targetPosition.normalized);
		var diff = (Vector3.zero - ball.transform.position);
		var diffRotated = q*diff;

		transform.position = diffRotated + ball.transform.position;
		transform.rotation = q;
	}
}
