using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    [SerializeField]private int playerHp = 10;
    private new Rigidbody2D rigidbody;
    
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rigidbody.gravityScale = 0f;
    }

    public void playerBeAttacked()
    {
        playerHp -= 1;
    }
    

}
