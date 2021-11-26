using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [Header("BossSamuraiHP"), Range(0, 1000)]
    public int BossSamurai_HP = 500;

    [Header("BossSamuraiDamage"), Range(0, 10)]
    public int BossSamurai_ATK = 50;

    [Header("BossSamuraiMoveSpeed"), Range(0, 10)]
    public int BossSamurai_MoveSpeed = 5;

    [Header("IsBossSamuraiAttacking")]
    public bool BossSamuraiIsAttacking = false;

    [Header("IsBossSamuraiJumping")]
    public bool BossSamuraiIsJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
