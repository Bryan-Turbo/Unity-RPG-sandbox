using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour {

    public float MoveSpeed;
    public Transform Character;
    public Animator Animator;

    public float MovementX;
    public float MovementY;

    private Vector2 Position { get; set; }
    private string CurrentAnimationName { get; set; }
    private string AnimationToTrigger { get; set; }

    // Use this for initialization
    void Start() {
        Position = Character.position;
    }

    // Update is called once per frame
    void Update() {
        MovementX = 0;
        MovementY = 0;

        this.AnimationToTrigger = "Idle";

        if (Input.GetKey("w")) {
            MovementY += MoveSpeed;
            this.AnimationToTrigger = "PlayerWalkUp";
        } else if (Input.GetKey("a")) {
            MovementX -= MoveSpeed;
            this.AnimationToTrigger = "PlayerWalkLeft";
        } else if (Input.GetKey("s")) {
            MovementY -= MoveSpeed;
            this.AnimationToTrigger = "PlayerWalkDown";
        } else if (Input.GetKey("d")) {
            MovementX += MoveSpeed;
            this.AnimationToTrigger = "PlayerWalkRight";
        }

        TriggerAnimation();

        Character.position += new Vector3(this.MovementX, this.MovementY);
    }

    private void TriggerAnimation() {
        //if (this.CurrentAnimationName != this.AnimationToTrigger) {
        //    this.CurrentAnimationName = this.AnimationToTrigger;
            Animator.Play(this.AnimationToTrigger);
        //}
    }
}