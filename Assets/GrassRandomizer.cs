using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassRandomizer : MonoBehaviour {

    public Transform Transform;

	// Use this for initialization
	void Start () {
        System.Random rand = new System.Random();
        foreach (Transform child in Transform) {
            float rotation = rand.Next(0, 4) * 90f;
            child.Rotate(new Vector3(0, 0, rotation));
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
