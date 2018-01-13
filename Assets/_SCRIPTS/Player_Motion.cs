using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Motion : MonoBehaviour {
    
    public Vector3 v;
    float x, y;

	// Use this for initialization
	void Start () {
        x = 0; y = 0;
        vecUpdate();
	}
	void vecUpdate () {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        v = new Vector3(x,y,0);
        v = v.normalized;
    }
	// Update is called once per frame
	void Update () {
        vecUpdate();
	}
    void FixedUpdate() {
        GetComponent<Rigidbody>().velocity = v;
    }
}
