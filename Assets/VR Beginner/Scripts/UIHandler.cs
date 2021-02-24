using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UIHandler : MonoBehaviour
{
    public GameObject Player;
    public GameObject GoToTask1Button;
    public GameObject GoToTask2Button;
    public GameObject GoToTask3Button;
    public GameObject GoToFinishButton;
    public GameObject EnterCodeButton;
    
    public Transform downTransform1;
    public Transform downTransform2;
    public Transform downTransform3;
    public Transform downTransform4;
    public Transform downTransform5;
    public Transform downTransform6;
    public Transform buttonMesh1;
    public Transform buttonMesh2;
    public Transform buttonMesh3;
    public Transform buttonMesh4;
    public Transform buttonMesh5;
    public Transform buttonMesh6;
    public GameObject lockpad;
    public string key;
    public string code = "ANIMAL";
    string currentCode;
    public UnityEvent unlock;

    public Text m_codeDisplay;

    public void GoToTask1()
    {
        Player.transform.position = new Vector3(-5.34000015f,2.88000011f,-1.24800003f);
        Quaternion rotationPosition = new Quaternion();
        rotationPosition.eulerAngles = new Vector3(0f, 0f, 0f);
        Player.transform.rotation = rotationPosition;
        GoToTask1Button.SetActive(false);
    }

    public void GoToTask2()
    {
        Player.transform.position = new Vector3(-0.5f, 1.5f, 6.5f);
        Quaternion rotationPosition = new Quaternion();
        rotationPosition.eulerAngles = new Vector3(0f, 90f, 0f);
        Player.transform.rotation = rotationPosition;
        GoToTask2Button.SetActive(false);
    }

    public void GoToTask3()
    {
        Player.transform.position = new Vector3(0.85799998f,3.93899989f,-2.69700003f);
        Quaternion rotationPosition = new Quaternion();
        rotationPosition.eulerAngles = new Vector3(30f, 90f, 0f);
        Player.transform.rotation = rotationPosition;
        GoToTask3Button.SetActive(false);
    }
    public void GoFinish()
    {
        Player.transform.position = new Vector3(-1.03999996f,4.58199978f,3.3599999f);
        Quaternion rotationPosition = new Quaternion();
        rotationPosition.eulerAngles = new Vector3(0, -90, 0);
        Player.transform.rotation = rotationPosition;
    }

    public void EnterCode()
    {
        EnterCodeButton.SetActive(false);
        GoToFinishButton.SetActive(false);
        lockpad.SendMessage("KeyEntry", key);
        buttonMesh1.position = downTransform1.position;
        buttonMesh2.position = downTransform2.position;
        buttonMesh3.position = downTransform3.position;
        buttonMesh4.position = downTransform4.position;
        buttonMesh5.position = downTransform5.position;
        buttonMesh6.position = downTransform6.position;
        GoToFinishButton.SetActive(true);

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
