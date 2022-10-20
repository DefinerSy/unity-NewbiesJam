using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sapling : MonoBehaviour
{
    public GameObject growChooseUI;
    public Camera m_Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseDown();
    }

    private void MouseDown()//鼠标左键单击树苗时在树苗位置树苗生长选择UI
    {
        if(Input.GetMouseButtonDown(0))
        {
            //growChooseUI.SetActive(true);
            Ray ray = m_Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawLine(ray.origin, hit.point);
                GameObject gameobj = hit.collider.gameObject;
                if (gameobj.tag == "Sapling")
                {
                    growChooseUI.transform.position = Input.mousePosition;
                    growChooseUI.SetActive(true);
                }
            }
        }
    }
}
