using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeadUI : MonoBehaviour
{
    public GameObject leadTextBox;
    // Start is called before the first frame update
    void Start()
    {
        leadTextBox.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseLeadUI()
    {
        leadTextBox.SetActive(false);
    }
}
