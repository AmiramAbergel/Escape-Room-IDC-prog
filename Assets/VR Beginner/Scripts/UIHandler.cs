using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public GameObject Player;
    public GameObject GoToTask1Button;
    public GameObject GoToTask2Button;
    public GameObject GoToTask3Button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToTask1()
    {
        Player.transform.position = new Vector3(-5.83f, 1.9f, 3f);
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
        Player.transform.position = new Vector3(2.3f, 1.3f, -2.8f);
        Quaternion rotationPosition = new Quaternion();
        rotationPosition.eulerAngles = new Vector3(0f, 90f, 0f);
        Player.transform.rotation = rotationPosition;
        GoToTask3Button.SetActive(false);
    }

}
