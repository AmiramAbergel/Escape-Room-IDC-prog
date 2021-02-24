using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleExperimentController : MonoBehaviour {

    // our trial logger component
    TrialLogger trialLogger;

    // participant id (string)
    public string participantID = "0001";


    // Use this for initialization
    void Start()
    {
        // define the names of the custom datapoints we want to log
        // trial number, participant ID, trial start/end time are logged automatically
        List<string> columnList = new List<string> { "sphere_x", "sphere_y" };

        // initialise trial logger
        trialLogger = GetComponent<TrialLogger>();
        trialLogger.Initialize(participantID, columnList);

        // here we start the first trial immediately, you can start it at any time
        trialLogger.StartTrial();

    }

    // Update is called once per frame
    void Update()
    {

    }


    // This function is called when we click the sphere
    public void LastTeleport()
    {

        // now we end the trial, which stores data for this trial, then increments the trial number
        trialLogger.EndTrial();


    }


    public void QuitGame()
    {
        // save any game data here
        #if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}