using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskControl : MonoBehaviour
{
    public static bool thirdTaskFinished;
    public GameObject SecretWall;
    void Start()
    {
        thirdTaskFinished = false;
    }

    void Update()
    {

    }
    public void setAndFinish(){
        movmentWall.Move = true;
    }
}
