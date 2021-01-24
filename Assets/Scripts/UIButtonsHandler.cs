using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonsHandler : MonoBehaviour
{
    private Vector3 resetPos = new Vector3(-1.81200004f,-0.10100048f,-1.42499995f);
    public GameObject stepOutsideButton;
    public GameObject goToSoccerTaskButton;
    public GameObject goToFruitTaskButton;
    public GameObject goToFruitTaskFromSoccerButton;
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

        player.transform.position = new Vector3(0.9f, 0.6f, 7f);
        player.transform.Rotate(0f, -100f, 0f);
    }

    public void stepOutside()
    {
        player.transform.position = resetPos;
        player.transform.Rotate(0,30,0);
        player.transform.position = new Vector3(8.0f, 1.4f, -1.3f);
    }

    public void performSoccerTask()
    {
        throwBall = true;
        throwBallButton.SetActive(false);

    }

    public void gotToFruitTaskFromSoccer()
    {
        player.transform.position = new Vector3(8.2f, 2, -6);
        player.transform.Rotate(0f, 190f, 0f);
    }

    public void gotToFruitTask()
    {
        player.transform.position = new Vector3(8.2f, 1.3f, -6);
        player.transform.Rotate(0f, 140f, 0f);
    }

    public void performFruitTask()
    {
        player.transform.position = new Vector3(-2.8f, 1.3f, -28.9f);
        player.transform.Rotate(0f, -80f, 0f);
        onionToPutInChest.transform.position = new Vector3(-2.5f, 0.3f, -30.1f);
        pumpkinToPutInChest.transform.position = new Vector3(-2.4f, 0.3f, -30.2f);
        TasksController.onionTaskFinished = true;
    }
}
