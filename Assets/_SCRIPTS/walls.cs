using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walls : MonoBehaviour {

    public GameObject g;
    Transform child;
	// Use this for initialization
	void Start () {
        g = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void set_child(Transform c)
    {
        child = c;
    }
    public Transform get_child()
    {
        return child;
    }
}
