using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonsHandler : MonoBehaviour
{
    public GameObject stepOutsideButton;
    public GameObject goToSoccerTaskButton;
    public GameObject goToFruitTaskButton;
    public GameObject putFruitsInChestButton;
    public GameObject onionToPutInChest;
    public GameObject pumpkinToPutInChest;
    public GameObject throwBallButton;
    public GameObject soccerBall;
    private Vector3 startSoccerBall;
    private Vector3 endSoccerBall;
    private float lerp = 0, duration = 1;
    public static bool throwBall = false;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        stepOutsideButton.SetActive(true);
        goToSoccerTaskButton.SetActive(false);
        goToFruitTaskButton.SetActive(false);
        putFruitsInChestButton.SetActive(false);
        throwBallButton.SetActive(false);
        startSoccerBall = soccerBall.transform.position;
        endSoccerBall = GameObject.Find("DevilTotem").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (throwBall == true)
        {
            lerp += Time.deltaTime / duration;
            soccerBall.transform.position = Vector3.Lerp(startSoccerBall, endSoccerBall, lerp);
        }
    }

    public void goToSoccerTask()
    {
        throwBallButton.SetActive(true);
        goToSoccerTaskButton.SetActive(false);
        player.transform.position = new Vector3(0.9f, 0.6f, 7f);
        player.transform.Rotate(0f, -100f, 0f);
    }

    public void stepOutside()
    {
        player.transform.position = new Vector3(10.8f, 1f, -1.3f);
        stepOutsideButton.SetActive(false);
        goToSoccerTaskButton.SetActive(true);
        goToFruitTaskButton.SetActive(true);
        // also second task button
    }

    public void performSoccerTask()
    {
        throwBall = true;
        throwBallButton.SetActive(false);
        goToFruitTaskButton.SetActive(true);
    }

    public void gotToFruitTask()
    {
        player.transform.position = new Vector3(8.2f, 1.3f, -6);
        player.transform.Rotate(0f, 140f, 0f);
        goToFruitTaskButton.SetActive(false);
        goToSoccerTaskButton.SetActive(true);
        putFruitsInChestButton.SetActive(true);
    }

    public void performFruitTask()
    {
        putFruitsInChestButton.SetActive(false);
        player.transform.position = new Vector3(-2.8f, 1.3f, -28.9f);
        player.transform.Rotate(0f, -80f, 0f);
        onionToPutInChest.transform.position = new Vector3(-2.5f, 0.3f, -30.1f);
        pumpkinToPutInChest.transform.position = new Vector3(-2.4f, 0.3f, -30.2f);
        TasksController.onionTaskFinished = true;
    }
}
