using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cost : MonoBehaviour
{
    public Text costText;
    public int cost;
    private GameObject[] leaf_array;
    private int leaf_count;
    public bool roundIsStart = false;//接口
    // Start is called before the first frame update
    void Start()
    {
        cost = 5;
        costText.text = cost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(roundIsStart)
        {
            AddCost();
            roundIsStart = false;
        }
    }

    public void AddCost()//每回合开始时回cost
    {
        leaf_array = GameObject.FindGameObjectsWithTag("Leaf");
        leaf_count = leaf_array.Length;
        cost = 5 + leaf_count;
        costText.text = cost.ToString();
    }


}
