using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassRandomizer : MonoBehaviour {

    public Transform Transform;
    public Material Material;
    public SpriteRenderer Renderer;

	// Use this for initialization
	void Start () {
        System.Random rand = new System.Random();
        foreach (Transform child in Transform) {
            float rotation = rand.Next(0, 4) * 90f;
            child.Rotate(new Vector3(0, 0, rotation));
        }

        var renderer = this.GetComponentsInChildren<SpriteRenderer>();

        foreach (var render in renderer) {
            render.material = this.Material;
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
