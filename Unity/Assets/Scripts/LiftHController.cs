using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftHController : MonoBehaviour {
    public GameObject lift;
    public float length = 4f;
    public float speed = 0.01f;
    float _currentPosition = 0f;
	// Use this for initialization
    bool _isReturning = false;
	void Start () {
        _currentPosition = 0f;
        _isReturning = false;
	}
	
	// Update is called once per frame
	void Update () {
		lift.transform.position = transform.position + transform.rotation * Vector3.forward* _currentPosition;
        ChangeCurrentPosition();
	}
    void ChangeCurrentPosition(){
        if(_isReturning){
            _currentPosition = Mathf.Clamp(_currentPosition - speed, 0, length);
        }else{
            _currentPosition = Mathf.Clamp(_currentPosition + speed, 0, length);
        }

        if(_currentPosition >= length){
            _isReturning = true;
        }

        if(_currentPosition <= 0){
            _isReturning = false;
        }
    }
}
