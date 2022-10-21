using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionCost : MonoBehaviour
{
    public GameObject costUI;
    public GameObject directionUI;
    public GameObject upButton;
    public GameObject downButton;
    public GameObject leftButton;
    public GameObject rightButton;
    private int currentcost;
    // Start is called before the first frame update
    void Start()
    {
        upButton.GetComponent<Button>().interactable = true;
        downButton.GetComponent<Button>().interactable = true;
        leftButton.GetComponent<Button>().interactable = true;
        rightButton.GetComponent<Button>().interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        currentcost = costUI.GetComponent<Cost>().cost;
        CannotDirection();
    }

    public void DirectionGrow()
    {
        costUI.GetComponent<Cost>().cost = currentcost - 2;
        costUI.GetComponent<Cost>().costText.text = costUI.GetComponent<Cost>().cost.ToString();
        directionUI.SetActive(false);
    }

    public void CannotDirection()
    {
        if (currentcost < 2)
        {
            upButton.GetComponent<Button>().interactable = false;
            downButton.GetComponent<Button>().interactable = false;
            leftButton.GetComponent<Button>().interactable = false;
            rightButton.GetComponent<Button>().interactable = false;
        }
    }
}
