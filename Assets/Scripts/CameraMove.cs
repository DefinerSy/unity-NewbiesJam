using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float CameraMoveSpeed;
    public float borderWidth =50f;
    public float maxPosition;
    public float minPosition;

    private void Update () 
    {
        Vector2 mousPos = Input.mousePosition;
        if(mousPos.y > Screen.height - borderWidth && gameObject.transform.localPosition.y <=maxPosition)
        {
            transform.Translate(transform.up * CameraMoveSpeed*Time.deltaTime);
        }
        if(mousPos.y < borderWidth &&gameObject.transform.localPosition.y>=minPosition)
        {
            transform.Translate(-transform.up * CameraMoveSpeed*Time.deltaTime);
        }
    }
}
