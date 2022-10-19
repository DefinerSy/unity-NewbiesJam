using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class EnemyAction : MonoBehaviour
{
    [SerializeField] public int EnemyHp = 3;
    [SerializeField] private float AttackRange = 3;
    BoxCollider2D EnemyAttackRange;
    public bool isDestory = false;
    private Animator animator;

    private void Awake()
    {
        EnemyAttackRange = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();//获取组件
    }
    private void Start()
    {
        isDestory = false;
        EnemyAttackRange.size = new Vector2(AttackRange, AttackRange);
    }

    private void Update()
    {
        if (isDestory == true)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject obj = other.gameObject;
        if (obj.gameObject.tag == "Player_Stab")//tag为刺时敌人扣血
        {
            EnemyHp -= 1;
        }
        StartCoroutine(EnemyisDestory());//判断敌人状态
        if (EnemyHp > 0)
        {
            obj.GetComponent<PlayerModel>().playerBeAttacked();//当敌人血量大于0时让玩家单位的HP减少
        }
        EnemyAttackRange.size = new Vector2(0, 0);
    }
    public void EnemyActionTime()//利用Button调用,让敌人的碰撞机范围恢复正常
    {
        EnemyAttackRange.size = new Vector2(AttackRange, AttackRange);
    }

    IEnumerator EnemyisDestory()
    {
        if (EnemyHp <= 0)
        {
            animator.Play("EnemyDestory");//敌人HP为0时
        }
        yield return null;
    }

}

