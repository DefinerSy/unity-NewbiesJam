using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowChooseUI : MonoBehaviour
{
    public GameObject sapling;
    public RectTransform rectTrans;
    public Vector2 offset;
    Transform sap;
    // Start is called before the first frame update
    void Start()
    {
        sap = sapling.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //修正树苗生长选择UI位置
        Vector2 screenPos = Camera.main.WorldToScreenPoint(sap.transform.position);
        rectTrans.position = screenPos + offset;
    }

}
