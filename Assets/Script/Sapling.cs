using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sapling : MonoBehaviour
{
    public GameObject growChooseUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseDown();
    }

    private void MouseDown()//鼠标进入带苗树枝时GrowChooseUI开启
    {
        if(Input.GetMouseButtonDown(0))
        {
            growChooseUI.SetActive(true);
        }
    }
}
