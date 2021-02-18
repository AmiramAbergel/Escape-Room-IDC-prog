using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerTaskButtonHandler : MonoBehaviour
{
    public static GameObject goToSoccerTaskButton;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        goToSoccerTaskButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToSoccerTask()
    {
        player.transform.position = new Vector3(0.8f, 1.5f, 7.8f);
    }
}
