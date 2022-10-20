using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChooseUI : MonoBehaviour
{
    public GameObject branch;
    public RectTransform rectTrans;
    private Vector2 offset;
    Transform bra;
    // Start is called before the first frame update
    void Start()
    {
        bra = branch.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //修正选择树干生长方向UI位置
        Vector2 screenPos = Camera.main.WorldToScreenPoint(bra.transform.position);
        rectTrans.position = screenPos + offset;
    }
}
