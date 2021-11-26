using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyCop : MonoBehaviour
{
    [Header("EnemyCopHP"), Range(0, 20)]
    public int EnemyCop_HP = 10;

    [Header("EnemyCopDamage"), Range(0, 10)]
    public int EnemyCop_ATK = 5;

    [Header("EnemyCopMoveSpeed"), Range(0, 5)]
    public int EnemyCop_MoveSpeed = 3;

    [Header("IsEnemyCopAttacking")]
    public bool EnemyCopIsAttacking = false;

    [Header("IsEnemyCopJumping")]
    public bool EnemyCopIsJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
