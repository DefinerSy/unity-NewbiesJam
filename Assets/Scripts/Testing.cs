using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour
{
    private Grid<bool> grid;
    // Start is called before the first frame update
    void Start()
    {
        grid = new Grid<bool>(10,10,10f,new Vector3(0,0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = UtilsClass.GetMouseWorldPosition();
            grid.SetValue(position,true);
            //Debug.Log(UtilsClass.GetMouseWorldPosition().ToString());
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }
}
