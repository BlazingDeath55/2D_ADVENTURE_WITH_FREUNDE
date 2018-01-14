using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Motion : MonoBehaviour {
    
    public Vector3 v;
    public float speed;
    float x, y;
    Animator a;
    float mag, lx;

	// Use this for initialization
	void Start () {
        mag = 0;
        a = GetComponent<Animator>();
        x = 0; y = 0;
        vecUpdate();
	}

	void vecUpdate () {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        v = new Vector3(x,0,y);
        v = speed*v.normalized;
    }

	// Update is called once per frame
	void Update () {
        vecUpdate();
        if(v.x != lx) {
            a.SetBool("Left",(v.x < 0));
        }
        if(v.magnitude!=mag) {
            a.SetFloat("Speed", v.magnitude);
        }
        mag = v.magnitude;
        lx = v.x;
	}
    //Use for Physics, called once per frame
    void FixedUpdate() {
        GetComponent<Rigidbody>().velocity = v;
    }

}