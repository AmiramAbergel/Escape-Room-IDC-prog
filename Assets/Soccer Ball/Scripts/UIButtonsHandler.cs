using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIButtonsHandler : MonoBehaviour
{
    private Vector3 resetPos = new Vector3(-1.81200004f,-0.10100048f,-1.42499995f);
    public GameObject EscapeNextButton;
    public GameObject stepOutsideButton;
    public GameObject goToSoccerTaskButton;
    public GameObject goToSoccerTaskFromFruitButton;
    public GameObject goToSoccerTaskFromFruit2Button;
    public GameObject goToFruitTaskButton;
    public GameObject goToMiniGatesButton;
    public GameObject goToFruitTaskFromSoccerButton;
    public GameObject goToLastTaskButton;
    public GameObject putFruitsInChestButton;
    public GameObject onionToPutInChest;
    public GameObject pumpkinToPutInChest;
    public GameObject throwBallButton;
    public GameObject soccerBall;
    public GameObject finishGameButton;
    public GameObject EnterCodeButton;

    public Transform downTransform1;
    public Transform downTransform2;
    public Transform buttonMesh2;
    public Transform buttonMesh1;
    public GameObject lockpad;
    public string key;
    public UnityEvent unlock;
    public string code = "21";
    string currentCode;

    public Text m_codeDisplay;
    
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

    public void goToSoccerTaskFromFruit()
    {
        player.transform.position = new Vector3(0.9f, 0.6f, 7f);
        player.transform.Rotate(0f, 100f, 0f);
    }

    public void goToSoccerTaskFromFruit2()
    {
        player.transform.position = new Vector3(0.9f, 0.6f, 7f);
        player.transform.Rotate(0f, 180, 0f);
    }

    public void goToLastTask()
    {
        player.transform.position = new Vector3(-20.3700008f,3.59500003f,-10.8710003f);
        player.transform.Rotate(0f, 20, 0f);
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

    public void goToMiniGates()
    {
        player.transform.position = new Vector3(25.0699997f,15.5100002f,-1.76999998f);
        player.transform.Rotate(30, 100, 0);
    }

    public void performFruitTask()
    {
        player.transform.position = new Vector3(-2.8f, 1.3f, -28.9f);
        player.transform.Rotate(0f, -80f, 0f);
        onionToPutInChest.transform.position = new Vector3(-2.5f, 3, -30.1f);
        pumpkinToPutInChest.transform.position = new Vector3(-2.4f, 3, -30.2f);
        TasksController.onionTaskFinished = true;
    }
    public void finishGame()
    {
        player.transform.position = new Vector3(6.73199987f,25.3099995f,-2.59290004f);
        player.transform.Rotate(50, 190, 0);
    }

    public void Nextlevel()
    {
        SceneManager.LoadScene(2);
    }

    public void EnterCode()
    {
        lockpad.SendMessage("KeyEntry", key);
        buttonMesh2.position = downTransform2.position;
        buttonMesh1.position = downTransform1.position;
        
    }
    void KeyEntry(string key){
        currentCode += key;
        if(currentCode == code){
            m_codeDisplay.text = "Code: " + currentCode;
            unlock.Invoke();
        }
        else if(currentCode.Length == code.Length){
            currentCode = "";
            m_codeDisplay.text = "Code: " + currentCode;
        }
        else{
            m_codeDisplay.text = "Code: " + currentCode;
        }
    }


}
