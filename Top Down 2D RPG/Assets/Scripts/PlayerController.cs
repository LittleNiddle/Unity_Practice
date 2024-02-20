using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Numerics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    float h;
    float v;
    bool isHorizontal;

    Rigidbody2D rigid;
    void Awake() {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update() {
        // Move Value
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        //Check Button Down & Up
        bool hDown = Input.GetButtonDown("Horizontal");
        bool vDown = Input.GetButtonDown("Vertical");
        bool hUp = Input.GetButtonUp("Horizontal");
        bool vUp = Input.GetButtonUp("Vertical");

        // Check Horizontal Move
        if(hDown || vUp)
            isHorizontal = true;
        else if(vDown || hUp)
            isHorizontal = false;
    }

    void FixedUpdate() {
        UnityEngine.Vector2 moveVec = isHorizontal ? new UnityEngine.Vector2(h, 0) * Speed : new UnityEngine.Vector2(0, v) * Speed;
        rigid.velocity = moveVec * Speed;
    }
}
