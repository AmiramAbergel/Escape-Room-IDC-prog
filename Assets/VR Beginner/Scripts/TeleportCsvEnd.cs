using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCsvEnd : MonoBehaviour
{
    public ExampleExperimentController experimentController;

    void OnEnable()
    {
       GameObject.Find("Experiment").GetComponent<ExampleExperimentController>().lastTeleport();
       experimentController.GetComponent<ExampleExperimentController>().lastTeleport();
    }

}
