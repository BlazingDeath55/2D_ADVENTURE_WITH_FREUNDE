using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite_layer_edit : MonoBehaviour {

    // Use this for initialization

    public GameObject world;
    SpriteRenderer[] sr;
    Transform player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        sr = world.GetComponentsInChildren<SpriteRenderer>();
    }

	// Update is called once per frame
	void Update () {
        foreach(SpriteRenderer t in sr)
        {
            string desired;
            if (player.position.z > t.transform.position.z)
            {
                desired = "InFront";
            }
            else
            {
                desired = "Behind";
            }
            if(desired!=t.sortingLayerName)
            {
                t.sortingLayerName = desired;
            }
        }
	}
}
