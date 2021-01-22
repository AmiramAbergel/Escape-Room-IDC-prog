using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasksController : MonoBehaviour
{

    public static bool soccerBallTaskFinished;
    public static bool onionTaskFinished;
    public static bool thirdTaskFinished;
    public GameObject soccerTaskGate;
    public GameObject onionTaskGate;
    public GameObject frontGate;
    // Start is called before the first frame update
    void Start()
    {
        soccerBallTaskFinished = false;
        onionTaskFinished = false;
        thirdTaskFinished = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (soccerBallTaskFinished && onionTaskFinished)
        {
            soccerTaskGate.SetActive(false);
            onionTaskGate.SetActive(false);
        }

        if (soccerBallTaskFinished && onionTaskFinished && thirdTaskFinished)
        {
            frontGate.SetActive(false);
        }
    }
}
