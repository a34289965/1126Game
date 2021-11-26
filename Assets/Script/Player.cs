using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("PlayerHP"), Range(0, 100)]
    public int Player_HP = 100;

    [Header("PalyerDamage"), Range(0, 10)]
    public int Player_ATK = 5;

    [Header("PlayerMoveSpeed"), Range(0, 10)]
    public int Player_MoveSpeed = 5;

    [Header("IsPlayerAttacking")]
    public bool PlayerIsAttacking = false;

    [Header("IsPlayerJumping")]
    public bool PlayerIsJumping = false;

    [Header("檢查地板尺寸與位移")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;

    [Header("跳躍按鍵與可跳躍圖層")]
    public KeyCode KeyJump = KeyCode.Space;
    public LayerMask canJumpLayer;

    public Rigidbody2D Rigi;
    public void move()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        Rigi.velocity = new Vector2(Horizontal * Player_MoveSpeed, Rigi.velocity.y);

    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        Gizmos.DrawSphere(transform.position + checkGroundOffset, checkGroundRadius);
    }

    private void file() 
    {
        float h = Input.GetAxis("Horizontal");

        if (h < 0) 
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (h > 0) 
        {
            transform.eulerAngles = Vector3.zero;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        Rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        file();
    }
}
