using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage1Task : MonoBehaviour
{
    public GameObject GoToTask2Button;

    // Start is called before the first frame update
    void Start()
    {
        GoToTask2Button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (RedMugController.PlacedRedMugCorrectly && BlueMugController.PlacedBlueMugCorrectly && GreenMugController.PlacedGreenMugCorrectly)
        {
            GoToTask2Button.SetActive(true);
        }
    }
}
