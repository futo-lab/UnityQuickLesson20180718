using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalController : MonoBehaviour {
    public GameObject flag;
    bool _hoistingFlag;

	void Start () {
	}

    void Reset(){
        _hoistingFlag = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
	
	void Update () {
        flag.SetActive(_hoistingFlag);
	}

    void OnTriggerEnter(Collider c){
        if(c.name == "Ball"){
            _hoistingFlag = true;
            Invoke("Reset", 2);
        }
    }
}
