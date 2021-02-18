using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCsvEnd : MonoBehaviour
{
    public ExampleExperimentController experimentController;
    void OnEnable()
    {
        experimentController.LastTeleport();
    }

}
