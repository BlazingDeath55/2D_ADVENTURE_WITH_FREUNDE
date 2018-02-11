using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_hide : MonoBehaviour {

   
 

    // Use this for initialization
    public walls[] w;
    Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        w=transform.GetComponentsInChildren<walls>();
        foreach(walls wi in w)
        {
            wi.set_child(wi.g.transform.GetChild(0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach(walls wi in w)
        {
            bool desired;
            if (player.position.z > wi.get_child().position.z)
            {
                desired = false;
            }
            else
            {
                desired = true;
            }
            if (desired != wi.g.activeInHierarchy)
            {
                wi.g.SetActive(desired);
            }
        }
    }
}
