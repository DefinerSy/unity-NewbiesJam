using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrowCost : MonoBehaviour
{
    public GameObject costUI;
    public GameObject branchButton;
    public GameObject spineButton;
    public GameObject leafButton;
    public GameObject growUI;
    private int currentcost;

    // Start is called before the first frame update
    void Start()
    {
        branchButton.GetComponent<Button>().interactable = true;
        spineButton.GetComponent<Button>().interactable = true;
        leafButton.GetComponent<Button>().interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        currentcost = costUI.GetComponent<Cost>().cost;
        CannotGrow();
    }

    public void Grow()//新生成树干/尖刺/树叶时减cost
    {
        costUI.GetComponent<Cost>().cost = currentcost - 2;
        costUI.GetComponent<Cost>().costText.text = costUI.GetComponent<Cost>().cost.ToString();
        growUI.SetActive(false);
    }

    public void CannotGrow()
    {
        if(currentcost < 2)
        {
            branchButton.GetComponent<Button>().interactable = false;
            spineButton.GetComponent<Button>().interactable = false;
            leafButton.GetComponent<Button>().interactable = false;
        }
    }
}
