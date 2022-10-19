using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChooseUI : MonoBehaviour
{
    public GameObject branch;
    public RectTransform rectTrans;
    public Vector2 offset;
    Transform bra;
    // Start is called before the first frame update
    void Start()
    {
        bra = branch.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPos = Camera.main.WorldToScreenPoint(bra.transform.position);
        rectTrans.position = screenPos + offset;
    }
}
