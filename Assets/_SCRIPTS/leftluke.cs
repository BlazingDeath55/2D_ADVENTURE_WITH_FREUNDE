using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftluke : MonoBehaviour {
    Vector3 sca;
    GameObject plyr;
    bool l_r;
 
    // Use this for initialization
    void Start()
    {
        plyr = GameObject.FindGameObjectWithTag("Player");
        l_r = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (plyr.GetComponent<Rigidbody>().velocity.x > 0) {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (plyr.GetComponent<Rigidbody>().velocity.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}