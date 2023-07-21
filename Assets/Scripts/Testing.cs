using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour
{
    void Start()
    {
        //c2d = GetComponent<Collider2D>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("1");
    }
}
