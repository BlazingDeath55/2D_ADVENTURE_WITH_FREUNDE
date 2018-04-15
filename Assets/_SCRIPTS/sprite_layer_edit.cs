using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite_layer_edit : MonoBehaviour {

    // Use this for initialization

    public GameObject[] areas;
    SpriteRenderer[] sr;
    List<SpriteRenderer> s;
    Transform player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        s = new List<SpriteRenderer>();
        foreach (GameObject world in areas)
        {
            sr = world.GetComponentsInChildren<SpriteRenderer>();
            foreach (SpriteRenderer sp in sr)
            {
                s.Add(sp);
            }
        }
    }

	// Update is called once per frame
	void Update () {
        for(int i=0;i<s.Count;i++)
        {
            SpriteRenderer t;
            t = s[i];
            string desired;
            if (player.position.z > t.transform.parent.position.z)
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
