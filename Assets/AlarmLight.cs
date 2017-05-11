using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmLight : MonoBehaviour {

    public Light Light;
    public bool Active;

    public int UpdateCount { get; set; }

	// Use this for initialization
	void Start () {
        this.UpdateCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (!this.Active) {
            return;
        }
        if (this.UpdateCount < 60) {
            this.UpdateCount++;
            return;
        }
        this.UpdateCount = 0;

        this.SwitchColor();
	}

    private void SwitchColor() {
        if (this.Light.color == new Color(1, 1, 1)) {
            this.Light.color = new Color(1, 0, 0);
            this.Light.intensity = 3.5f;
            return;
        }
        this.Light.color = new Color(1, 1, 1);
        this.Light.intensity = 1f;
    }
}
