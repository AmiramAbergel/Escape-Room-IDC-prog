using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepOutsideButtonHandler : MonoBehaviour
{
    public GameObject stepOutsideButton;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        stepOutsideButton.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void stepOutside()
    {
        player.transform.position = new Vector3(10.8f, 1.5f, -1.3f);
        stepOutsideButton.SetActive(false);
        SoccerTaskButtonHandler.goToSoccerTaskButton.SetActive(true);
        // also second task button
    }

}
