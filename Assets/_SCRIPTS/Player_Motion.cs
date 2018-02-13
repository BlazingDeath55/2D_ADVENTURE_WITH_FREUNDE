using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Motion : MonoBehaviour {
    
    public Vector3 v;
    public float speed, jump;
    bool isGrounded;
    float x, y;
    Animator a;
    float mag, lx;

	// Use this for initialization
	void Start () {
        isGrounded = true;
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
        /*
        if(Input.GetAxis("Jump")>0&&isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(0f, jump, 0f);
            Debug.Log("Jump");
        }
        */
    }
/*
    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag=="ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.collider.tag == "ground")
        {
            isGrounded = false;
        }
    }
*/
    //Use for Physics, called once per frame
    void FixedUpdate() {
        GetComponent<Rigidbody>().velocity = v;
    }

}