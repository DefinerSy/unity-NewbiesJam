using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileChildrenCollision : MonoBehaviour
{
    public bool Collision = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("1");
        Collision = true;
        if (other.gameObject.tag == "Sapling")
        {
            
        }
    }
}
