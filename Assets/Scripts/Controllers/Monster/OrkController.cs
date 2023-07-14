using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OrkController : MonsterController
{
    Stat _stat;



    private void Awake()
    {
        _isDeath = false;
        _isAttack = false;
        nav = GetComponent<NavMeshAgent>();
        _startPos = transform.position;
    }

    public override void Init()
    {
        _stat = gameObject.GetComponent<Stat>();
        _isDeath = false;
        _isAttack = false;
        _ctrlAnim = GetComponent<Animator>();
        _startPos = _posTarget = transform.position;
        nav = GetComponent<NavMeshAgent>();
        _timeWait = 0;
        _isSelectAi = false;
        _isBattle = false;
        _characterStd = 0;
        isFounded = false;
    }










}
