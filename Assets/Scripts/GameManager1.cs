using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    GameObject[] gameObject_Tile1,gameObject_Tile2,gameObject_Tile3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void aChange()
    {
        gameObject_Tile1 = GameObject.FindGameObjectsWithTag("Branch2");
        for(int i = 0; i < gameObject_Tile1.Length; i++) 
        {
            gameObject_Tile1[i].GetComponent<GridCreate1>().a = true;
        }

        gameObject_Tile2 = GameObject.FindGameObjectsWithTag("Branch3");
        for(int i = 0; i < gameObject_Tile2.Length; i++) 
        {
            gameObject_Tile2[i].GetComponent<GridCreate2>().a = true;
        }
        
        gameObject_Tile3 = GameObject.FindGameObjectsWithTag("Branch4");
        for(int i = 0; i < gameObject_Tile3.Length; i++) 
        {
            gameObject_Tile3[i].GetComponent<GridCreate3>().a = true;
        }
        
    }
}
